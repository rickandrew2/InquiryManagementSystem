<?php
include("database.php");

$message = "";  // Store status message

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $name = $_POST['name'];
    $address = $_POST['address'];
    $contact_info = $_POST['contact_info'];
    $date = $_POST['date'];

    // Check if the nature of complaint is "Others"
    if ($_POST['purpose'] == "Others") {
        $complaint_nature = $_POST['otherPurpose']; // Use the value from the "other" input box
    } else {
        $complaint_nature = $_POST['purpose']; // Use the value from the dropdown directly
    }
    
    $complaint_details = $_POST['complaint_details'];

    // Begin transaction
    mysqli_begin_transaction($conn);

    try {
        
        // Step 2: Insert into `complaint` table
        $stmt = mysqli_prepare($conn, "INSERT INTO complaint (fullname, address, contact_info, complaint_nature, complaint_details, created_at) VALUES (?, ?, ?, ?, ?, NOW())");
        mysqli_stmt_bind_param($stmt, "sssss", $name, $address, $contact_info, $complaint_nature, $complaint_details);
        mysqli_stmt_execute($stmt);
        mysqli_stmt_close($stmt);

        // Commit transaction
        mysqli_commit($conn);
        
        $message = "Complaint submitted successfully!";
        
    } catch (mysqli_sql_exception $e) {
        mysqli_rollback($conn);
        $message = "Database error: " . $e->getMessage();
    }

    mysqli_close($conn);
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="rc.css">
    <title>Residents Complaints</title>
</head>
<body>
    
    <section class="container">
        <img src="brgycover.png" alt="brgylogo" class="brgylogo">
        <header>Residents Complaints</header>
        <form id="residencyForm" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post" class="form" onsubmit="submitForm(event)">
            <div class="column">
                <div class="input-box">
                    <label>Full Name</label>
                    <input type="text" name="name" placeholder="Enter full name" required />
                </div>
            </div>
            <br>
            <div class="input-box">
                <label>Address</label>
                <input type="text" name="address" placeholder="Enter your Address" required />
            </div>
            <br>
            <div class="input-box">
                <label>Contact Information</label>
                <input type="text" name="contact_info" placeholder="Enter your contact number" required />
            </div>
            <br>
            <div class="input-box">
                <label>Date</label>
                <input type="date" name="date" required />
            </div>
            <br>
            <div class="input-box">
                    <label>Nature of Complaint</label>
                    <div class="column">
                        <div class="select-box">
                            <select id="purposeSelect" name="purpose" required onchange="toggleOtherInput();">
                                <option hidden>Please select the nature of your complaint</option>
                                <option value="Noise disturbances">Noise disturbances</option>
                                <option value="Neighbor disputes">Neighbor disputes</option>
                                <option value="Illegal parking or traffic congestion">Illegal parking or traffic congestion</option>
                                <option value="Garbage disposal or cleanliness issues">Garbage disposal or cleanliness issues</option>
                                <option value="Unsanitary conditions or pest infestations">Unsanitary conditions or pest infestations</option>
                                <option value="Animal-related complaints">Animal-related complaints</option>
                                <option value="Drug-related activities or suspicious behavior">Drug-related activities or suspicious behavior</option>
                                <option value="Safety concerns">Safety concerns</option>
                                <option value="Water or electricity supply issues">Water or electricity supply issues</option>
                                <option value="Violations of barangay ordinances or regulations">Violations of barangay ordinances or regulations</option>
                                <option value="Domestic disputes or family conflicts">Domestic disputes or family conflicts</option>
                                <option value="Illegal businesses or unauthorized structures">Illegal businesses or unauthorized structures</option>
                                <option value="Environmental concerns">Environmental concerns</option>
                                <option value="Public health issues">Public health issues</option>
                                <option value="Others">Others</option>
                            </select>
                        </div>
                    </div>
                </div>

                <div id="otherInput" class="input-box" style="display: none;">
                    <input type="text" name="other" placeholder="Please Specify">
                </div>
                <br>

            <div class="input-box">
                <label>Detail of Complaint</label>
                <textarea name="complaint_details" rows="4" placeholder="Enter details of your complaint" required></textarea>
            </div>

            <!-- Submit Button -->
            <button type="submit" class="btn">Submit</button>
            <div class="popup" id="popup">
                <img src="checkmark.png" alt="">
                <h2>Thank You!</h2>
                <p>Your form has been submitted successfully.</p>
                <button type="button" onclick="closePopup(); resetForm();"> OK </button>
            </div>
        </form>

        <?php if ($message): ?>
            <p><?php echo $message; ?></p>
        <?php endif; ?>
    </section>
    <script src="rc.js"></script>
</body>
</html>
