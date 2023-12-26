using MySql.Data.MySqlClient;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


MySqlConnection connection=new MySqlConnection();
connection.ConnectionString="server=localhost;port=3306;user=root;password=welcome;database=dotnetPract";   //CURD
if(connection!=null )
{
    Console.WriteLine(" Connecction Successfull");
}

// string query="create table testing(id int,name varchar(20))";     // create table
// string query="update emp set ename='sayali' where empno=6001";    // update table
string query="select empno,ename from emp";                         // read table
// string query="delete from emp where empno=7840";                 // Delete data
MySqlCommand command=new MySqlCommand(query,connection);

try
{
    connection.Open();

    
    // command.ExecuteReader();                             =DDL command            // create
    // command.ExecuteNonQuery();               //          =DML command            //  update
    MySqlDataReader reader=command.ExecuteReader();     //  =DDl command            // read
            while(reader.Read())
            {
                Console.Write(reader["empno"].ToString()+" ");
                Console.WriteLine(reader["ename"].ToString());
            }
    // command.ExecuteNonQuery();           =DML command           //  delete
}
catch (Exception e) 
{
    Console.WriteLine(e.Message);
}
finally{
    connection.Close();
}