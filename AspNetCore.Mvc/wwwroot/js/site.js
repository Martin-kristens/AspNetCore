//const mobileMenu = document.getElementById('mobile-menu');
//document.getElementById('account-buttons').classList.toggle('hide');

//const toggleMenu = () => {
//    mobileMenu.style.display = mobileMenu.style.display === "none" ? "flex" : "none";
//    //document.getElementById('menu').classList.toggle('hide');
//    //document.getElementById('account-buttons').classList.toggle('hide');
//}

//const checkScreenSize = () => {
//    if (window.innerWidth >= 1200) {
//        document.getElementById('menu').classList.remove('hide');
//        document.getElementById('account-buttons').classList.remove('hide');
//    } else {
//        if (!document.getElementById('menu').classList.contains('hide')) {
//            document.getElementById('menu').classList.add('hide');
//        }
//        if (!document.getElementById('account-buttons').classList.contains('hide')) {
//            document.getElementById('account-buttons').classList.add('hide');
//        }
//    }
//};

//window.addEventListener('resize', checkScreenSize);
//checkScreenSize();


document.addEventListener('DOMContentLoaded', function () {

    handleProfileImageUpload()
    console.log('inne')

})

function handleProfileImageUpload() {
    try {
        let fileUploader = document.getElementById('uploadFile')
        console.log('inside handleProfileImageUpload')
        if (fileUploader != undefined) {
            fileUploader.addEventListener('change', function () {
                if (this.files.length > 0) 
                    this.form.submit()
            })
        }
    }
    catch {

    }
}

document.addEventListener('DOMContentLoaded', function () {
    select()
    console.log("hej")
})
function select() {
    console.log("select")
    try {
        console.log(1)
        let selected = document.querySelector('.selected')
        console.log(2)
        let menu = document.querySelector('.menu')
        console.log(3)
        let selectOptions = document.querySelector('.select-options')
        console.log(4)
        
        menu.addEventListener('click', function () {
            selectOptions.style.display = (selectOptions.style.display === 'block') ? 'none' : 'block'
            console.log(5)
        })
        console.log(6)
        let options = selectOptions.querySelectorAll('.option')
        options.forEach(function (option) {
            console.log(7)
            option.addEventListener('click', function () {
                console.log(8)
                selected.innerHTML = this.textContent
                console.log(9)
                selectOptions.style.display = 'none'
                console.log(10)
                updateCourseByFilter()
                console.log(11)
         
            })
        })

    } catch { console.log("catch") }
}


function updateCourseByFilter() {
    console.log(12)
    const category = document.querySelector('.selected').innerHTML || 'all'
    console.log(22)
    
    const url = `/course/index?category=${encodeURIComponent(category)}`
    console.log(23)
    fetch(url)
    console.log(24)
        .then(res => res.text())
        .then(data => {
            const parser = new DOMParser()
            const dom = parser.parseFromString(data, 'text/html')
            document.querySelector('.course-card').innerHTML = dom.querySelector('.course-card').innerHTML
        })
}
