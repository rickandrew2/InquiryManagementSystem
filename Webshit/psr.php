<?php
include("database.php");

$message = "";  // Store status message

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $fullname = $_POST['fullname'];
    $address = $_POST['address'];
    $contactInfo = $_POST['contact_info'];
    $dob = $_POST['dob'];
    $natureOfRequest = $_POST['nature_of_request'];
    $specificServiceNeed = $_POST['psr_need'];

    // Begin transaction
    mysqli_begin_transaction($conn);

    try {
    
        // Step 2: Insert into `psr` table
            $stmt = mysqli_prepare($conn, "INSERT INTO psr (fullname, address, contactInfo, dob, natureOfRequest, specificServiceNeed) VALUES (?, ?, ?, ?, ?, ?)");
            mysqli_stmt_bind_param($stmt, "ssssss", $fullname, $address, $contactInfo, $dob, $natureOfRequest, $specificServiceNeed);
            mysqli_stmt_execute($stmt);
            mysqli_stmt_close($stmt);

            // Commit transaction
            mysqli_commit($conn);

        
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
    <link rel="stylesheet" href="psr.css">
    <title>Public Service Request</title>
</head>
<body>
    
    <section class="container">
        <img src="brgycover.png" alt="brgylogo" class="brgylogo">
        <header>Service Request Form</header>
        <form id="psrForm" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post" class="form" onsubmit="submitForm(event)">
            <div class="column">
                <div class="input-box">
                    <label>Full Name</label>
                    <input type="text" name="fullname" placeholder="Enter full name" required />
                </div>

                <div class="input-box">
                    <label>Address</label>
                    <input type="text" name="address" placeholder="Enter your address" required />
                </div>

                <div class="input-box">
                    <label>Contact Information</label>
                    <input type="text" name="contact_info" placeholder="Enter your contact information" required />
                </div>

                <div class="input-box">
                    <label>Date of Birth</label>
                    <input type="date" name="dob" required />
                </div>

                <div class="input-box">
                    <label>Nature of Request</label>
                    <div class="column">
                        <div class="select-box">
                            <select name="nature_of_request" required>
                                <option hidden>Please select nature of request</option>
                                <option value="Scholarship">Scholarship</option>
                                <option value="Job Application">Job Application</option>
                                <option value="Medical Assistance">Medical Assistance</option>
                                <option value="Financial Assistance">Financial Assistance</option>
                                <option value="Public Safety and Security">Public Safety and Security</option>
                                <option value="Social Welfare Services">Social Welfare Services</option>
                                <option value="Livelihood and Skills Training">Livelihood and Skills Training</option>
                                <option value="Health Care Services">Health Care Services</option>
                                <option value="Legal Assistance">Legal Assistance</option>
                                <option value="Community Infrastructure">Community Infrastructure</option>
                            </select>
                        </div>
                    </div>
                </div>

                <div class="input-box">
                <label>Specific Service Need</label>
                    <textarea name="psr_need" rows="4" placeholder="Enter the specific service need" required></textarea>
                </div>
            </div>
             <br>
             <br>   
            <!-- Submit Button -->
            <button type="submit" class="btn" onclick="submitFormD()">Submit</button>
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
    <script src="psr.js"></script>
</body>
</html>
