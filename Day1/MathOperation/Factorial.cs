using System;
namespace Operation;

public class Factorial{

    private int num;
    public Factorial(){
        this.num = 1;
    }

    public Factorial(int num){
        this.num = num;
    }

    public int Facto(int num){
        int i = num;
        int res = 1;
        while (i != 0)
        {
            res = res * i;
            i--;
        }
        return res;
    }


}