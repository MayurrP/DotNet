// See https://aka.ms/new-console-template for more information
using Operation;
using Calculation;

double result;

var p = new {
            Program1 = "Factorial Program",
            Program2 = "Caculator Programs"
};
Console.WriteLine("---------------------------------");
Console.WriteLine(p.Program1);

Factorial fact = new Factorial();
result = fact.Facto(5);
Console.WriteLine("Factorial := "+result);

Console.WriteLine("---------------------------------");
Console.WriteLine("---------------------------------");
Console.WriteLine(p.Program2);

//------> Addition

Calculator cal = new Calculator();

result = cal.Addition(23.45,45.34);
Console.WriteLine("Addition is : "+result);
Console.WriteLine("---------------------------------");

//------> Subtraction

result = cal.Subtraction(56,35.34);
Console.WriteLine("Subtraction is : "+result);
Console.WriteLine("---------------------------------");

//------> Multiplication

result = cal.Multiplication(23,4);
Console.WriteLine("Multiplication is : "+result);
Console.WriteLine("---------------------------------");

//------> Division

result = cal.Division(20,4.5);
Console.WriteLine("Division is : "+result);
Console.WriteLine("---------------------------------");