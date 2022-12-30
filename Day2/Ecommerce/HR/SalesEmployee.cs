namespace HR;

public class SalesEmployee:Employee{
    public float Target{get;set;}
    public float SalesDone{get;set;}
    public float Incentive{get;set;}

    public SalesEmployee(){
        this.Target = 0;
        this.SalesDone = 0;
        this.Incentive = 0;
    }

    public SalesEmployee(int id,string firstName,string lastName,string email,string contactNumber,
                string location,DateTime birthDate,
                float da,float hra,float basicSalary,float target,float salesDone):
                base(id,firstName,lastName,email,contactNumber,location, birthDate,
                 da, hra,basicSalary)
                {

                     this.Target = target;
                    this.SalesDone = salesDone;
                    this.Incentive = 0;
                }

    public override void DoWork()
    {
        if(SalesDone >=Target){
            this.Incentive=5000;
        }
        else{
            this.Incentive=0;
        }
    }

    public override float ComputePay()
    {
        float  salary=base.ComputePay() + Incentive;
        return salary;
    }

    public override string ToString()
    {
        return base.ToString()  + "Incentive =" +Incentive + ", Tartget="+ Target;
    }

}