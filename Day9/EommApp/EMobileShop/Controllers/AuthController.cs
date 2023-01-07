using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EMobileShop.Models;
using CustomerDetails;

namespace EMobileShop.Controllers;

public class AuthController : Controller
{
    private readonly ILogger<AuthController> _logger;

    public AuthController(ILogger<AuthController> logger)
    {
        _logger = logger;
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult postRegistration(string fname,string lname,double mob,string email,string pass){
        Console.WriteLine("Insert data in json on acton registrstion.");
        List<Customer> li=new List<Customer>();
        li=Customer.Dser();
        if(li[0]!=null)
        foreach(Customer s in li){
            if(s.Email==email){
                return Redirect("/auth/Registration");
            }   
        }
        li.Add(new Customer(fname,lname,mob,email,pass));
        Customer.Serial(li);
        return Redirect("/auth/Login");
        //return View();
    }  
     public IActionResult Validate(string email, string password){

        Console.WriteLine("Validating User credentials.... ");
        List<Customer> li=Customer.Dser();
        if(li!=null)
        foreach(Customer c in li){
            if(c.Email==email && c.Password==password){
                return Redirect("/home/IACSD");
            }
        }
        return Redirect("/auth/Welcome");

        if(email =="mayur@gmail.com" && 
           password=="mayur123"){
            Console.WriteLine("successfull validation of user..... ");
            Console.WriteLine("Redirecting to welcome..... ");  
            return Redirect("/auth/Welcome");
           }
        return View();
    }  
      public IActionResult Registration()
    {
        return View();
    }
    public IActionResult Welcome()
    {
        return View();
    }
   
}

