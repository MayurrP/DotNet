namespace ComplexNumber;

class Complex{
    private int real;
    private int imeg;

    public Complex(){
        this.real = 0;
        this.imeg = 0;
    }

     public Complex(int r, int i){
        this.real=r;
        this.imeg=i;
    }    

    public int Real{
        get{return this.real;}
        set{this.real = value;}
    }

    public int Imeg{
        get{return this.imeg;}
        set{this.imeg = value;}
    }
    
    public static Complex operator+ (Complex c1, Complex c2){
        Complex temp = new Complex();
        temp.real = c1.real + c2.real;
        temp.imeg = c1.imeg + c2.imeg;
        return temp;
    }

}