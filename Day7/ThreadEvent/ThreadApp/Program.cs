using EGovernance;
using System.Threading;

Thread primaryThread = Thread.CurrentThread;
Console.WriteLine("Thread Id :=> "+primaryThread.ManagedThreadId);

CtrlGov bjpGovt = new CtrlGov();

TaxOperation inOpern = new TaxOperation(bjpGovt.DeductIncomeTax);
TaxOperation serOpern = new TaxOperation(bjpGovt.DeductServiceTax);
TaxOperation proOpern = new TaxOperation(bjpGovt.DeductProfessionalTax);

//inOpern.Invoke();

// IAsyncResult iResult=inOpern.BeginInvoke(null,null);
// if(iResult.IsCompleted)
// {
//     Console.WriteLine(" Task is completed....");
// }
// proOpern.BeginInvoke(null, null);
