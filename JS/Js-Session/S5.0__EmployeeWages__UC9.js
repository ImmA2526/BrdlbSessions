/*
//UC1 Check Employee Absent or Present
var empAttendance=Math.random();
if(empAttendance < 0.5){
    console.log("Employee is Present");
}else{
    console.log("Employee is Absent");
}
//UC2 calculate Daily Wage
let workHrs = 8;
let wagePerHrs = 20;
let dailyWage = workHrs * wagePerHrs;
console.log("Calculate the Daily Wage: ", dailyWage);
// UC3 calculate part time
let partTime_hrs = 4;
let wagePerHrs = 20;
let dailyWage = partTime_hrs * wagePerHrs;
console.log("Calculate the part time Daily Wage: ", dailyWage);
*/

// UC4 Employee wage using switch case

var empAttendance = Math.floor(Math.random() * 3);

var wagePerHrs = 20;
var WorkHrs = 0;
switch (empAttendance) {
    case 1:
        console.log("Employee is Present Part time. ");
        WorkHrs = 4;
        break;
    case 2:
        console.log("Employee is Present Full time. ");
        WorkHrs = 8;
        break;
    default:
        console.log("Employee is Absent. ");
        break;
}
console.log("Calculate Employe Wage");
var dailyWage = WorkHrs * wagePerHrs;
console.log("Employee Wage: ",dailyWage);

/*
//UC5 Calculate one month wage
console.log("[Checking employee attendance and display wage per day]");
var dailyWage;
var monthWage = 0;
var workHrs;
var wagePerHrs = 20;
var empAttendance = Math.floor(Math.random() * 3);
var numOfDays = 20;
for (var day = 1; day <= numOfDays; day++) {
    
    switch (empAttendance) {
        case 1:
            workHrs = 4;
            break;
        case 2:
            workHrs = 8;
            break;
        default:
            workHrs = 0;
            break;
    }
   
}
dailyWage = workHrs*wagePerHrs;
console.log(" "+dailyWage+" ");
monthWage = monthWage + dailyWage;
console.log("Total wage: "+ monthWage);
// UC6 Canditional based wage calculation
console.log("[ Checking employee attendance and display wage per day ]");
var dailyWage = 0;
var monthWage = 0;
var wagePerHr = 20;
var WorkHrs;
var maxWorkingDays = 20;
var maxWorkingHrs = 100;
var totalEmpHrs = 0;
var totalWorkingDays = 0;
while (totalEmpHrs < maxWorkingHrs && totalWorkingDays < maxWorkingDays) {
    var empAttendance = Math.floor(Math.random() * 3);
    switch (empAttendance) {
        case 1:
            WorkHrs = 4;
            break;
        case 2:
            WorkHrs = 8;
            break;
        default:
            WorkHrs = 0;
            break;
    }
    dailyWage = WorkHrs * wagePerHr;
    monthWage = monthWage + dailyWage;
    totalWorkingDays++;
    totalEmpHrs = totalEmpHrs + WorkHrs;
    console.log("Days: " + totalWorkingDays + " Wage: " + dailyWage + " Hrs: " + totalEmpHrs);
}
console.log("Total Working Days: " + totalWorkingDays + " Total working Hours: " + totalEmpHrs);
console.log("Total Wage: " + monthWage);
//UC7 Refactor And Calculate wage
console.log("[ Checking employee attendance and displaying wage per day ]");
var dailyWage;
var monthWage = 0;
var wagePerHr = 20;
var workHrs;
var isPartTime = 4, isFullTime = 8;
var maxWorkingDays = 20;
var maxWorkingHrs = 100;
var totalEmpHrs = 0;
var totalWorkingDays = 0;
while (totalEmpHrs < maxWorkingHrs && totalWorkingDays < maxWorkingDays) {
    var empAttendance = Math.floor(Math.random() * 3);
    switch (empAttendance) {
        case 1:
            workHrs = 4;
            break;
        case 2:
            workHrs = 8;
            break;
        default:
            workHrs = 0;
            break;
    }
    dailyWage = workHrs * wagePerHr;
    monthWage += dailyWage;
    totalWorkingDays++;
    totalEmpHrs += workHrs;
    console.log("Days: " + totalWorkingDays + " Wage: " + dailyWage + " Hrs: " + totalEmpHrs);
}
console.log("Total working Days: " + totalWorkingDays + " Total working Hours: " + totalEmpHrs);
console.log("Total wage: " + monthWage);
// UC8 Multiple company Employee wage
var dailyWage;
var monthWage = 0;
var workHrs;
var maxWorkingDays;
var maxWorkingHrs;
var wagePerHrs;
var totalEmpHrs = 0, totalWorkingDays = 0;
while (totalEmpHrs < maxWorkingHrs && totalWorkingDays < maxWorkingDays) {
    var empAttendance = Math.floor(Math.random() * 3);
    switch (empAttendance) {
        case 1:
            workHrs = 4;
            break;
        case 2:
            workHrs = 8;
            break;
        default:
            workHrs = 0;
            break;
    }
    dailyWage = workHrs * wagePerHrs;
    monthWage += dailyWage;
    totalWorkingDays++;
    totalEmpHrs += workHrs;
}
console.log("WagePerHrs: " + wagePerHrs + " maxWorkingHrs: " + maxWorkingHrs + " MaxWorkingDays: " + maxWorkingDays + " MonthWage: " + monthWage);
*/