var modal = document.getElementById('myModal');
var btn = document.getElementById('myBtn');
var span = document.getElementsByClassName("closeModal")[0];
var btnLog = document.getElementById('btnLogin');

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

btnLog.addEventListener("click", function () {
	const url = ('Identity/Account/Login').dataset.url;
	location.href = url
});