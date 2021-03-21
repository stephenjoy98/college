let para = document.getElementById("para");

let arr = ["purple", 33, 44.5, "car", "apple", 45];
// console.log("The array is: ", arr);

displayArray();

//sorting array
arr.sort();
displayArray();

//reversing array
arr.reverse();
displayArray();

//splicing an array - removing and adding elements
// arr.splice(2,3,"new1",78,"strawberry","music");
// displayArray();

// removing elements
// arr.splice(2,3);
// displayArray();

//add elements
// arr.splice(2,0,"new1",78,"strawberry","music");
// displayArray();

//add elements
// let remAarr = arr.splice(2,3,"new1",78,"strawberry","music");
// displayArray();
// console.log(remArr);

//slice doesn't modify the array
let remArr2 = arr.slice(2,6);
displayArray();
console.log(remArr2);

//push adds element at the end and unshift in the front
arr.push("Guitar");
arr.unshift("basketball");
displayArray();

//pop removes elemnt from the end and shift from front
let element1 = arr.pop();
let element2 = arr.shift();
console.log("The removed element is: ", element1);
console.log("The removed element is: ", element2);
displayArray();



function displayArray() {
  para.innerHTML += "<hr>";
  for (let element of arr) {
    para.innerHTML += element + "<br>";
  }
}

//join operation to concatenates elements to strings
// default separator is comma
// let string = arr.join();
let string = arr.join(" and ");
console.log(string);