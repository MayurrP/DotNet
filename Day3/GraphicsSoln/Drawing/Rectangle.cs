namespace Drawing;

public class Rectangle : Shape , IPrintable
{
    public Point StartPoint{get;set;}
    public Point EndPoint{get;set;}
    public Rectangle(){
        this.StartPoint = new Point(0,0);
        this.EndPoint = new Point(0,0);
    }
    public Rectangle(Point p1,Point p2){
        this.StartPoint = p1;
        this.EndPoint = p2;
    }

    public override void Draw()
    {
        Type t = this.GetType();
        Console.WriteLine("Class Name : "+t.Name);

        Console.WriteLine("startPoint = "+this.StartPoint+"  endPoint = "+this.EndPoint+
                        "  widht = "+this.Width+"   color = "+Color.GREEN);
    }

    public void  Print()
    {
        Console.WriteLine("Inside Print Interface");
        Type t =  this.GetType();
        Console.WriteLine("Class Name : "+t.Name);

         Console.WriteLine("startPoint = "+this.StartPoint+"  endPoint = "+this.EndPoint+
                        "  widht = "+this.Width+"   color = "+Color.GREEN);
    }
}