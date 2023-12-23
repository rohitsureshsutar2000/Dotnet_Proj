namespace Notify;

public static class NotificationSer{

    public static void SendSMS(string s)
    {
        Console.WriteLine("sms send to ..."+s);
    }
    public static void SendEmail(string s)
    {
        Console.WriteLine("Email send to ..."+s);
    }
    public static void SendWhatappMSG(string s)
    {
        Console.WriteLine("Msg send to ..."+s);
    }
}