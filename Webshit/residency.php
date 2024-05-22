<?php
include("database.php");

$message = "";  // Store status message

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $name = $_POST['name'];
    $age = $_POST['age'];
    $status = $_POST['status'];
    $date = $_POST['date'];

    // Begin transaction
    mysqli_begin_transaction($conn);

    try {
        // Step 1: Insert into `docreq` table using a prepared statement to avoid SQL injection
        $insertDocReq = "INSERT INTO docreq (requestername, docType, reqDate, status) VALUES (?, 'Residency', NOW(), 'Pending')";
        $stmt = mysqli_prepare($conn, $insertDocReq);
        mysqli_stmt_bind_param($stmt, "s", $name); // "s" indicates the parameter is a string
        mysqli_stmt_execute($stmt);
        $docreqid = mysqli_insert_id($conn); // Get the last inserted ID
        mysqli_stmt_close($stmt);

        // Step 2: Insert into `residency` table
        $insertResidency = "INSERT INTO residency (docreqid, name, age, status, date) VALUES (?, ?, ?, ?, NOW())";
        $stmt = mysqli_prepare($conn, $insertResidency);
        mysqli_stmt_bind_param($stmt, "isis", $docreqid, $name, $age, $status); 
        mysqli_stmt_execute($stmt);
        mysqli_stmt_close($stmt);

        // Commit transaction
        mysqli_commit($conn);
        
        $message = "Data inserted successfully!";
        
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
    <link rel="stylesheet" href="residency.css">
    <title>Residency Form</title>
</head>
<body>
    
    <section class="container">
        <img src="brgycover.png" alt="brgylogo" class="brgylogo">
        <header>Residency Form</header>
        <form id="residencyForm" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]);?>" method="post" class="form" onsubmit="submitForm(event)">
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
                <label>Date</label>
                <input type="date" name="date" required />
            </div>

            <div class="input-box">
                <label>Civil Status</label>
                <div class="column">
                    <div class="select-box">
                        <select id="statusSelect" name="status" required>
                            <option hidden>Please select your status</option>
                            <option value="Single">Single</option>
                            <option value="Married">Married</option>
                        </select>
                    </div>
                </div>
            </div>
             <br>

            <!-- Submit Button -->
            <button type="submit" class="btn" onclick="submitFormC()">Submit</button>
            <div class="popup" id="popup">
                <img src="checkmark.png" alt="">
                <h2>Thank You!</h2>
                <p>Your form has been submitted successfully.</p>
                <button type="button" onclick="closePopup(); resetFormC();"> OK </button>
            </div>
        </form>
        <!-- Display Message -->
        <?php if ($message):?>
            <p><?php echo $message;?></p>
        <?php endif;?>
    </section>
    <script src="residency.js"></script>
</body>
</html>
