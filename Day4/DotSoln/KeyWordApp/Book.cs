namespace Library;
public class Books{
    private string[] titles;
    public Books(){
        titles = new string[5];
        this.titles[0]="Who will Cry When you Die?";
        this.titles[1]="IKKAGAI";
        this.titles[2]="NAGAS";
        this.titles[3]="Half GirlFriend";
        this.titles[4]="You can Win";
    }

    public string this[int index]{
        get{return this.titles[index];}
        set{this.titles[index] = value;}
    }
}