// See https://aka.ms/new-console-template for more information
using Operation;

var p = new {
            Program = "Factorial Program"
};

Console.WriteLine(p.Program);

Factorial fact = new Factorial();
int result = fact.Facto(5);
Console.WriteLine("Factorial := "+result);