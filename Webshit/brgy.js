// Event listener setup for Civil Status
var civilStatusRadio = document.getElementsByName("cs");
var spouseInput = document.getElementById("spouseInput");
spouseInput.style.display = "none"; // Initially hide the spouse input
for (var i = 0; i < civilStatusRadio.length; i++) {
    civilStatusRadio[i].addEventListener("change", function() {
        if (this.value === "Married") {
            spouseInput.style.display = "block";
        } else {
            spouseInput.style.display = "none";
        }
    });
}

// Corrected JavaScript for handling the Purpose Select dropdown
var purposeSelect = document.getElementById("purposeSelect"); // Correct method to access the select element
var otherInput = document.getElementById("otherInput");
otherInput.style.display = "none"; // Initially hide the other input

purposeSelect.addEventListener("change", function() {
    if (this.value === "Others") {
        otherInput.style.display = "block";
    } else {
        otherInput.style.display = "none";
    }
});

function submitFormB(event) {
    // Prevent the default form submission behavior
    event.preventDefault();

    // Validate the form input here
    var isValid = validateFormB(); // Call a function for form validation, which returns true if the form is valid

    if (isValid) {
        // If the input is valid, show the popup and send the form data using AJAX
        document.getElementById("popup").classList.add("open-popup");

        // Send form data using AJAX
        var formData = new FormData(event.target);
        var xhr = new XMLHttpRequest();
        xhr.open("POST", "brgyC.php", true);
        xhr.onload = function() {
            if (xhr.status === 200) {
                // Form submission successful
                console.log("Form submitted successfully.");
            } else {
                // Form submission failed
                console.log("Form submission failed.");
            }
        };
        xhr.send(formData);
    }
}

function resetFormB() {
    document.getElementById("brgyclearanceForm").reset();
}

function validateFormB() {
    // Get the value of name
    var name = document.getElementsByName("name")[0].value;

    // Get the value of age
    var age = document.getElementsByName("age")[0].value;

    // Get the value of civil status
    var civilStatus = document.querySelector('input[name="cs"]:checked');

    // Get the value of nationality
    var nationality = document.getElementsByName("nationality")[0].value;

    // Get the value of date
    var date = document.getElementsByName("date")[0].value;

    // Get the value of purpose
    var purpose = document.getElementById("purposeSelect").value;

    // Get the value of otherPurpose if "Others" is selected
    var otherPurpose = "";
    if (purpose === "Others") {
        otherPurpose = document.getElementsByName("other")[0].value;
    }

    // Check if name is not empty
    if (name.trim() === "") {
        alert("Please enter your full name.");
        return false;
    }

    // Check if age is a number
    if (isNaN(age) || age.trim() === "") {
        alert("Please enter a valid age.");
        return false;
    }

    // Check if civil status is selected
    if (!civilStatus) {
        alert("Please select your civil status.");
        return false;
    }

    // Check if nationality is not empty
    if (nationality.trim() === "") {
        alert("Please enter your nationality.");
        return false;
    }

    // Check if date is not empty
    if (date.trim() === "") {
        alert("Please select a date.");
        return false;
    }

    // Check if purpose is selected or "Others" with specified purpose
    if (purpose.trim() === "" || (purpose === "Others" && otherPurpose.trim() === "")) {
        alert("Please specify the purpose.");
        return false;
    }

    // If all validations pass, return true
    return true;
}


// Attach event listener for form submission
document.addEventListener("DOMContentLoaded", function() {
    var form = document.getElementById('brgyclearanceForm');
    form.addEventListener('submit', submitFormB);
});

function closePopup() {
    document.getElementById("popup").classList.remove("open-popup");
}
