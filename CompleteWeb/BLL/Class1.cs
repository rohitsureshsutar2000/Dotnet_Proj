namespace BLL;
using BOJ;
using dbmanagerUtil;
using System.Collections.Generic;

public static class BLLservice
{
    public static List<RiderLogin> GetAlldetails(){
        List<RiderLogin> lst=new List<RiderLogin>();
        lst=BDmanager.GetAlldetails();
        return lst;
    }
    


}
