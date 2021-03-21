let arr = [4,6,8,1,3,9,5,2];

let para = document.getElementById("para");
let para1 = document.getElementById("para1");
let para2 = document.getElementById("para2");
let para3 = document.getElementById("para3");
let para4 = document.getElementById("para4");

// array
para.innerHTML = "The array is "+ arr;


// sum
let sum = 0;

for (let i of arr) {
  sum += i;
}

para1.innerHTML = "The sum of the array is "+ sum;


// average
let avg = sum / arr.length;
para2.innerHTML = "The avg of the array is "+ avg;

// min and max
arr.sort();
para3.innerHTML = "The min of the array is "+ arr[0];
para4.innerHTML = "The max of the array is "+ arr[arr.length - 1];