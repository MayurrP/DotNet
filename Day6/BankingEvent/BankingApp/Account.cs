namespace Banking;
using EGovernance;
using BankingManager;
class Account{
    public double Balance{get;set;}
    public event TaxOperation overbalace;
    public event Manager underbalance;
    public Account(double bal){
        this.Balance = bal;
    }
    public void WithDraw(double amt){
        if(this.Balance < amt)
        {
            underbalance();
        }
        else{
        this.Balance-=amt;  
        }      
    }
    public void Deposite(double amt){
        this.Balance+=amt;
    }

    public override string ToString()
    {
        return base.ToString()+"   Balance :=>  "+this.Balance;
    }

    public void ProcessTax(){
        if(Balance >= 250000){
            overbalace(this.Balance);
        }
    }
}
