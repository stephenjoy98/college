/******************************************
Treehouse FSJS Techdegree:
project 1 - A Random Quote Generator
******************************************/

// For assistance: 
  // Check the "Project Resources" section of the project instructions
  // Reach out in your Slack community - https://treehouse-fsjs-102.slack.com/app_redirect?channel=chit-chat


/*** 
 * `quotes` array 
***/
// array of objects
let quotes = [
  {
    "quote"   : "Good design doesn't date.",
    "source"  : "Harry Seidler",
    "citation": "BrainyQuote"
  },
  {
    "quote"   : "By all means let's be open-minded, but not so open-minded that our brains drop out.",
    "source"  : "Richard Dawkins",
    "citation": "BrainyQuote",
    "year"    : "1996"
  },
  {
    "quote"   : "I love deadlines. I like the whooshing sound they make as they fly by.",
    "source"  : "Douglas Adams",
    "citation": "BrainyQuote"
  },
  {
    "quote"   : "Procrastination is the art of keeping up with yesterday.",
    "source"  : "Don Marquis"
  },
  {
    "quote"   : "The greatest glory in living lies not in never falling, but in rising every time we fall.",
    "source"  : "Nelson Mandela",
    "citation": "HubSpot"
  },
  {
    "quote"   : "The journey of a thousand miles begins with one step.",
    "source"  : "Lao Tzu",
    "citation": "KeepInspiring.me"
  },
  {
    "quote"   : "When the going gets tough, the tough get going.",
    "source"  : "Joe Kennedy",
    "year"  : "1963",
  },
  {
    "quote"   : "Wisely, and slow. They stumble that run fast.",
    "source"  : "William Shakespeare",
    "citation": "Wisdom Quotes"
  }
];


/***
 * `getRandomQuote` function
***/
// random number generator
function getRandomQuote() {
  let randomNumber = Math.floor(Math.random() * quotes.length);
  let quoteObject = quotes[randomNumber];

  return quoteObject;
}


/***
 * `printQuote` function
***/

function printQuote() {
  let randomQuote = getRandomQuote();
  let htmlTag = "<p class='quote'>" +randomQuote.quote+ "</p><p class='source'>" +randomQuote.source;

  // checking whether citation exists
  if(randomQuote.citation != undefined) {
    htmlTag += "<span class='citation'>" +randomQuote.citation+ "</span>";
  }
  
  // checking whether year exists
  if (randomQuote.year != undefined) {
    htmlTag += "<span class='year'>" +randomQuote.year+ "</span>";
  }

  // displaying the output
  document.getElementById('quote-box').innerHTML = htmlTag+ "</p>"
}


/***
 * click event listener for the print quote button
 * DO NOT CHANGE THE CODE BELOW!!
***/

document.getElementById('load-quote').addEventListener("click", printQuote, false);