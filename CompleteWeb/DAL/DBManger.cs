using BOJ;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
namespace dbmanagerUtil;


public static class BDmanager {

    public static List<RiderLogin> GetAlldetails()
    {
        List<RiderLogin> lst=new List<RiderLogin>();
        MySqlConnection connection=new MySqlConnection();
        connection.ConnectionString="server=localhost;port=3306;user=root;password=welcome;database=riderpoint";

        string query="select * from loginrider";
        try
        {
            MySqlCommand cmd=new MySqlCommand(query,connection);
            connection.Open();
            MySqlDataReader dr=cmd.ExecuteReader();
            while(dr.Read())
            {
                int id=int.Parse(dr["id"].ToString());
                string username=dr["username"].ToString();
                string password=dr["password"].ToString();
                RiderLogin rs=new RiderLogin{Id=id,Username=username,Password=password};
                lst.Add(rs);
            }
        }
        catch(Exception e)
        {
            
            Console.WriteLine(e.Message);
        }
        finally{
            connection.Close();
        }
        return lst;


    }
}