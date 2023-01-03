using Record;
using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

bool exit = true;
Employee employ = new Employee();
List<Employee> emp = new List<Employee>();
    int id;
    string? empName,desg;
    double sal;
    string fileName=@"D:\Practical\dotnetPractical\DotNet\Day5\PayRoll\Employees.json";

Employee e1 = new Employee{Id = 36,Name = "Tichala",Designation = "Jr.Developer",Salary = 30000};
Employee e2 = new Employee{Id = 37,Name = "Tony",Designation = "Sr.Developer",Salary = 40000};

emp.Add(e1);
emp.Add(e2);
JsonRead();
while (exit)
{
    Console.WriteLine("********** Employee Records **********");
    Console.WriteLine("1. Register New Employee");
    Console.WriteLine("2. Update Employee");
    Console.WriteLine("3. Delete Employee Record");
    Console.WriteLine("4. Search Employee by Id");
    Console.WriteLine("5. All Employee Details");
    Console.WriteLine("0. Exit");
    Console.Write("Enter Choice : ");


    switch (Convert.ToInt32(Console.ReadLine()))
    {
        //--------> Registered Employee -------> Complete
        case 1:
            Console.Write("Enter Employee ID : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name : ");
            empName = Console.ReadLine();
            Console.Write("Enter Employee Designation : ");
            desg = Console.ReadLine();
            Console.Write("Enter Employee Salary : ");
            sal = Convert.ToDouble(Console.ReadLine());
            employ = new Employee{Id = id,Name = empName,Designation = desg,Salary = sal};
            emp.Add(employ);
            foreach (var record in emp)       
            {
                if(record.Id == id){
                    Console.WriteLine("Employee Registered Successfully with following Details");
                    Console.WriteLine(record.ToString());
                }   
            }
            JsonRead();
        break;
        case 2:
            
        break;
        case 3:
       
        break;

//--------> Search Employee with Id-------> Complete

        case 4:
        bool status = false;
        Console.Write("Enter Employee ID : ");
            id = Convert.ToInt32(Console.ReadLine());
            foreach (var record in emp)       
                {
                    if(record.Id == id){
                        status = true;
                        Console.WriteLine("Record Found. ");
                        Console.WriteLine(record.ToString());
                    }   
                }
            if (status == false){
                Console.WriteLine("No record Found with this Id");
            };
        break;

//--------> Details Employee-------> Complete

        case 5:
            JsonWrite();
        break;
        case 0:
        exit = false;
        break;
    }    
}

void JsonRead(){
        try{
            var options=new JsonSerializerOptions {IncludeFields=true};
            var employeeJson=JsonSerializer.Serialize<List<Employee>>(emp,options);
            File.WriteAllText(fileName,employeeJson);
    }
   catch(Exception exp){
    Console.WriteLine(exp.Message);
    }
    finally{ }
    }

    void JsonWrite()
    {
        try{
            string jsonString = File.ReadAllText(fileName);
            List<Employee> jsonEmp = JsonSerializer.Deserialize<List<Employee>>(jsonString);
            Console.WriteLine("\n Record of Employees \n");
            foreach( Employee e in jsonEmp)
            {
                Console.WriteLine($"Employee Id := {e.Id}, Employee Name :=  {e.Name} , Employee Designation :=  {e.Designation} , Employee Salary :=  {e.Salary}"); 
            }   
        }
        catch(Exception exp){
        Console.WriteLine(exp.Message);
    }
    finally{ }
    }

