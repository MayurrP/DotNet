namespace  HR;

public sealed class Person{
    public double PI;
    private int Id{get;set;}
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public static Person _ref = null;
    Person(){
        this.Id = 51;
        this.FirstName = "Mayur";
        this.LastName = "Pakhale";
        PI = 3.14;
    }

    public static Person CreateInstance(){
        if(_ref == null){
            _ref = new Person();
        }
        return new Person();
    }
    public static void Display(Person p){
        Console.WriteLine("Id : "+p.Id+"   FirstName : "+p.FirstName+"    LastName : "+p.LastName+"  PI : "+p.PI);
    }

    public void Details(params string [] names){
        foreach (var s in names)
        {
            Console.WriteLine(s);
        }
    }    

    public void Swap(ref int n1,ref int n2){
        Console.WriteLine("Num1 : "+n1+"    Num2 : "+n2);
        int temp = n1;
        n1 = n2;
        n2 = temp;
        Console.WriteLine("Num1 : "+n1+"    Num2 : "+n2);
    }

    public void Calculate(int radius, out double area, out double circumference ){
       area=PI * radius * radius;
       circumference=2 * PI * radius;
    }


}