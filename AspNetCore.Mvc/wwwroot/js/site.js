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
    searchQuery()
})
function select() {

    try {
        let selected = document.querySelector('.selected')
        let menu = document.querySelector('.menu')
        let selectOptions = document.querySelector('.select-options')
        
        menu.addEventListener('click', function () {
            selectOptions.style.display = (selectOptions.style.display === 'block') ? 'none' : 'block'
        })

        let options = selectOptions.querySelectorAll('.option')
        options.forEach(function (option) {
            option.addEventListener('click', function () {
                selected.innerHTML = this.textContent
                selectOptions.style.display = 'none'
                let category = this.getAttribute('data-value')
                selected.setAttribute('data-value', category)
                updateCoursesByFilters()
         
            })
        })

    } catch { }
}


function searchQuery() {
    try {
        document.querySelector('#searchQuery').addEventListener('keyup', function () {
            const value = this.value
            updateCoursesByFilters(value)
        })
    } catch {

    }
}

function updateCoursesByFilters() {
    const category = document.querySelector('.selected').getAttribute('data-value') || 'all'
    const searchQuery = document.querySelector('#searchQuery').value

    const url = `/course/index?category=${encodeURIComponent(category)}&searchQuery=${encodeURIComponent(searchQuery)}`
    fetch(url)
        .then(res => res.text())
        .then(data => {
            const parser = new DOMParser()
            const dom = parser.parseFromString(data, 'text/html')
            document.querySelector('.course-card').innerHTML = dom.querySelector('.course-card').innerHTML
        })
}
