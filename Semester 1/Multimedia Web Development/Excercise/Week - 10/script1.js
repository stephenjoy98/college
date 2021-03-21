function myFunc() {
    let element = document.getElementById("para");
    console.log(element);
    //element.innerHTML = "Have a Good Day!"
    element.outerHTML = "<h3>Have  a Good Day!</h3>"

}