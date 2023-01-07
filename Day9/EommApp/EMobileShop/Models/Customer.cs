namespace CustomerDetails;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
class Customer{
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public double MobileNo{get;set;}
    public string Email{get;set;}
    public string Password{get;set;}

    public Customer(){}
    public Customer(string fname,string lname,double mob,string email,string pass)
    {
        this.FirstName = fname;
        this.LastName = lname;
        this.MobileNo = mob;
        this.Email = email;
        this.Password = pass;
    }

    public static void Serial(List<Customer> cust)
    {
        cust.ForEach(c => Console.WriteLine(c));
    try
        {
            var options=new JsonSerializerOptions {IncludeFields=true};
            var custJson=JsonSerializer.Serialize<List<Customer>>(cust,options);
            string fileName=@"D:\Practical\dotnetPractical\DotNet\Day9\EommApp\CustomerDetails.json";
            File.WriteAllText(fileName,custJson);
        }
        catch (Exception e)
        {
            Console.WriteLine("Message :=> "+e);
        }
    }

    public static List<Customer> Dser(){
        List<Customer> li=new List<Customer>();
        string fileName=@"D:\Practical\dotnetPractical\DotNet\Day9\EommApp\CustomerDetails.json";
        string jsonString = File.ReadAllText(fileName);
        if(jsonString=="")
        return null;
        li = JsonSerializer.Deserialize<List<Customer>>(jsonString);
        return li;
    }
}