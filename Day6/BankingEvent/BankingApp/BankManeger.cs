namespace BankingManager;
public delegate void Manager();
public class BankManager{
    public void BlockAccount(){
        Console.WriteLine("Your account is blocked due to low Balance.");
    }
    public void SendEmail(){
        Console.WriteLine("Your Balance is low to widthdraw amount");
    }
    public void SendSms(){
        Console.WriteLine("Your Balance is low to widthdraw amount");
    }
}