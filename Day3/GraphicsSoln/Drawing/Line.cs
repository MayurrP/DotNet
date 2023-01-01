namespace Drawing;

public class Line : Shape , IPrintable
{
    public Point StartPoint{get;set;}
    public Point EndPoint{get;set;}

    public Line(){
        this.StartPoint = new Point(0,0);
        this.EndPoint = new Point(0,0);
    }
    public Line(Point p1, Point p2){
        this.StartPoint = p1;
        this.EndPoint = p2;
    }
    public override void Draw()
    {
        Type t = this.GetType();
        Console.WriteLine("Class Name : "+t.Name);

        Console.WriteLine("startPoint = "+this.StartPoint+"  endPoint = "+this.EndPoint+
                        "  widht = "+this.Width+"   color = "+this.color);
    }

    public void Print(){
        Console.WriteLine("Inside Printable Interface");
        Type t = this.GetType();
        Console.WriteLine("Class Name : "+t.Name);

        Console.WriteLine("startPoint = "+this.StartPoint+"  endPoint = "+this.EndPoint+
                        "  widht = "+this.Width+"   color = "+this.color);
    }
}   