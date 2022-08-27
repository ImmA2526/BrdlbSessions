// UC1 2

const regex = /^[A-Z]{1}[a-z]{2,}/;
let str = "Am";

let result = regex.exec(str);
// console.log("The result from exec is : ", result);

if(regex.test(str)){
    console.log(`The string ${str} matchs the expression ${regex.source}`);
}
else{
    console.log(`The string ${str} does not match the expression ${regex.source}`);
}

// UC 3 email

const regex = /^[A-Za-z0-9]+([.+-_][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][A-Za-z]+([.][A-Za-z]+)?$/;
let str = "amitkr24031995@gmail.com";

let result = regex.exec(str);
console.log("The result from exec is : ", result);

if(regex.test(str)){
    console.log(`The string ${str} matchs the expression ${regex.source}`);
}
else{
    console.log(`The string ${str} does not match the expression ${regex.source}`);
}


// UC 4
const regex = /^[a-zA-Z0-9_!-+@#$]{8,}$/;
let str = "jkkjc784@#";

let result = regex.exec(str);
console.log("The result from exec is : ", result);

if(regex.test(str)){
    console.log(`The string ${str} matchs the expression ${regex.source}`);
}
else{
    console.log(`The string ${str} does not match the expression ${regex.source}`);
}
// UC 5
const regex = /^[0-9]{10}$/;
let str = "9897139203";

let result = regex.exec(str);
console.log("The result from exec is : ", result);

if(regex.test(str)){
    console.log(`The string ${str} matchs the expression ${regex.source}`);
}
else{
    console.log(`The string ${str} does not match the expression ${regex.source}`);
}

// UC 6
const regex = /^(?=.*[a-z0-9A-Z])(?=.*[A-Z]).{8,}$/;
let str = "abcABC1234.";

let result = regex.exec(str);
console.log("The result from exec is : ", result);

if(regex.test(str)){
    console.log(`The string ${str} matchs the expression ${regex.source}`);
}
else{
    console.log(`The string ${str} does not match the expression ${regex.source}`);
}

// UC 7
const regex = /^(?=.*[a-z0-9A-Z])(?=.*[A-Z])(?=.*[0-9]).{8,}$/;
let str = ".Abc..123xyz.";

let result = regex.exec(str);
console.log("The result from exec is : ", result);

if(regex.test(str)){
    console.log(`The string ${str} matchs the expression ${regex.source}`);
}
else{
    console.log(`The string ${str} does not match the expression ${regex.source}`);
}

// UC 8

const regex = /^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[~`!@#$%^&*_+=,./?]).{8,}$/;
let str = "abc?456~@3XYZ";

let result = regex.exec(str);
console.log("The result from exec is : ", result);

if(regex.test(str)){
    console.log(`The string ${str} matchs the expression ${regex.source}`);
}
else{
    console.log(`The string ${str} does not match the expression ${regex.source}`);
}

// UC 9

const regex = /^[A-Za-z0-9]+([.+-_][A-Za-z0-9]+)*(([@][a-zA-Z0-9]{1,}){1})+([.][A-Za-z]{2,3})+(([.][A-Za-z]{2,3}))?$/;
let str = "amit123Krishna@yahoo.com";

let result = regex.exec(str);
console.log("The result from exec is : ", result);

if(regex.test(str)){
    console.log(`The string ${str} matchs the expression ${regex.source}`);
}
else{
    console.log(`The string ${str} does not match the expression ${regex.source}`);
}