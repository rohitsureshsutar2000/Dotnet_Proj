using BOJ;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
namespace dbmanagerUtil;


public static class BDmanager {

    public static int count()
    {
        MySqlConnection connection=new MySqlConnection();
        connection.ConnectionString="server=localhost;port=3306;user=root;password=welcome;database=riderpoint";
        int countVar=0;
        string query="select count(*) from rider_details";
        try
        {
            MySqlCommand cmd=new MySqlCommand(query,connection);
            connection.Open();
            countVar=int.Parse(cmd.ExecuteScalar().ToString());
            Console.WriteLine(countVar);
        }
        catch(Exception e)
        {
            
            Console.WriteLine(e.Message);
        }
        finally{
            connection.Close();
        }
        return countVar;
    }
    

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




    public static string Registration(string Name,string Email,string Mobile, string Address , string Username,string Password )
    {
        // int countvar=BDmanager.count()+1;
        List<RiderLogin> lst=new List<RiderLogin>();
        List<Rider_details> lst1=new List<Rider_details>();
        MySqlConnection connection=new MySqlConnection();
        connection.ConnectionString="server=localhost;port=3306;user=root;password=welcome;database=riderpoint";
        string query="insert into rider_details(name,mobile_no,address) values(@Name,@Mobile,@Address)";
        try
        {
          connection.Open();
          MySqlCommand cmd=new MySqlCommand(query,connection);
          
          cmd.Parameters.AddWithValue("@Name",Name);
          cmd.Parameters.AddWithValue("@Mobile",Mobile);
          cmd.Parameters.AddWithValue("@Address",Address);
          cmd.ExecuteNonQuery();
          return "data added";
        }
        catch(Exception e)
        {
            
            Console.WriteLine(e.Message);
        }
        finally{
            connection.Close();
        }
        return "";
    }
}