namespace Bank;
using Notify;
public class Account{

    public event NotificationOperation underbalance;
    public event taxOperation overbalance;

    public double Balance{
        get;set;
    }

    public void Deposit(double b){
        this.Balance=this.Balance+b;
        Console.WriteLine("Updata balance succesfull... ");
    }

    public void Withdraw(double b){
        if(Balance-b>=0){
            if(Balance >5000)
            {
                overbalance("he");
            }
            this.Balance=this.Balance-b;
            Console.WriteLine("remaining balance "+ Balance );
        }
        else{
            underbalance("hi");
            Console.WriteLine("Balance is to lowwwwwww!!!");
        }
    }


}