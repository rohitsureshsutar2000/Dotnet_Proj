using rider;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
namespace dbmanagerUtil;


public static class BDmanager
{
    public static bool valid()
    {
        List<RiderLogin> lst = new List<RiderLogin>();
        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString = "server=localhost;port=3306;user=root;password=welcome;database=riderpoint";
        string query = "select * from loginrider";
        try
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);

            connection.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int id = int.Parse(dr["id"].ToString());
                string username = dr["username"].ToString();
                string password = dr["password"].ToString();
                RiderLogin rs = new RiderLogin { Id = id, Username = username, Password = password };
                lst.Add(rs);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            connection.Close();
        }
        return (lst != null ? true : false);
    }
    public static List<RiderStatus> GetAlldetails()
    {
        List<RiderStatus> lst2 = new List<RiderStatus>();
        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString = "server=localhost;port=3306;user=root;password=welcome;database=riderpoint";
        string query = "select * from status";
        
        try
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);

            connection.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
                int status_id = int.Parse(dr["status_id"].ToString());
                int rider_id =int.Parse( dr["rider_id"].ToString());
                string bike = dr["bike"].ToString();
                string expense = dr["expense"].ToString();
                
                RiderStatus rs = new RiderStatus { Status_id = status_id, Rider_id = rider_id, Bike = bike, Expense = expense };
                lst2.Add(rs);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            connection.Close();
        }
        return lst2;
    }


}