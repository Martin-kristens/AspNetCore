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
            console.log('inne 3')
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
})
function select() {
    try {
        let select = document.querySelector('.select')
        let selected = select.querySelector('.select-options')
        let selectOptions = select.querySelector('.user-option')

        selected.addEventListener('click', function () {
            selectOptions.style.display = (selectOptions.style.display === 'block') ? 'none' : 'block'
        })

        let options = selectOptions.querySelectorAll('.option')
        options.forEach(function (option) {
            option.addEventListener('click', function () {
                selected.innerHTML = this.textContent
                selectOptions.style.display = 'none'
                updateCourseByFilter()
            })
        })

    } catch {}
}


function updateCourseByFilter() {

    const category = document.querySelector('.select .select - options').getAttribute('data-value') || 'all'
    const url = `/courses/index?category=${encodeURIComponent(category)}`

    fetch(url)
        .then(res => res.text())
        .then(data => {
            const parser = new DOMParser()
            const dom = parser.parseFromString(data, 'text/html')
            document.querySelector('.items').innerHTML = dom.querySelector('.items').innerHTML
        })
}