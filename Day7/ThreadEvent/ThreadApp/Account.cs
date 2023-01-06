namespace Banking;

class Account{
    public double Balance{get;set;}
    public Account(double bal){
        this.Balance = bal;
    }
    public void WidthDraw(double amt){
        this.Balance -= amt;
    } 
    public void Deposite(double amt){
        this.Balance += amt;
    }
    public override string ToString()
    {
        return base.ToString()+"  Balance :=> "+this.Balance;
    }
}
