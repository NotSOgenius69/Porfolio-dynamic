
/*homepic animate*/
document.getElementById('pic').addEventListener('mouseover', () => {
    var shape = document.getElementById('triangle');
    shape.style.transform = 'translate(20px,-20px)';
});
document.getElementById('pic').addEventListener('mouseout', () => {
    var shape = document.getElementById('triangle');
    shape.style.transform = 'translate(0,0)';
});
/*homepic animate*/

/*aboutpic animate*/
document.querySelector('.aboutpic').addEventListener('mouseover', () => {
    document.querySelector('.aboutpic').style.transform = 'scale(1.1)';
});
document.querySelector('.aboutpic').addEventListener('mouseout', () => {
    document.querySelector('.aboutpic').style.transform = 'scale(1)';
});
/*aboutpic animate*/

/*skills card*/
document.querySelectorAll('.card').forEach(card => {
    card.addEventListener('mouseover', () => {
        card.style.transform = 'scale(1.1)';
    });
    card.addEventListener('mouseout', () => {
        card.style.transform = 'scale(1)';
    });

});
/*skills card*/

/*hamicon toggle*/
const menuicon = document.getElementById('menuicon');
const navbar = document.querySelector('.navbar');
menuicon.onclick = function () {
    navbar.classList.toggle('clicked');
    const isOpen = navbar.classList.contains('clicked');

    menuicon.classList = isOpen ? 'fa-solid fa-xmark' : 'fa-solid fa-bars';
}
/*hamicon toggle*/

/*slider animation*/
let prev = document.getElementById('prev');
let next = document.getElementById('next');
let slider = document.querySelector('.slider');
next.onclick = () => {
    let slides = document.querySelectorAll('.slides');
    slider.appendChild(slides[0]);
};
prev.onclick = () => {
    let slides = document.querySelectorAll('.slides');
    slider.prepend(slides[slides.length - 1]);
};
/* slider animation*/

/*menu item acitve toggle*/
let sections = document.querySelectorAll('section');
let navLinks = document.querySelectorAll('header nav a');

window.onscroll = () => {
    sections.forEach(sec => {
        let top = window.scrollY;
        let offtop = sec.offsetTop - 150;
        let height = sec.offsetHeight;
        let secid = sec.getAttribute('id');

        if (offtop <= top && top < offtop + height) {
            navLinks.forEach(link => {
                link.classList.remove('selected');
                if (link.href.includes(secid)) {
                    link.classList.add('selected');
                }
            })
        }


    })
}
/*menu item acitve toggle*/

/*scroll reveal*/
ScrollReveal({
    distance: '80px',
    duration: 1000,
    delay: 100,
});

ScrollReveal().reveal('.textContent, .aboutpic, .messagebox', { origin: 'left' });
ScrollReveal().reveal('.socialmedia, .eduContents, .slider, .contactdetails, .skillsSection .card', { origin: 'right' });
ScrollReveal().reveal('.skillsSection .card', { duration: 500 });
ScrollReveal().reveal('.aboutContent h1, .edutitle h2, .skillsSection h1, .myworksSection h1, .contactTitle', { origin: 'top' });
ScrollReveal().reveal('.professions, .aboutContent p, .myworksSection buttons, footer h3', { origin: 'bottom' });