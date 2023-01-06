using System.Collections.Generic;
using System.Collections;
using Workhouse;
using EmpRecord;
using PlayerRecord;
//---------> Annonymous class obj
List<Object> allObj = new List<Object>();

allObj.Add(51);
allObj.Add("Mayur");
allObj.Add(78.60);
allObj.Add('z');
allObj.Add("Yo Bro!!");
allObj.Add(new{Id=1,Name="Prakiii",Attribute="Kawla Potta"}); 

allObj.ForEach(p=> Console.WriteLine(p));

Console.WriteLine("------------------------------------------------------");
//------------> Colln Part

List<Part> prt = new List<Part>();

prt.Add(new Part{Id=101,PartName="Keyboard"});
prt.Add(new Part{Id=102,PartName="Mouse"});
prt.Add(new Part{Id=103,PartName="Moniter"});
prt.Add(new Part{Id=104,PartName="Printer"});
prt.Add(new Part{Id=105,PartName="CPU"});

prt.ForEach(p=> Console.WriteLine(p));

Stack<Part> assembly = new Stack<Part>();
assembly.Push(new Part(){Id=106,PartName="Scanner"});
Queue<Part> container = new Queue<Part>();
container.Enqueue(new Part(){Id=107,PartName="Stylus"});

Dictionary<string,Part> dict = new Dictionary<string, Part>();
dict.Add("main",new Part{Id=109,PartName="Laptop"});
dict.Add("top",new Part{Id=110,PartName="SSD"});

Part thePart=dict["main"];
Console.WriteLine(thePart);

Console.WriteLine("------------------------------------------------------");

List<Employee> emp = new List<Employee>();

emp.Add(new Employee(1,"Tony",35000));
emp.Add(new Employee(2,"Tichala",30000));
emp.Add(new Employee(3,"Shoori",25000));

emp.ForEach(e=> Console.WriteLine(e.ID+"   "+e.Ename+"  "+e.Salary));

EmpComparer ec = new EmpComparer();

emp.Sort(ec);
Console.WriteLine("\nList of Employees after Sort");
emp.ForEach(e=> Console.WriteLine(e.ID+"   "+e.Ename+"  "+e.Salary));
Console.WriteLine("------------------------------------------------------");


Player p1= new Player("Sourav Ganguly",50, 300, 50000);
Player p2= new Player("Sachin Tendulkar",49, 350, 100000);
Player p3= new Player("Rahul Dravid",48, 250, 70000);

List<Player> indianPlayers=new List<Player>();
indianPlayers.Add(p1);
indianPlayers.Add(p2);
indianPlayers.Add(p3);

indianPlayers.Sort();

indianPlayers.ForEach(play=> Console.WriteLine(play));
