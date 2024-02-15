const roles = ['Student', 'Photographer', 'Handsome'];

const element = document.querySelector(".typing");
if (element) {
    console.log("Element found:", element);
    element.textContent = ''; 
} else {
    console.log("Element not found.");
}

let index = 0;
let charIndex = 0;
function updateRoles() {
    const role = roles[index];

   
    if (charIndex < role.length) {
        const nextChar = role[charIndex];

        element.textContent += nextChar;
        charIndex++;

       
        setTimeout(updateRoles, 100); 
    } else {
      
        setTimeout(() => {
        
            charIndex = 0;

            
            index++;

           
            if (index >= roles.length) {
                index = 0;
            }

           
            element.textContent = '';

            
            updateRoles();
        }, 1000); 
    }
}

/
updateRoles();
// function sendEmail(event) {
   
//   // Construct the mailto URL with subject and body parameters
//  // var mailtoURL = 'mailto:asifrahman00010@gmail.com?subject=' + encodeURIComponent('Subject Here') + '&body=' + encodeURIComponent(body);
//  //var name = document.getElementById("name").value;
//   //  var email = document.getElementById("email").value;
//     var body = document.getElementById("body").value;

//   //  Open the default email client with the mailto URL
//    //window.open();
//    alert('Your message has been sent successfully');
//    console.log(body);
//     // Prevent the default action of the anchor tag
//     event.preventDefault();

//     // Show a success message
   
// }
function sendEmail(event) {
    // Prevent the default form submission behavior
    event.preventDefault();

    // Retrieve the form input values
    var name = document.getElementById("name").value;
    var subject = document.getElementById("Subject").value;
    var body = document.getElementById("body").value;

    // Validate the input values (optional)
    if (name.trim() === '' || subject.trim() === '' || body.trim() === '') {
        alert('Please fill in all fields');
        return;
    }

    // Construct the mailto URL with subject and body parameters
    var mailtoURL = 'mailto:asifrahman00010@gmail.com?subject=' + encodeURIComponent('subject') + '&body=' + encodeURIComponent(body);

    // Open the default email client with the mailto URL
    window.open(mailtoURL);

    // Show a success message
    alert('Your message has been sent successfully');
}

