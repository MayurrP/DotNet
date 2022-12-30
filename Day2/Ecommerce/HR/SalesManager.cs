using HR;
public class SalesManager:SalesEmployee{
    public float Bonus{get;set;}
    public SalesManager():base(){
        Bonus=0;
    }

    public SalesManager(int id,string firstName,string lastName,string email,string contactNumber,
                string location,DateTime birthDate,float da,float hra,float basicSalary,
                float target,float salesDone,float bonus):
                base(id,firstName,lastName,email,contactNumber,location, birthDate,
                 da, hra,basicSalary,target,salesDone){

                    this.Bonus = bonus;
                }
    public override float ComputePay()
    {
        return base.ComputePay()+ Bonus;
    }

    public override void DoWork()
    {
        base.DoWork();
    }

    public override string ToString()
    {
        return base.ToString() + " Bonus="+ Bonus;
    }
}