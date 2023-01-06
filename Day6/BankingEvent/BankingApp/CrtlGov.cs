namespace EGovernance;
public delegate void TaxOperation(double amt);
class CrtlGov{
    public void DeductIncomeTax(double amt){
        Console.WriteLine("45% income tax is deducted from your account.");
    }
    public void DeductServiceTax(double amt){
        Console.WriteLine("25% income tax is deducted from your account.");
    }
    public void DeductProfessionalTax(double amt){
        Console.WriteLine("15% income tax is deducted from your account.");
    }
}