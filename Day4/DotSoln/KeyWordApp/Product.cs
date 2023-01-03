namespace catalog;

public class Product{
    public string Title{get;set;}
    public double UnitPrice{get;set;}

    public Product(){

    }

    public override string ToString(){
        return "[ Title : "+this.Title+"    Unit Price : "+this.UnitPrice+"]";
    }
}
