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

// bdidcbdcec cucc c cbciecbcc ueiiiiwv
const navMenu = document.getElementById("nav-menu"),
  navToggle = document.getElementById("nav-toggle");
navClose = document.getElementById("nav-close");
if (navToggle) {
  navToggle.addEventListener("click", () => {
    navMenu.classList.add("show-menu");
  });
}

if (navClose) {
  navClose.addEventListener("click", () => {
    navMenu.classList.remove("show-menu");
  });
}

/*==================== REMOVE MENU MOBILE ====================*/
const navLink = document.querySelectorAll(".nav__link");

function linkAction() {
  const navMenu = document.getElementById("nav-menu");
  // When we click on each nav__link, we remove the show-menu class
  navMenu.classList.remove("show-menu");
}
navLink.forEach((n) => n.addEventListener("click", linkAction));

/*======================= ACCORD SKILLS ======================*/

const skillsContent = document.getElementsByClassName("skills__content"),
  skillsHeader = document.querySelectorAll(".skills__header");

function toggleSkills() {
  let itemClass = this.parentNode.className;

  for (i = 0; i < skillsContent.length; i++) {
    skillsContent[i].className = "skills__content skills__close";
  }
  if (itemClass === "skills__content skills__close") {
    this.parentNode.className = "skills__content skills__open";
  }
}

skillsHeader.forEach((el) => {
  el.addEventListener("click", toggleSkills);
});


/*======================= Services Modal ===================*/
// const modalViews = document.querySelectorAll(".services__modal"),
//   modalBtns = document.querySelectorAll(".services__button"),
//   modalCloses = document.querySelectorAll(".services__modal-close");

// let modal = function (modalClick) {
//   modalViews[modalClick].classList.add("active-modal");
// };

// modalBtns.forEach((modalBtn, i) => {
//   modalBtn.addEventListener("click", () => {
//     modal(i);
//   });
// });

// modalCloses.forEach((modalClose) => {
//   modalClose.addEventListener("click", () => {
//     modalViews.forEach((modalView) => {
//       modalView.classList.remove("active-modal");
//     });
//   });
// });








/*======================= Portfolio Swiper ===================*/
var swiper = new Swiper(".portfolio__container", {
  cssMode: true,
  loop: true,

  navigation: {
    nextEl: ".swiper-button-next",
    prevEl: ".swiper-button-prev",
  },
  pagination: {
    el: ".swiper-pagination",
    clickable: true,
  },
});

/*==================== SCROLL SECTIONS ACTIVE LINK ====================*/
const sections = document.querySelectorAll("section[id]");

function scrollActive() {
  const scrollY = window.pageYOffset;

  sections.forEach((current) => {
    const sectionHeight = current.offsetHeight;
    const sectionTop = current.offsetTop - 50;
    sectionId = current.getAttribute("id");

    if (scrollY > sectionTop && scrollY <= sectionTop + sectionHeight) {
      document
        .querySelector(".nav__menu a[href*=" + sectionId + "]")
        .classList.add("active-link");
    } else {
      document
        .querySelector(".nav__menu a[href*=" + sectionId + "]")
        .classList.remove("active-link");
    }
  });
}
window.addEventListener("scroll", scrollActive);

/*==================== CHANGE BACKGROUND HEADER ====================*/
function scrollHeader() {
  const nav = document.getElementById("header");
  // When the scroll is greater than 200 viewport height, add the scroll-header class to the header tag
  if (this.scrollY >= 80) nav.classList.add("scroll-header");
  else nav.classList.remove("scroll-header");
}
window.addEventListener("scroll", scrollHeader);

/*==================== SHOW SCROLL up ====================*/
function scrollUp() {
  const scrollUp = document.getElementById("scroll-up");
  // When the scroll is higher than 560 viewport height, add the show-scroll class to the a tag with the scroll-top class
  if (this.scrollY >= 560) scrollUp.classList.add("show-scroll");
  else scrollUp.classList.remove("show-scroll");
}
window.addEventListener("scroll", scrollUp);

/*==================== DARK LIGHT THEME ====================*/
const themeButton = document.getElementById("theme-button");
const darkTheme = "dark-theme";
const iconTheme = "uil-sun";

// Previously selected topic (if user selected)
const selectedTheme = localStorage.getItem("selected-theme");
const selectedIcon = localStorage.getItem("selected-icon");

// We obtain the current theme that the interface has by validating the dark-theme class
const getCurrentTheme = () =>
  document.body.classList.contains(darkTheme) ? "dark" : "light";
const getCurrentIcon = () =>
  themeButton.classList.contains(iconTheme) ? "uil-moon" : "uil-sun";

// We validate if the user previously chose a topic
if (selectedTheme) {
  // If the validation is fulfilled, we ask what the issue was to know if we activated or deactivated the dark
  document.body.classList[selectedTheme === "dark" ? "add" : "remove"](
    darkTheme,
  );
  themeButton.classList[selectedIcon === "uil-moon" ? "add" : "remove"](
    iconTheme,
  );
}

// Activate / deactivate the theme manually with the button
themeButton.addEventListener("click", () => {
  // Add or remove the dark / icon theme
  document.body.classList.toggle(darkTheme);
  themeButton.classList.toggle(iconTheme);
  // We save the theme and the current icon that the user chose
  localStorage.setItem("selected-theme", getCurrentTheme());
  localStorage.setItem("selected-icon", getCurrentIcon());
});
