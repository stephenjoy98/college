// alertRandom();

function alertRandom() {
  const randomNumber = Math.floor(Math.random() * 6) + 1;
  alert(randomNumber);
}

// isFieldEmpty()

function isFieldEmpty() {
  const field = document.querySelector("#empty");
  if (field.value === "") {
    alert(true);
  } else {
    alert(false);
  }
}

// experiment();

function experiment() {
  const title = "The Long Walk in the Woods";

  console.log(title.length);
  console.log(title[0] + title[2] + title[title.length - 1]);
  console.log();

}


// area(2,3,"meter");

function area(l, b, unit) {
  let area = l * b;
  console.log(area+ " " +unit);
}

console.log(largerNumber(3,2));

function largerNumber(n1, n2) {
  if (n1 > n2) {
    return n1;
  } else {
    return n2;
  }
}