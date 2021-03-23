//////////////////////Solution 1//////////////////////
function tipCalculator() {
  let amount = document.getElementById("amount");

  if (amount)
    document.getElementById("result").innerHTML = "Tip on &#36;"+ amount.value +" is: &#36;"+ Math.round(amount.value * 0.2 * 100) / 100;
}


//////////////////////Solution 2//////////////////////
function changeColor(color) {
  if (color == "lightYellow")
    document.body.style.backgroundColor = "lightyellow";
  else if (color == "lightGreen")
    document.body.style.backgroundColor = "lightgreen";
}


//////////////////////Solution 3//////////////////////
function convertTemperature() {
  let tempF = prompt("Enter temperature in Farenheit: ");

  if(tempF)
    alert("The temperature in Farenheit is:  "+ tempF +"\u00B0F \nThe temperature in Celsius is:  "+ Math.round(((tempF - 32) * 5 / 9) * 10) / 10 +"\u00B0C");
}


//////////////////////Solution 4//////////////////////
let arr = [];

function addElement() {
  let element = document.getElementById("arrayElement");
  
  if (element.value)
    arr.push(element.value);

  element.value = "";
}

function displayArray() {
  /* ----------Result 4a---------- */
  let element1 = document.getElementById("result4a"), i = 0;

  element1.innerHTML = "The Array is: [ ";

  for (let value of arr) {
      
    element1.innerHTML += value;
    
    if (i < arr.length - 1)
    element1.innerHTML += ", ";
    
    if (i == arr.length - 1)
      element1.innerHTML += " ]";

    i++;
  }

  /* ----------Result 4b---------- */
  let element2 = document.getElementById("result4b")
  let cmfe = 0, mfe;          // count of most frequent element

  for (i = 0; i < arr.length; i++) {
    let counter = 0;

    for (j = i; j < arr.length; j++) {
      if (arr[i] == arr[j]) {
        counter++;
        if (cmfe < counter) {
          cmfe = counter;
          mfe = arr[i];
        }
      }
    }
  }

  element2.innerHTML = "The element "+ mfe + " appears " + cmfe +" times.";
}


//////////////////////Solution 6//////////////////////
function displayNews() {  
  let arr = ["COVID-19 case confirmed at Warman Community School", "Coronavirus: Hamilton reported 74 new COVID - 19 cases on the weekend, 5 deaths", "Montreal volunteers give out meals and care packages to the homeless community", "JLake Louise RCMP issuing $1,000 fines for breaking COVID-19 rules", "Alberta premier and Enbridge respond to Michigan seeking shut down of Line 5 pipeline"];
  let elemIndex = document.getElementsByName("headline")[0].selectedIndex;
  let textarea = document.getElementById("news");
  
  textarea.innerHTML = "&emsp;&emsp; Some news about "+ arr[elemIndex];
}


//////////////////////Solution 7//////////////////////
function checkValue(e) {
  if ((e.value > 99)||(e.value < -99))
    e.style.borderColor = "red";
  else
    e.style.borderColor = "darkgray";
}

function calculateRoots() {
  let soln = document.getElementById("soln"),
      a = parseInt(document.getElementById("a").value),
      b = parseInt(document.getElementById("b").value),
      c = parseInt(document.getElementById("c").value),
      x1 = x2 = 0;
      
    soln.innerHTML = "";

  if ((a < 99)&&(a > -99)&&(a != 0)&&(b < 99)&&(b > -99)&&(c < 99)&&(c > -99)) {
    let p = b * b;
    let q = 4 * a * c;

    if (p < q) {
      soln.innerHTML = "Solution: x’s roots are imaginary";
      
    } else if (p == q) {
      x1 = - b / (2 * a);
      
      soln.innerHTML = "Solution: x = "+ Math.round(x1 * 1e3) / 1e3;
      
    } else {
      x1 = (- b + Math.sqrt((p) - q)) / (2 * a);
      x2 = (- b - Math.sqrt((p) - q)) / (2 * a);

      soln.innerHTML = "Solution: x = "+ Math.round(x1 * 1e3) / 1e3 +", x = "+ Math.round(x2 * 1e3) / 1e3;

    }

  } else {
    
    if ((a > 99)||(a < -99))
      soln.innerHTML += "'a' should be between -99 and +99 <br>";

    if (a == 0)
      soln.innerHTML += "'a' should be a non-zero number <br>";

    if ((b > 99)||(b < -99))
      soln.innerHTML += "'b' should be between -99 and +99 <br>";
      
    if ((c > 99)||(c < -99))
      soln.innerHTML += "'c' should be between -99 and +99 <br>";
  }
}