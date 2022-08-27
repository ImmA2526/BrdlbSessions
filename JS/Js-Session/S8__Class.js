let names = ["Amit", "Anis", "Keshav"];

class personDetail {
    constructor(firstName, lastName, age, gender) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.gender = gender;
    }

    get fullName() { //get 
        return `${this.firstName} ${this.lastName} ${this.age}`
    }

    set fullName(fullName) {
        const [firstName, lastName] = fullName.split(" ");
        this.firstName = firstName;
        this.lastName = lastName;
    }

    addition() {
        var prompt = require('prompt-sync')();
        var number1 = Number(prompt("Enter Number: "));
        var number2 = Number(prompt("Enter Number: "));
        var number3 = number1 + number2;
        console.log("Addition is:" + number3);
    }

    static multiplication() {
        var prompt = require('prompt-sync')();
        var number1 = prompt("Enter Number: ");
        var number2 = prompt("Enter Number: ");
        var number3 = number1 * number2;
        console.log("Multiplication is:" + number3);
    }
}

class functionone {
     constructor(firstName, lastName, age, gender) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.gender = gender;
    }

    printingName() {
        console.log("Inside the anothr class");
        console.log(names);
    }
}

const persons = new personDetail("Imran", "Shaih", 22, 'M')
// console.log(persons);
// console.log(persons.fullName);

// persons.firstName = "Amit";
// persons.fullName = "Gujar"

// persons.fullName = "Amir Shaikh";
// console.log(persons.fullName);

console.log("***Calling Methods****")
// personDetail.multiplication();  ///calling static method
// persons.multiplication();
// persons.addition();

const printingNames=new functionone(this.printingName);
printingNames.printingName();