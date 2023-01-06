namespace EmpRecord;

public class Employee{
    public int ID{get;set;}
    public string Ename{get;set;}
    public double Salary{get;set;}

    public Employee(int id,string name,double sal){
        this.ID = id;
        this.Ename = name;
        this.Salary = sal;
    }
}