// IF Statement >>> If...If

var prompt = require('prompt-sync')();
var enterString = prompt("Enter Any String:  ");

if (enterString >= 80)
    console.log("Congrats!  You Pass the Exam");
else if (enterString >= 60)
    console.log("Good! You Are Eligible For Commerce");
else if (enterString >= 50)
    console.log("All The Best");
else if (enterString < 35)
    console.log("Failed");
else
    console.log("Sorry! \tTry Next Time");

// Nested If 

var prompt = require('prompt-sync')();
var number = prompt("Enter Any Number:  ");
if (number == 42) {
    if (number < 40)
        console.log("Less");
    else
        console.log("Big");
} else {
    if (number == 52)
        console.log("Value is Eqaul");
    else
        console.log("Value is NotEqual");
}

//Switch Case 

var prompt = require('prompt-sync')();
var weekNo = Number(prompt("Enter Any Number:  "));

switch (weekNo) {
    case 1:
        console.log("Monday");
        break;
    case 2:
        console.log("Tuesday");
        break;
    case 3:
        console.log("Wednsday");
        break;
    case 4:
        console.log("Thursday");
        break;
    case 5:
        console.log("Friday");
        break;
    case 6:
        console.log("Saturday");
        break;
    case 7:
        console.log("Sunday");
        break;
    default:
        console.log("Enter Valid Number");
        break;
}

//Nested Switch 

var prompt = require('prompt-sync')();
var alpha = prompt("Enter Character :  ");
switch (alpha) {
    case 'a':    // Grouped Statemnet of Switch Case 
    case 'e':
    case 'o':
    case 'u':
    case 'i':
        console.log("Vowel");
        break;
    case 'A':
        console.log("**********You Are in Capital Alphabate :-- \n Enter Capital Character:  ******* \t");
        var cap = prompt("Enter Character :  ");
        switch (cap) //Nested Case
        {
            case 'A':
            case 'E':
            case 'O':
            case 'U':
            case 'I':
                console.log(`${cap} is Vowel`);
                break;
            default:
                console.log(`${cap} Not Vowel`);
                break;
        }
        break;
    default:
        console.log("Not Vowel");
        break;
}

// Q) Write Program to check number is Prime Armstrong or Even Odd using Switch Case.
// Q] Check Fibonaccie Series and Palindrome number 

//Ternary Opeartor
var number1 = 20;
console.log(number1 == 200 ? "True" : "False");

// Iteration Statement : While For Do 
// break, continue, Goto;

// While Loop
let i = 1;
var prompt = require('prompt-sync')();
var number = prompt("Enter Number: ");
while (i <= 10) {

    if (i == 4)
        break;    //1,2,3,4...break;
    console.log(`${number} X ${i} = ` + number * i);

}

// Do While 
do {
    console.log("\nInside the Do Loop");
    console.log(`${number} X ${i} = ` + number * i);
    i++;
} while (i < 0);


// Q]] Print 1 to 100 Natural Number Using While Loop and Do While Loop?


var name = ["Amit", "Kanchan", "Sahiba", "Sayali", "Prakash", "Imran", "Abhilasha", "Aniket", "Arnav", "Ganesh"];

console.log("Names Are:  ");
for (let i = 0; i < name.length; i++)
    process.stdout.write(name[i] + " ");

// Nested For Lopp    
1
12
123

let string = "";
for (let a = 1; a <= 7; a++) {           //check 1st for loop >> true >> next for loop >> once false >> first for loop
    for (let b = 1; b <= a; b++) {
        string += b;
    }
    string += "\n";
}
console.log(string + " ");

// // For Of
const cars = ["BMW", "Volvo", "Mini"];
let text = "";
for (let x of cars) {
    console.log(text += x + " ");  //of
    //console.log(text += cars[x] + " ");   //in
}


// QQ]] Print * Pyramid using for loop?    Accept user Value??  Used : if , Switch,  while(true)
//   *
//  * *
// * * *
// QQ]] Reverse the Pattern?
// * * *
//  * *
//   *

//QQ]] Combination of Both?
//   *
//  * *
// * * *
// * * *
//  * *
//   * 