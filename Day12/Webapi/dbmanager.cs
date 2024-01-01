using BOJ;
namespace db;
static class DBmanager{
    public static List<RiderLogin> getall()
    {
        List<RiderLogin>  lst= new List<RiderLogin> ();
        lst.Add(new RiderLogin(1,"abhi","abhi"));
        lst.Add(new RiderLogin(2,"abhi2","abhi2"));
        lst.Add(new RiderLogin(3,"abhi3","abhi3"));
        lst.Add(new RiderLogin(4,"abhi4","abhi4"));
        return lst;
    }
}