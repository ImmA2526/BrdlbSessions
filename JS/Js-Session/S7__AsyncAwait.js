const objectData = [
    { name: "Imran", add: "Pune", age: "33" },
    { name: "Amit", add: "Pune", age: "33" },
    { name: "Ankit", add: "Pune", age: "39" },
    { name: "Anikesh", add: "Bombay", age: "33" },
];

function getUsers() {
    setTimeout(() => {
        let output = '';
        objectData.forEach((objectData, index) => {
            output += `<li>${objectData.name}</li>`; //Template Syntax
            output += `<li>${objectData.age}</li>`;
            output += `<li>${objectData.add}</li>`;
        });
        document.body.innerHTML = output;
    }, 1000);
}

function createUsers(userData) {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            objectData.push(userData);
            const error = false;
            if (!error) {
                resolve();
            }
            else {
                reject("Something is not Good");
            }
        }, 2000);
    });

}

// createUsers({ name: "Abhilasha", add: "Bombay", age: "33" }).then(getUsers).catch(errorShow => console.log(errorShow));   //promise

//Async Await...

async function display() {
    await createUsers({ name: "Abhilasha", add: "Bombay", age: "33" });

    getUsers();
}

console.log("Calling Display ");
console.log(display());

//Try Catch 

try {
    console.log("Try Block...");
    functionNames();
} catch (error) {
    console.log("Function not Define...");  
    console.log(error.message);
}
finally{
    console.log("Always Execute");
}
