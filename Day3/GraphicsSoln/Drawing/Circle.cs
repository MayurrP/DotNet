namespace Drawing;
public class Circle : Shape , IPrintable
{
    public Point Center{get;set;}
    public int Radius{get;set;}
    public Circle(){
        this.Center = new Point(0,0);
        this.Radius = 1;
    }
    public Circle(Point p1,int r){
        this.Center = p1;
        this.Radius = r;
    }

    public override void Draw()
    {
        Type t =  this.GetType();
        Console.WriteLine("Class Name : "+t.Name);

        Console.WriteLine("Center = "+this.Center+"  Radius = "+this.Radius+
                        "  widht = "+this.Width+"   color = "+this.color);
    }

    public void  Print()
    {
        Console.WriteLine("Inside Print Interface");
        Type t =  this.GetType();
        Console.WriteLine("Class Name : "+t.Name);

        Console.WriteLine("Center = "+this.Center+"  Radius = "+this.Radius+
                        "  widht = "+this.Width+"   color = "+this.color);
    }
}