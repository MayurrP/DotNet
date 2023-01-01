namespace Drawing;

public enum  Color{RED, GREEN, BLUE, YELLOW};
public abstract class Shape{

    protected int Width{get;set;}    
    protected Color color{get;set;}

     public abstract void Draw();

}