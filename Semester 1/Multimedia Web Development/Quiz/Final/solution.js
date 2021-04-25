//Question 1
function checkName() {
  if(document.getElementById("fname").value == "")
    alert("First Name cannot be empty");
  if(document.getElementById("lname").value == "")
    alert("Last Name cannot be empty");
}

function calculateRent() {
  checkName();

  let category = document.querySelector('input[name="utility"]:checked');

  if(category == null) {
    alert("Select a category");
    return;
  }

  let checkboxes = document.querySelectorAll("input[name='options']");
  let options = [];

  for (let i = 0; i < checkboxes.length; i++) {
    if (checkboxes[i].checked) {
      options.push(checkboxes[i].value);
    }
  }

  console.log(checkboxes[0].value);
  
  
  let result = document.getElementById("rentaldetails");
  result.innerHTML = "Thank you "+ document.getElementById("fname").value +" "+ document.getElementById("lname").value +" for choosing us. <br> Your Rental Details are: <br> Category is: "+ category.id +"<br> Options selected are: ";
  
  for (let value of options)
    result.innerHTML += value + "<br>";
}




//Question 2
function addItems() {
  let item = document.getElementById("item");
  let arr = [];
  arr.push(item.value);
  item.value = "";
  
  let select = document.getElementById("selectedItems");

  for (let value of arr) {
    var option = document.createElement("option");
    option.text = value;
    select.add(option);
  }
}

function deleteItems() {
  let items = document.getElementsByTagName("selectedItems").value;
  
}

function showAmount() {
  let value = parseInt(document.getElementById("minutes").value);

  document.getElementById("amount").value = value * arr.length;
}




//Question 3

