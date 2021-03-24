//////////////Solution 1//////////////////////
let elemSubtotal = document.getElementById("subtotal");
let elemTax = document.getElementById("tax_rate");
let elemSales = document.getElementById("sales_tax");
let elemTotal = document.getElementById("total");

function processEntries() {
  let subtotal = parseFloat(elemSubtotal.value);
  let tax = parseFloat(elemTax.value);

  if ((subtotal <= 0)||(subtotal >= 10000)) {
    alert("Subtotal must be > 0 and < 10000");
    
  } else if ((tax <= 0)||(tax >= 10000)) {
    alert("Tax Rate must be > 0 and < 12");
    
  } else {
    let sales_tax = subtotal * tax / 100;
    let total = subtotal + sales_tax;

    elemSales.value = "$ "+ sales_tax;
    elemTotal.value = "$ "+ total.toFixed(2);
  }

  elemSubtotal.focus();
}

function clearEntries() {
  elemSubtotal.value = "";
  elemTax.value = "";
  elemSales.value = "";
  elemTotal.value = "";

  elemSubtotal.focus();
}


//////////////Solution 2//////////////////////
function styledContent() {
  let qn2a = document.getElementById("qn2a");
  let qn2b = document.getElementById("qn2b");

  qn2a.style.backgroundColor = "red";
  qn2a.style.color = "yellow";
  qn2a.style.fontSize = "32px";
  qn2a.style.fontWeight = "bold";

  qn2b.style.backgroundColor = "white";
  qn2b.style.color = "purple";
  qn2b.style.fontSize = "45px";
  qn2b.style.fontStyle = "italic";
}


//////////////Solution 3//////////////////////
function displayResults() {
  let scores = [15, 70, 16, 90, 35, 45, 52, 63];
  

  scores.splice(2, 0, 60, 85, 74);
  let elemScores = document.getElementById("newScores");
  for (i = 0; i < scores.length; i++) {
    elemScores.innerHTML += scores[i] +"&ensp;";
  }
  

  document.getElementById("scoreResult").innerHTML = "The score 45 is found at location "+ scores.indexOf(45);


  let elemReverse = document.getElementById("reverseScores");
  
  let p = 0, q = scores.length - 1, temp;

  while (p < q) {
    temp = scores[p];
    scores[p] = scores[q];
    scores[q] = temp;
    p++; q--;
  }

  for (i = 0; i < scores.length; i++) {
    elemReverse.innerHTML += scores[i] +"&ensp;";
  }
}


