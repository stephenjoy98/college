let button = document.getElementById("button");

//FIRST METHOD

//Using named dunction
button.onclick = buttonClick;


function buttonClick() {
    document.body.style.backgroundColor = "lightgreen";
}

//using an anonymous function
button.onclick = function () {
    console.log("I am clicked")
}

//SECOND METHOD
button.addEventListener("click", buttonClick);
//The second parameter is callback
button.addEventListener("click", function (event) {
    console.log("I am clicked again");
    console.log(event);
    console.log(event.target);
    console.log(event.target.id);
    console.log(event.target.className);
    console.log(event.clientX, event.clientY);
    console.log(event.offsetX, event.offsetY);

});

