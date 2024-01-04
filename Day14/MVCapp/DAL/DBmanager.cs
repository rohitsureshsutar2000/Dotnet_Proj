using bol;
namespace dal;

public class DBmanager{
    public static string conString=@"server=localhost;port=3306;user=root;password=welcome;database=dummy";

    public static List<Student> getalldata()
    {
        List<Student> lst=new List<Student>();
        MySqlConnection conn=new MySqlConnection();
        conn.ConnectionString=conString;
        string query=@"select * from students";
        try
        {
            MySqlCommand cmd=new MySqlCommand(query,conn);
            conn.Open();
            MySqlDataReader rd=cmd.ExecuteReader();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            conn.Close();
        }
        
    } 
}