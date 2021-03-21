let arr = [];

let para = document.getElementById("para");

function add() {
  let element = document.getElementById("arrayElement");
  arr.push(element.value);
  element.value = "";
}

function display() {
  para.innerHTML = "";
  for (let i = 0; i < arr.length; i++) {
    para.innerHTML += "Element at index "+ i +": " + arr[i] + "<br>";
  }
  para.style.color = "red";
  para.style.border = "2px solid black";
  para.style.fontStyle = "bold";
}