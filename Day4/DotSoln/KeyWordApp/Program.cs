using HR;
using catalog;
using Library;

// Person.CreateInstance();
// Person.Display(Person._ref);

// Person._ref.Details("john","ram","shyam","rohan");

// int num1 = 10,num2 = 20;

// Person._ref.Swap(ref num1,ref num2);

// double area=0;
// double circumference=0;
// Console.WriteLine( "area ={0}, circumference ={1}", area,circumference);
// Person._ref.Calculate(23,out area, out circumference);
// Console.WriteLine( "area ={0}, circumference ={1}", area,circumference);

Product [] products={
                     new Product {Title="Rose",UnitPrice=12},
                      new Product {Title="Jasmine",UnitPrice=2},
                      new Product {Title="Lotus",UnitPrice=32},
};

foreach (var pro in products)
{
    Console.WriteLine(pro.ToString());
}

// int [] [] studentMarks=new int[2][];
// studentMarks[0]=new int[] {67,45,34,65,45,34};
// studentMarks[1]=new int[3];
// int marksofAStudent=studentMarks[0][2];
// foreach (var pro in studentMarks)
// {
//     Console.WriteLine(pro.);
// }

Books books = new Books();
string title = books[0];
Console.WriteLine("Title := "+title);
books[3] = "Something Wicked This Way Comes";
title = books[3];
Console.WriteLine("Title := "+title);
