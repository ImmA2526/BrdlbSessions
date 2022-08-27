//Promise
function promise() {
    return new Promise(function (resolve, reject) {
        setTimeout(() => {
            const error = true;
            if (!error) {
                console.log('Function: Your promise has been resolved')
                resolve();
            }
            else {
                console.log('Function: Your promise has not been resolved')
                reject('Sorry not fulfilled');
            }
        }, 2000);
    })
}

promise().then(function () {
    console.log("Resolved")
}).catch(function (error) {
    console.log("Bad Response" + error)
})

// //Example:-
const students = [
    { name: "Anis", subject: "Php" },
    { name: "Amit", subject: "Machine Learning" },
    { name: "Ashok", subject: "Python" },
    { name: "Ankit", subject: "Machine Learning" }

]

function enrollStudent(student) {
    return new Promise(function (resolve, reject) {
        setTimeout(function () {
            students.push(student);
            console.log("Student has been Enrolled");
            const error = true;
            if (!error) {
                resolve();
            }
            else {
                reject();
            }
        }, 1000);
    })
}

function getStudents() {
    setTimeout(function () {
        let str = "";
        students.forEach(function (student) {
            str += `<li> ${student.name}</li>`
        });
        document.getElementById('students').innerHTML = str;
        console.log("Students have been Fetched");
    }, 5000);
}

let newStudent = { name: "Imran", subject: "Python" }
enrollStudent(newStudent).then(getStudents).catch(function () {
    console.log("Some error occured");
});

getStudents();

// // function inside then is run  - resolve()
// // function inside catch is run  - reject()

// //Async Await...

// async function names(){
//     return "Imran";
// }

// console.log(names());