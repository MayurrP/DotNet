using Record;
using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

//bool exit = true;
// while (exit)
// {
    Console.WriteLine("********** Employee Records **********");
    Console.WriteLine("1. Register New Employee");
    Console.WriteLine("2. Update Employee");
    Console.WriteLine("3. Delete Employee Record");
    Console.WriteLine("4. Search Employee by Id");
    Console.WriteLine("5. All Employee Details");


    Console.Write("Enter Employee ID : ");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Employee Name : ");
    string empName = Console.ReadLine();
    Console.Write("Enter Employee Designation : ");
    string desg = Console.ReadLine();
    Console.Write("Enter Employee Salary : ");
    double sal = Convert.ToDouble(Console.ReadLine());

    Employee ep = new Employee{Id = id,Name = empName,Designation = desg,Salary = sal};
    Employee e1 = new Employee{Id = 36,Name = "Ronny",Designation = "Jr.Developer",Salary = 30000};
    Employee e2 = new Employee{Id = 37,Name = "Jhon",Designation = "Sr.Developer",Salary = 40000};
    Employee e3 = new Employee{Id = 38,Name = "Tichala",Designation = "Maneger",Salary = 50000};
    Employee e4 = new Employee{Id = 39,Name = "Tony",Designation = "Designer",Salary = 35000};

    List<Employee> emp = new List<Employee>();
    emp.Add(ep);
    emp.Add(e1);
    emp.Add(e2);
    emp.Add(e3);
    emp.Add(e4);

    try{
            // dynamic data type variable
            var options=new JsonSerializerOptions {IncludeFields=true};
            var employeeJson=JsonSerializer.Serialize<List<Employee>>(emp,options);
            string fileName=@"D:\Practical\dotnetPractical\DotNet\Day5\PayRoll\Employees.json";
            //Serialize all emp into json file

            File.WriteAllText(fileName,employeeJson);
            //Deserialize from JSON file
            string jsonString = File.ReadAllText(fileName);
            List<Employee> jsonEmp = JsonSerializer.Deserialize<List<Employee>>(jsonString);
            Console.WriteLine("\n JSON :Deserializing data from json file\n \n");
            foreach( Employee e in jsonEmp)
            {
                Console.WriteLine($"{e.Id} : {e.Salary}"); 
            }   
    }
   catch(Exception exp){
    
    }
    finally{ }

// }
