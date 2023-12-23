namespace Bank;
public class Account{
    public double Balance{
        get;set;
    }

    public void Deposit(double b){
        this.Balance=this.Balance+b;
        Console.WriteLine("Updata balance succesfull... ");
    }

    public void Withdraw(double b){
        if(Balance-b>=0){
            this.Balance=this.Balance-b;
            Console.WriteLine("remaining balance "+ Balance );
        }
        else{
            Console.WriteLine("Balance is to lowwwwwww!!!");
        }
    }


}