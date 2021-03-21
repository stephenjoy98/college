let arr = [10, 34.6, "red"];
let para = document.getElementById("para");

console.log("The array is: ", arr);
console.log("The array has length: ", arr.length);

for (let i = 0; i < arr.length; i++) {
  para.innerHTML += arr[i] + "<br>";
}

//for-of loop - iterates through the values
for (let i of arr) {
  para.innerHTML += i + "<br>";
}

for (let i in arr) {
  para.innerHTML += arr[i] + "<br>";
}

let arr2 = [];
console.log("The array is: ", arr2);

//Another way to create an array in JS
let arr3 = new Array();
console.log("The array is : ", arr3);

let arr4 = ["apple", "orange"];
let arr5 = new Array("apple", "orange");

console.log("The array is: ", arr4);
console.log("The array is: ", arr5);

//Note the differences in the following two arrays: