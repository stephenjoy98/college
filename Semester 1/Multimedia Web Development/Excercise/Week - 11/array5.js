let movies = ["Avatar", "Aliens", "Avengers", "Annihilation", "Titanic", "Lord of the Rings", "Harry Potter", "Birds of Prey"];

let display = document.getElementById("mMovies");

let min = 0, max = movies.length;

function displayMovies() {
  let random1 = random2 = random3 = 0;
  
  do{
    random1 = Math.floor(Math.random() * max);
    random2 = Math.floor(Math.random() * max);
    random3 = Math.floor(Math.random() * max);
  } while (random1 == random2 || random1 == random3 ||random2 == random3)
  
  // console.log(random1, random2, random3);
  
  display.innerHTML = movies[random1] + "<br>" + movies[random2] + "<br>" + movies[random3];
}

function resetList() {
  display.innerHTML = "";
}

function addMovie() {
  let newMovie = document.getElementById("myMovie");

  if(newMovie.value != "") {
    movies.push(newMovie.value);
    newMovie.value = "";
  }

  display.innerHTML = "";
  
  for (let value of movies) {
    display.innerHTML += value + "<br>";
  }
}