using Bank;
using Notify;
Account acc=new Account();
acc.Balance=5000;

Console.WriteLine(acc.Balance);

// withdraw function call 
acc.Withdraw(1000);
Console.WriteLine(acc.Balance);

acc.Withdraw(7000);
Console.WriteLine("Your balance is : "+acc.Balance);

// NotificationOperation notify1=new NotificationOperation(NotificationSer.SendEmail);
// NotificationOperation notify2=new NotificationOperation(NotificationSer.SendSMS);
// NotificationOperation notify3=new NotificationOperation(NotificationSer.SendWhatappMSG);


// NotificationOperation proxy=null;

// proxy+=notify1;
// proxy+=notify2;
// proxy+=notify3;

// proxy("rohit");

// delegate with event

Account ac2=new Account();


ac2.underbalance+=NotificationSer.SendEmail;
ac2.overbalance+=TaxSer.payTax;

ac2.Balance=7000;
