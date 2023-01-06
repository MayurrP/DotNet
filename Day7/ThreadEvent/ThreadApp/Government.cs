namespace EGovernance;

public delegate void TaxOperation();
public class CtrlGov{
    public void DeductIncomeTax(){
        Thread primaryThread = Thread.CurrentThread;
        Console.WriteLine("Thread Id := "+primaryThread.ManagedThreadId);
        Console.WriteLine("30% tax is dudected from your account.");
    }
    public void DeductServiceTax(){
        Thread primaryThread = Thread.CurrentThread;
        Console.WriteLine("Thread Id := "+primaryThread.ManagedThreadId);
        Console.WriteLine("30% tax is dudected from your account.");
    }
    public void DeductProfessionalTax(){
        Thread primaryThread = Thread.CurrentThread;
        Console.WriteLine("Thread Id := "+primaryThread.ManagedThreadId);
        Console.WriteLine("30% tax is dudected from your account.");
    }
}