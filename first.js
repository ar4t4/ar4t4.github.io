const roles = ['Student', 'Photographer', 'Handsome'];

// Get the element to update
const element = document.querySelector(".typing");
if (element) {
    // The element with class "typing" was found
    console.log("Element found:", element);
    element.textContent = ''; // Clear the initial content
} else {
    // The element with class "typing" was not found
    console.log("Element not found.");
}

// Initialize index for roles array
let index = 0;

// Initialize index for characters in the current role
let charIndex = 0;

// Function to update the roles
function updateRoles() {
    // Get the current role
    const role = roles[index];

    // Check if there are characters left to reveal
    if (charIndex < role.length) {
        // Get the next character
        const nextChar = role[charIndex];

        // Append the next character to the element content
        element.textContent += nextChar;

        // Increment character index for the next iteration
        charIndex++;

        // Call updateRoles recursively for the next character
        setTimeout(updateRoles, 100); // Adjust the delay as needed
    } else {
        // Pause for 1 second after finishing the word
        setTimeout(() => {
            // Reset character index for the next role
            charIndex = 0;

            // Move to the next role
            index++;

            // If index exceeds the length of roles array, reset it to 0
            if (index >= roles.length) {
                index = 0;
            }

            // Clear the element content before showing the next word
            element.textContent = '';

            // Call updateRoles recursively to start revealing the next word
            updateRoles();
        }, 1000); // Pause for 1 second
    }
}

// Call the updateRoles function to start revealing the first word
updateRoles();
