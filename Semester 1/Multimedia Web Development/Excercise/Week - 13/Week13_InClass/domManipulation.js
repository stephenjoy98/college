//DOM Manipulation
let taskList = document.getElementById("tasks");
console.log("The task list", taskList);

console.log("The parent of tasklist", taskList.parentElement);
console.log("The parent of tasklist", taskList.parentNode);

console.log("The parent node of document.body", document.body.parentNode);
console.log("The parent Element of document.body", document.body.parentElement);

console.log("The parent node of document.documentElement", document.documentElement.parentNode);
console.log("The parent element of document.documentElement", document.documentElement.parentElement);

taskList.parentNode.style.backgroundColor = "lightgrey";

//Children
console.log("The children nodes", taskList.childNodes);
console.log("The children nodes", taskList.childNodes.length);

console.log("The children Elements", taskList.children);
console.log("The children Elements", taskList.children.length);
console.log("The children Elements", taskList.childElementCount);
//firstChild, lastChild, firstElementChild, lastElementChild, nextSibling, previousSibling, nextElementSibling, previousElementSibling

taskList.previousElementSibling.style.color = "blue";
taskList.lastElementChild.textContent = " I am the last one";

//Creating new Elements and Text Nodes

//Create a div
let newDiv = document.createElement("div");


//Add ID
newDiv.id = "newDivID";

//Add class
newDiv.className = "newDivClass"

console.log(newDiv);

//Add atribute
newDiv.setAttribute('title', 'New Division');

//Create a text node
let newTextNode = document.createTextNode("I am a new text node");
console.log(newTextNode);

//Add text Node to Div
newDiv.appendChild(newTextNode);

//Add div to DOM

let mainDiv = document.getElementById("main");
//mainDiv.appendChild(newDiv);
mainDiv.insertBefore(newDiv, taskList);

let newHeading = document.createElement("h1");
newHeading.innerHTML = "<span>I am also a new Element</span>";
document.body.appendChild(newHeading);
