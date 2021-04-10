
// storing the name and price of the product in a 2 dimensional array
let cpu = [
  ["AMD Ryzen 7 3700X", 319.99],
  ["Intel Core i7-10700K", 319.60],
  ["AMD Ryzen 7 5800X", 449.00]];
let mb = [
  ["MSI B450 TOMAHAWK MAX", 114.99],
  ["Asus TUF GAMING X570-PLUS (WI-FI)", 192.99],
  ["Asus ROG STRIX B550-F GAMING (WI-FI)", 202.92]];
let gpu = [
  ["NVIDIA GEFORCE RTX 3080", 699.99],
  ["NVIDIA GEFORCE RTX 3070", 499.00],
  ["NVIDIA GEFORCE RTX 3060 TI", 399.99]];
let ram = [
  ["Corsair Vengeance LPX 16 GB", 89.99],
  ["Corsair Vengeance RGB Pro 16 GB", 115.99],
  ["Crucial Ballistix 16 GB", 87.99]];
let ssd = [
  ["Samsung 970 Evo 1TB", 144.99],
  ["Western Digital Blue SN550 1 TB", 104.99],
  ["Samsung 980 Pro 1TB", 179.99]];
let psu = [
  ["Corsair RM 750W", 124.99],
  ["EVGA BQ 600W", 69.44],
  ["Corsair CXM 650W", 84.99]];
let cabinet = [
  ["NZXT H510", 69.98],
  ["Corsair 4000D Airflow", 94.99],
  ["Fractal Design Meshify C", 99.98]];

// checking the price of the selected element and printing it
function checkCPU(e) {
  let selected = e.value;

  for (value of cpu) {
    if (value[0] == selected) {
      document.getElementById("row-cpu").lastElementChild.innerHTML = "$"+ value[1].toFixed(2);
    }
  }
}

function checkMB(e) {
  let selected = e.value;

  for (value of mb) {
    if (value[0] == selected) {
      document.getElementById("row-motherboard").lastElementChild.innerHTML = "$"+ value[1].toFixed(2);
    }
  }
}

function checkGPU(e) {
  let selected = e.value;

  for (value of gpu) {
    if (value[0] == selected) {
      document.getElementById("row-gpu").lastElementChild.innerHTML = "$"+ value[1].toFixed(2);
    }
  }
}

function checkRAM(e) {
  let selected = e.value;

  for (value of ram) {
    if (value[0] == selected) {
      document.getElementById("row-ram").lastElementChild.innerHTML = "$"+ value[1].toFixed(2);
    }
  }
}

function checkSSD(e) {
  let selected = e.value;

  for (value of ssd) {
    if (value[0] == selected) {
      document.getElementById("row-ssd").lastElementChild.innerHTML = "$"+ value[1].toFixed(2);
    }
  }
}

function checkPSU(e) {
  let selected = e.value;

  for (value of psu) {
    if (value[0] == selected) {
      document.getElementById("row-psu").lastElementChild.innerHTML = "$"+ value[1].toFixed(2);
    }
  }
}

function checkCase(e) {
  let selected = e.value;

  for (value of cabinet) {
    if (value[0] == selected) {
      document.getElementById("row-case").lastElementChild.innerHTML = "$"+ value[1].toFixed(2);
    }
  }
}

// calculating the total of all the selected elements
function calcTotal() {
  let tr = document.getElementsByTagName("tr");
  let total = value = 0;

  for (let i = 1; i < tr.length - 1; i++) {
    value = (tr[i].lastElementChild.innerHTML).replace("$","");
    total += parseFloat(value);
  }

  document.getElementById("total").lastElementChild.innerHTML = "$"+ total.toFixed(2);
}

// used to reset the form
function resetPrices() {
  let tr = document.getElementsByTagName("tr");

  for (let i = 1; i < tr.length; i++) {
    tr[i].lastElementChild.innerHTML = "";
  }
}