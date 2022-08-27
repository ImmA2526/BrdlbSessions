//Callback
let names = ["Keshav", "Kanchana", "Sahiba", "Imran", "Aniket", "Pritam", "Soham", "Ritu Raj"];

const displayName = (names,dispalyWorldCity  /*Parameter*/) => {
    console.log('Printing the Names');
    for (var i = 0; i < names.length; i++) {
        process.stdout.write(names[i] + "  ");
    }
    dispalyWorldCity();  //diffrent argument 
}
// displayName(names, displayCities);  Not Possible Hoisting

let city = ["Goa", "Mumbai", "Dubai", "Uk", "Briglab"];

const displayCities = () => {
    console.log("\nPrinting Cities: ");
    for (var i = 0; i < city.length; i++) {
        process.stdout.write(city[i] + "  ");
    }
}

displayName(names,displayCities /*Argument*/);  //Callback

const functionReturns = functionReturnFunction(); //Hoisting
console.log(functionReturns);
// console.log(functionReturnFunction());

// //Function Return Function Closure
function functionReturnFunction() {
    function addition() {
        var a = 100, b = 20, c = 40;
        var d = a + b + c;
        return d;
    }
    return addition();
}

// //Parameters 

function multiplication(no1, no2 = 6, ...no6 /*Defult Value no2*/) {
    no4 = no1 * no2;

    console.log();
    console.log("value of No1 "+ no1 + "\n value of Number 2 "+no2);
    console.log(`Rest Para Value: ${no6}`)
    return no4;
}
// QQ]] How to calculate rest parameter?

const multiplications = multiplication(2, 22, 33, 44, 55, 66);
console.log(multiplications);

// //Param Destructurig
const personNames =
    { firstName: "Imran", gender: "M", age: "100", }

function printDetails({firstName,gender,age}){
    console.log(firstName);
    console.log(gender);
    console.log(age); 
}

printDetails(personNames);
