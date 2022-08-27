// Operators
let a = 20, b=20 ,c=0,d="Imran";
c=a+b;
console.log("Addition of ++ :"+c); //40
c++;
console.log("Value of ++ :"+c); // 41   
c--;
console.log("Value of --:"+c); // 40

console.log(a==b);
console.log(a===d); 


// Implicit Conversion
let implicitConversion = 'Imran' + 2; 
console.log(implicitConversion)

implicitConversion = 'DataAlgorithm' + true; 
console.log(implicitConversion);

implicitConversion = 'NumberUndefined' + undefined; 
console.log(implicitConversion);

// Explicit Conversion

let explicitConversion = "1223";
console.log(parseInt(explicitConversion));

explicitConversion = parseFloat('324e-1')  
console.log(explicitConversion);
console.log(typeof(explicitConversion));

// boolean to number
explicitConversion = Number(true);
console.log(explicitConversion);

// QQ]] Program to Convert data type from array to object. 
// QQ]] Program to check the result using All the Condiitonal operator.