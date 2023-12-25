namespace ExpliInheri;
 
public class inheri:emp,orderDetails{
    void sayHello()
    {
        Console.log("Hello");
    }
    void sayGoodMorning()
    {
        Console.log("Good Morning");

    }
    void orderDetails.showDetails()
    {
        Console.log("in show Details");
    }
    void emp.showDetails()
    {
        Console.log("in show Details");
    }
}