function generateEmail(form) {
    console.log("I am inside function");
    //form argument returns form object
    console.log(form);
    //length returns th elength
    console.log(form.length);

    /* let form1 = document.getElementsByTagName("form");
    console.log(form1[0]); */
    //form object has an elements property that holds the controls

    //These statements return the text box control with id="fname"
    console.log(form.elements["fname"]);
    console.log(form["fname"]);
    console.log(form[0]);

    //Returning the value
    console.log(form[0].value);

    let email = form[0].value + "." + form["lname"].value + "@douglascollege.ca";
    document.getElementById("para").innerHTML += email;
    form.reset();
    form["fname"].focus();

}