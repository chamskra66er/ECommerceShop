var modal = document.getElementById('myModal');
var btn = document.getElementById('myBtn');
var span = document.getElementsByClassName("closeModal")[0];

btn.addEventListener("click", function () {
	modal.style.display = "block";
});

span.addEventListener("click", function () {
	modal.style.display = "none";
});

window.addEventListener("click", function (e) {
	if (e.target == modal) {
		modal.style.display = "none";
	}
});

//function myFunction() {
//    document.getElementById("myDropdown").classList.toggle("show");
//}

//// Close the dropdown if the user clicks outside of it
//window.onclick = function (event) {
//    if (!event.target.matches('.dropbtnClick')) {

//        var dropdowns = document.getElementsByClassName("dropClick-content");
//        var i;
//        for (i = 0; i < dropdowns.length; i++) {
//            var openDropdown = dropdowns[i];
//            if (openDropdown.classList.contains('show')) {
//                openDropdown.classList.remove('show');
//            }
//        }
//    }
//}

////functions for shoing subCatalogs
//function showTv() {
//    console.log("mouse");
//}
