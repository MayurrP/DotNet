using Drawing;
using System.Collections.Generic;

Point pt1 = new Point(10,10);
Point pt2 = new Point(200,200);

Shape shape1 = new Line(pt1,pt2);

Point pt3 = new Point(10,10);
Point pt4 = new Point(200,200);

Shape shape2 = new Rectangle(pt3,pt4);

Point pt5 = new Point(50,50);
int radius = 50;

Shape shape3 = new Circle(pt5,radius);

List<Shape> shapes = new List<Shape>();
shapes.Add(shape1);
shapes.Add(shape2);
shapes.Add(shape3);

Console.WriteLine("Draw Shape");

foreach (Shape s in shapes)
{
    Console.WriteLine("----------------------------------------------------------------------");
    s.Draw();
    IPrintable obj = (IPrintable)s;
    obj.Print(); 
    Console.WriteLine("----------------------------------------------------------------------");
}