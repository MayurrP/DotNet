using System;
using Banking;
//using EGovernance;
using BankingManager;

//CrtlGov bjpGovt = new CrtlGov();

//bjpGovt.DeductIncomeTax();

// Account acc = new Account(6000);
// acc.Deposite(5000);

//------------> ex of Unicast Delegate

//  TaxOperation incomeTax = new TaxOperation(bjpGovt.DeductIncomeTax);
// // incomeTax();
//  TaxOperation serviceTax = new TaxOperation(bjpGovt.DeductServiceTax);
// // serviceTax();
//  TaxOperation proTax = new TaxOperation(bjpGovt.DeductProfessionalTax);
// proTax();

//-------->  ex of Multicast Deligate

// TaxOperation? policies = null;
// policies = incomeTax;
// policies += serviceTax;
// policies +=proTax;

// policies(2000);

// Account acc = new Account(10000);

// acc.overbalace += incomeTax;
// acc.overbalace += proTax;
// acc.overbalace += serviceTax;

// Console.WriteLine("Enter Amount to be deposited");
// double amount=double.Parse(Console.ReadLine());
// acc.Deposite(amount);

// Console.WriteLine("Before Tax processing");
// Console.WriteLine(acc);

// acc.ProcessTax();
// Console.WriteLine("After Tax processing");
// Console.WriteLine(acc);

BankManager bank = new BankManager();

Manager blockAcc = new Manager(bank.BlockAccount);
Manager sms = new Manager(bank.SendSms);
Manager email = new Manager(bank.SendEmail);

Account acc = new Account(10000);

acc.underbalance += blockAcc;
acc.underbalance += sms;
acc.underbalance += email;

Console.WriteLine("Before  Widthdraw");
Console.WriteLine(acc);

Console.WriteLine("Enter Amount to be Widthdraw");
double amount=double.Parse(Console.ReadLine());

acc.WithDraw(amount);

Console.WriteLine("After Widthdraw");
Console.WriteLine(acc);

