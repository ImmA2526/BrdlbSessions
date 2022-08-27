let names = ["Keshav", "Kanchana", "Sahiba", "Imran", "Aniket", "Pritam", "Soham", "Ritu Raj"];
let cloneNames = [].concat(names);

console.log("Copied Names  " + cloneNames);

let cities = ["Pune", "Mumbai", "Panji"]
//Spread Operator
let spreadData = [...names, ...cities]; /// . accesing the value(Method,Object,Arrray) ... copying data from one to another
for (i = 0; i < spreadData.length; i++) {
    console.log(spreadData[i]);
}

//Spread Operator in Object 
const objectData = { "Name": "Sahiba", "Address": "Mumbai", "Email": "shb@123gmail.com", 100: 112, anotherObject: { "Name": "Afifa", "Address": "Pune", "Email": "afifa121@gmail.com", 100: 114 } };
const cloneObject = { ...objectData };
console.log(cloneObject)
console.log(cloneObject.anotherObject.Email) //Accessing VAlue

//Object Destructuring 
let { Name, Address, ...restProps } = objectData;
console.log("Destruct Data:" + Name, Address, restProps);

// // Function
function welcome() {
    console.log("Welcome To Function World");
    console.log();
}

function arithmaticOperation() {
    welcome();
    var a = 40, b = 20, c;
    console.log(c = a + b);
    console.log(c = a * b);
    console.log(c = a - b);
    console.log(c = a / b);
}

arithmaticOperation();

function displayName(names = []  /*Parameter*/) {
    console.log('Printing the Names');
    for (var i = 0; i < names.length; i++) {
        process.stdout.write(names[i] + "  ");
    }
}

// displayName(...names);

displayName(names /*argument*/); //Parameterised Function

// //Function Expression
// const palindromes = function(string) {
//     const len = string.length;
//     for (let i = 0; i < len / 2; i++) {
//         if (string[i] !== string[len - 1 - i]) {
//             return `${string} : It is not a palindrome`;
//         }
//     }
//     return `${string} : It is a palindrome`;
// }

const isEven = number => number % 2 == 0;
console.log("One Line Arrow Funcion: " + isEven(10));

const palindromes = (string) => {
    const len = string.length;
    for (let i = 0; i < len / 2; i++) {
        if (string[i] !== string[len - 1 - i]) {
            return `${string} : It is not a palindrome`;
        }
    }
    return `${string} : It is a palindrome`;
}

var prompt = require('prompt-sync')();
const palindrome = prompt('Enter a string or number: ');
console.log(palindromes(palindrome));

//Function Inside Function

function nestedFunction() {
    let sampleValue ="This is Main Variable";
    const addition = () => {
        // let sampleValue ="This is Nested Variable";
        var a = 100, b = 20, c = 40;
        var d=a+b+c;
        console.log("Inside the Function "+ sampleValue);
        console.log("Addition of 3 Number " +d);
    }

    const multiplication = function () {
        var a = 4, b = 8, c = 12;
        var d=a*b*c;
        console.log("Multiplication of 3 Number " + d);
    }

    const printingArray = function printing_Array() {
        let names = ["Keshav", "Kanchana", "Sahiba", "Imran", "Aniket", "Pritam", "Soham", "Ritu Raj"];
        return names;
    }

    console.log("Main Function "+ sampleValue);
    addition();
    multiplication();
    console.log("Names Are : " +printingArray());
}

console.log("Calling Main Function");
nestedFunction();

// Q]] Write a Program to check Armstrong Palindrome Even Odd Number Using All
        //All : Switch If For Function 

//Q]] Write Program to Copy object data into Array or Vise versa?