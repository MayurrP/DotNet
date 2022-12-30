using HR;
using Membership;

Console.WriteLine("********** User Application **********");

Console.WriteLine("Enter your Email ID");
string email=Console.ReadLine();

Console.WriteLine("Enter your password");
string password=Console.ReadLine();

if(AuthManager.Validate(email,password)){
    Console.WriteLine("Welcome to Pandoro");
    Employee emp=new SalesManager();
    emp.DoWork();
    Console.WriteLine(emp);
    float salary=emp.ComputePay();
    Console.WriteLine("Salary = "+ salary);
}
else{
    Console.WriteLine("You Do not have right live in pandora");
}