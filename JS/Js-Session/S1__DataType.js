console.log("Welcome To JavaScript");

// Variables Var Let and Const
var firstName = "Imran Shaikh";   // Redeclaration
var firstName = "Imran Shaikhs";
console.log(firstName);

firstName = 'Pune Maha';
console.log("Replacing Text: " + firstName);

console.log("Array Data is: " + [11, 22, 33, 44, 55, 66, 77]);
console.log("Access Value is: " + firstName[2]); // accessing values
console.log("Data Type Is:  " + typeof (firstName));

firstName = 100;
console.log("Replacing Text with Number: " + firstName);

console.table({ "Name": `Sahiba`, "Add": `Delhi`, 'Work': `Tutor` })

//Let
// let name = "Sahiba";
// let name = "Shaikh";  // provide block scope

//Const
// const first_Name ="Imran";
// first_Name="Shaikh";     //value cannot be changed

// console.log(first_Name);

//QQ]] Slice() Trim() Replace, Reverse: Perform String Operation on Name = "   Maharashtra   ";

var prompt = require('prompt-sync')();
var enterString=prompt("Enter Any String:  ");
var response = enterString.slice(2,5);
console.log(response);

// Object
let objectData = { "Name": "Imran", "Age": 20, 100: "Dubai", 400:60 };
console.log("Object Data is : ")
console.log(objectData);
console.log(objectData["Imran"]);
console.log(objectData.Age);

// Array
let arrayData = [22, 33, 44, 55, "Kanchana", "Imran", "Sahiba", "Keshav",111.22]
let array = arrayData.shift();
console.log("Shift " + array);
console.log(arrayData)


//QQ]] Perform Operation on Array such as Pop Push Map Filter Find

console.log(arrayData.unshift("Lemon"));
console.log(arrayData);
console.log(arrayData.pop());
console.log("Data" + arrayData.push());
console.log('\n');


console.log("Welcome to Employee Wage Problem");
