<?php
include("database.php");

    $message = "";  // Store status message

    // Check if the form is submitted
    if ($_SERVER["REQUEST_METHOD"] == "POST") {
        // Validate and sanitize inputs
        $name = $_POST['name'];
        $age = $_POST['age'];
        $civil_status = ($_POST['cs']);
        $nationality = $_POST['nationality'];
        $date = $_POST['date'];
        $spouse_name = $_POST['spouse'];
        $sex = $_POST['sex'];
        $purpose = $_POST['purpose'] == "Others" ? $_POST['other'] : $_POST['purpose'];

        // Begin transaction
        mysqli_begin_transaction($conn);

        try {
            // Step 1: Insert into `docreq` table using a prepared statement to avoid SQL injection
            $insertDocReq = "INSERT INTO docreq (requestername, docType, reqDate, status) VALUES (?, 'Barangay Clearance', NOW(), 'Pending')";
            $stmt = mysqli_prepare($conn, $insertDocReq);
            mysqli_stmt_bind_param($stmt, "s", $name);
            mysqli_stmt_execute($stmt);
            $docreqid = mysqli_insert_id($conn);
            mysqli_stmt_close($stmt);

            // Step 2: Insert into `brgyclearance` table
            $stmt = mysqli_prepare($conn, "INSERT INTO brgyclearance (docreqid, name, age, civilstatus, spousename, purpose, nationality, sex, date) VALUES (?, ?, ?, ?, ?, ?, ?, ?, NOW())");
            mysqli_stmt_bind_param($stmt, "isisssss", $docreqid, $name, $age, $civil_status, $spouse_name, $purpose, $nationality, $sex);

            mysqli_stmt_execute($stmt);
            mysqli_stmt_close($stmt);

            // Commit transaction
            mysqli_commit($conn);
            $message = "Data inserted successfully.";
            
        } catch (mysqli_sql_exception $e) {
            mysqli_rollback($conn);
            $message = "Database error: " . $e->getMessage();
            error_log($message); // Log the error for debugging
        }

        mysqli_close($conn);
        
        // Provide feedback to the user
        echo $message;
    }
    ?>

    <!DOCTYPE html>
    <html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv="X-UA-Compatible" content="ie=edge">
        <link rel="stylesheet" href="brgy.css">
        <title>Barangay Clearance Form</title>
    </head> 
    <body>
        
        <section class="container">
            <img src="brgycover.png" alt="brgylogo" class="brgylogo">
            <header>Barangay Clearance</header>
            <form id="brgyclearanceForm" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post" class="form" onsubmit="submitForm(event)">
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
                    <br>
                    <div class="radio-box">
                        <label>Civil Status</label><br>

                        <input type="radio" name="cs" value="Single" required> Single<br>
                        <input type="radio" name="cs" value="Married"> Married<br>
                        <input type="radio" name="cs" value="Divorced"> Divorced<br>
                        <input type="radio" name="cs" value="Widowed"> Widowed<br>
                    </div>

                    <div id="spouseInput" class="input-box" style="display: none;">
                        <label>Spouse Name</label>
                        <input type="text" name="spouse" placeholder="Enter spouse name">
                    </div>
                

                <div class="input-box">
                    <label>Nationality</label>
                    <input type="text" name="nationality" placeholder="Enter your Nationality" required />
                </div>

                <div class="gender-box">
                    <label>Sex</label><br>
                    <div class="radio-box">
                        <input type="radio" name="sex" value="Male" required> Male<br>
                        <input type="radio" name="sex" value="Female"> Female<br>
                    </div>
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
                                <option value="Identification and Verification">Identification and Verification</option>
                                <option value="Residency Confirmation">Residency Confirmation</option>
                                <option value="Legal Compliance">Legal Compliance</option>
                                <option value="Character Reference">Character Reference</option>
                                <option value="Community Safety">Community Safety</option>
                                <option value="Governmental and Administrative Functions">Governmental and Administrative Functions</option>
                                <option value="Employment requirement">Employment requirement</option>
                                <option value="Travel requirement">Travel requirement</option>
                                <option value="Community record keeping">Community record keeping</option>
                                <option value="Business permit application">Business permit application</option>
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
                <button type="submit" class="btn" onclick="submitFormB()">Submit</button>
                <div class="popup" id="popup">
                    <img src="checkmark.png" alt="">
                    <h2>Thank You!</h2>
                    <p>Your form has been submitted successfully.</p>
                    <button type="button" onclick="closePopup(); resetFormB();"> OK </button>
                </div>
            </form>

            <?php if ($message): ?>
                <p><?php echo $message; ?></p>
            <?php endif; ?>
        </section>
        <script src="brgy.js"></script>

    </body>
    </html>
