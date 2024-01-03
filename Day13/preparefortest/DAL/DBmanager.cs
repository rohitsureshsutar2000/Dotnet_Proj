namespace dal;
using models;
using MySql.Data.MySqlClient;
using System.Collections.Generics;

static class  DBmanager{
   public static List<Pillion_details> getall(){
        MySqlConnection conn=new MySqlConnection();
        conn.ConnectionString="server=localhost;port:3306;user=root;password=welcome;database=riderpoint";
        string query="select *from pillion_details";
        try{
            MySqlCommand cmd =new MySqlCommand(query,conn);
            conn.Open();
            MySqlDataReader dr=cmd.ExecuteReader();
            while(dr.Read())
            {
                
            }
        }
   }
}