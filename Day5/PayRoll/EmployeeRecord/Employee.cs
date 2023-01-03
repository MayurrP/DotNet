namespace Record;
using System.ComponentModel.DataAnnotations;
[Serializable]
public class Employee{
    public int Id{get;set;}
    [Required]
    public string Name{get;set;}
    [Required]
    public string Designation{get;set;}
    public double Salary{get;set;}
    public Employee(){
        this.Id = 36;
        this.Name = "Rakesh";
        this.Designation = "Developer";
        this.Salary = 30000;
    }
    public Employee(int id,string name,string desg,double sal){
        this.Id = id;
        this.Name = name;
        this.Designation = desg;
        this.Salary = sal;
    }

    public override string ToString(){
        return $"Employee Id := {this.Id}, Employee Name :=  {this.Name} ,"+
                $"Employee Designation :=  {this.Designation} , Employee Salary :=  {this.Salary}";
    }
}