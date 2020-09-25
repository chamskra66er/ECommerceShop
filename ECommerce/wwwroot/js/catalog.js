var inputLeft = document.getElementById("input-left");
var inputRight = document.getElementById("input-right");

var thumbLeft = document.querySelector(".slider > .thumb.left");
var thumbRight = document.querySelector(".slider > .thumb.right");

var range = document.querySelector(".slider > .range");

function setLeftValue() {
    var _this = inputLeft,
        min = parseInt(_this.min),
        max = parseInt(_this.max);

    _this.value = Math.min(parseInt(_this.value), parseInt(inputRight.value) - 1);
    var percent = ((_this.value - min) / (max - min)) * 100;

    thumbLeft.style.left = percent + "%";
    range.style.left = percent + "%";

}
setLeftValue();

function setRightValue() {
    var _this = inputRight,
        min = parseInt(_this.min),
        max = parseInt(_this.max);

    _this.value = Math.max(parseInt(_this.value), parseInt(inputLeft.value) + 1);
    var percent = ((_this.value - min) / (max - min)) * 100;

    thumbRight.style.right = (100 - percent) + "%";
    range.style.right = (100 - percent) + "%";

}
setRightValue();

inputLeft.addEventListener("input", setLeftValue);
inputRight.addEventListener("input", setRightValue);

//var slider = document.getElementById("myRange");
//var output = document.getElementById("demo");
//var outpriceup = document.getElementById("priceup");

//var slider2 = document.getElementById("myRan");
//var outpricedown = document.getElementById("pricedown");


//output.innerHTML = slider.value;

//slider.addEventListener("input", function () {
//    output.innerHTML = this.value;
//    outpriceup.value= this.value;
//})

//slider2.addEventListener("input", function () {
//    output.innerHTML = this.value;
//    outpricedown.value = this.value;
//})



const select = document.querySelector("#myselect");
const options = document.querySelectorAll("#myselect option");

select.addEventListener("change", function () {
    const url = this.options[this.selectedIndex].dataset.url;
    const catId = this.options[this.selectedIndex].value;
    window.location.href = `${window.location.origin}/${url}/${catId}`; 
});




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

