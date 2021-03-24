// Methods of String Class
let str = "Thsi is a string";
console.log(str);

// Using length property
console.log("The length is:", str.length);
let str1 = 'Today\'s Forecast';
console.log(str1);

// fromCharCode
str1 = "Copyright symbol &copy";
console.log(str1);
console.log("The Copyright symbol is", String.fromCharCode(169));

// use of toLowerCase and toUpperCase
str1 = "Hello";
console.log(str1.toLowerCase());
console.log(str1.toUpperCase());
console.log(str1);

// Search and Extraction Methods
let email = "smith@example.com";
console.log("Use of charAt() method", email.charAt(5));
console.log("Use of charCodeAt() method", email.charCodeAt(5));
console.log("Use of indexOf() method", email.indexOf("et"));
console.log("Use of indexOf() method", email.indexOf("e", 7));  //starts search from 7th position
console.log("Use of lastIndexOf() method", email.lastIndexOf("e", 7));  //ends search at 7th position

// use of match() - used mainly with regex
console.log("Use of match() method", email.match("e"));
console.log("Use of searc() method", email.search("e"));

// split method
console.log(email.split());