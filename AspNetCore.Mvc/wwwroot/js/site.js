const mobileMenu = document.getElementById('mobile-menu');
document.getElementById('account-buttons').classList.toggle('hide');

const toggleMenu = () => {
    console.log("inne");
    mobileMenu.style.display = mobileMenu.style.display === "none" ? "flex" : "none";
    console.log(mobileMenu.style);
    //document.getElementById('menu').classList.toggle('hide');
    //document.getElementById('account-buttons').classList.toggle('hide');
}

const checkScreenSize = () => {
    console.log("1");
    if (window.innerWidth >= 1200) {
        document.getElementById('menu').classList.remove('hide');
        document.getElementById('account-buttons').classList.remove('hide');
    } else {
        if (!document.getElementById('menu').classList.contains('hide')) {
            document.getElementById('menu').classList.add('hide');
        }
        if (!document.getElementById('account-buttons').classList.contains('hide')) {
            document.getElementById('account-buttons').classList.add('hide');
        }
    }
};

window.addEventListener('resize', checkScreenSize);
checkScreenSize();