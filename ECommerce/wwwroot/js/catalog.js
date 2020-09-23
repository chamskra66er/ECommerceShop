var select = document.getElementById('myselect');
const options = document.querySelectorAll("#myselect option");

function setSelect() {
    var dataToSend = {
        Type: this.options[this.selectedIndex].value,
    };
    var jsonData = JSON.stringify(dataToSend);
    $.ajax({
        url: "/Home/SortAlphabet",
        type: "POST",
        data: { jsonData },
        contentType: "application/json; charset=utf-8",
    }).done(function (url) {
        window.location.href = url.redirectTo;
    });
}

select.addEventListener('change', setSelect);

//const select = document.querySelector("#myselect");
//const options = document.querySelectorAll("#myselect option");

//select.addEventListener("change", function () {
//    window.location.href = "@Url.Action("SortAlphabet","Controller")";

//    const url = this.options[this.selectedIndex].dataset.url;
//    const url = this.options[this.selectedIndex].value;
//    if (url) {
//        window.location.href = url;
//});



//var ctl1 = document.getElementById('ctl1');
//var ctl2 = document.getElementById('ctl2');


//function setStyle() {
//    ctl2.setAttribute("style", "color:red");
//}
//function remStyle() {
//    ctl2.setAttribute("style", "color:black");    
//}

//ctl1.addEventListener("mouseover", setStyle);
//window.addEventListener("mouseup", remStyle);

//function myFunction() {
//    ctl2.setAttribute("style", "color:black"); 
//}


//var element = document.getElementById('showTv');
//var header = document.querySelector("header");

//let elem = document.createElement('div');
//elem.className = "catalog-content";
//elem.innerHTML = "<div><strong>Телевизоры!</strong> Вы прочитали важное сообщение.</div>";

//var remElement = document.querySelectorAll("div.catalog-content div");


//function createElements() {
//    header.appendChild(elem);    
//}

//function deleteElements() {
//    alert("mouse");
//    header.removeChild(remElement);
//}

//element.addEventListener("mouseover", createElements);
//element.addEventListener("mouseleave", deleteElements);

