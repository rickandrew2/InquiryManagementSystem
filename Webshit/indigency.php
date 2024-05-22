<?php
include("database.php");

$message = "";  // Store status message

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $name = $_POST['name'];
    $age = $_POST['age'];
    $parents = $_POST['Parents'];
    $sitio = $_POST['sitio'];
    $date = $_POST['date'];

    // Check if the purpose is "Others"
    if ($_POST['purpose'] == "Others") {
        $purpose = $_POST['other']; // Use the value from the "other" input box
    } else {
        $purpose = $_POST['purpose']; // Use the value from the dropdown directly
    }

    // Begin transaction
    mysqli_begin_transaction($conn);

    try {
        // Step 1: Insert into `docreq` table using a prepared statement to avoid SQL injection
        $insertDocReq = "INSERT INTO docreq (requestername, docType, reqDate, status) VALUES (?, 'Indigency', NOW(), 'Pending')";
        $stmt = mysqli_prepare($conn, $insertDocReq);
        mysqli_stmt_bind_param($stmt, "s", $name);
        mysqli_stmt_execute($stmt);
        $docreqid = mysqli_insert_id($conn);
        mysqli_stmt_close($stmt);

        // Step 2: Insert into `indigency` table
        $stmt = mysqli_prepare($conn, "INSERT INTO indigency (docreqid, name, age, Parents, sitio, purpose, date) VALUES (?, ?, ?, ?, ?, ?, ?)");
        mysqli_stmt_bind_param($stmt, "isissss", $docreqid, $name, $age, $parents, $sitio, $purpose, $date);
        mysqli_stmt_execute($stmt);
        mysqli_stmt_close($stmt);

        // Commit transaction
        mysqli_commit($conn);

        $message = "Form submitted successfully!";

    } catch (mysqli_sql_exception $e) {
        mysqli_rollback($conn);
        $message = "Database error: " . $e->getMessage();
    }

    mysqli_close($conn);

    // Return message to JavaScript
    echo json_encode(array("message" => $message));
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="indigency.css">
    <title>Indigency Form</title>
</head>
<body>
    
    <section class="container">
        <img src="brgycover.png" alt="brgylogo" class="brgylogo">
        <header>Indigency Form</header>
        <form id="indigencyForm" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post" class="form" onsubmit="submitForm(event)">
            <div class="column">
                <div class="input-box">
                    <label>Full Name</label>
                    <input type="text" name="name" placeholder="Enter full name" required />
                </div>

                <div class="input-box">
                    <label>Age</label>
                    <input type="number" name="age" placeholder="Enter your Age" required min="1" max="120">
                </div>
            </div>

            <div class="input-box">
                <label>Parent/Guardian</label>
                <input type="text" name="Parents" placeholder="Enter your Parent's/Guardian's name" required />
            </div>

            <div class="input-box">
                <label>Sitio/Purok</label>
                <input type="text" name="sitio" placeholder="Enter your Sitio/Purok" required />
            </div>

            <div class="input-box">
                <label>Date</label>
                <input type="date" name="date" required />
            </div>

            <div class="input-box">
                <label>Purpose</label>
                <div class="column">
                    <div class="select-box">
                        <select id="purposeSelect" name="purpose" required onchange="toggleOtherInput();">
                            <option hidden>Please select your purpose</option>
                            <option value="Application">Application</option>
                            <option value="Scholarship">Scholarship</option>
                            <option value="Job Application">Job Application</option>
                            <option value="Financial Assistance">Financial Assistance</option>
                            <option value="Others">Others</option>
                        </select>
                    </div>
                </div>
            </div>

            <div id="otherInput" class="input-box" style="display: none;">
                <input type="text" name="other" placeholder="Please Specify">
            </div>
            <br>

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
    <script src="indigency.js"></script>
</body>
</html>
