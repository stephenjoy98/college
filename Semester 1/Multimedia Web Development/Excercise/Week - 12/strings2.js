let email = "smith@example.com";

console.log("use of slice()", email.slice(2));
console.log("use of slice()", email.slice(2, 4));
console.log("use of slice()", email.slice(-4, -1));

console.log("use of substring()", email.substring(2));
console.log("use of substring()", email.substring(2, 4));
console.log("use of substring()", email.substring(4, 2));
console.log("use of substring()", email.substring(-4, -1));

console.log("use of substr()", email.substr(4, 5));
console.log(Number.isInteger(23.4));