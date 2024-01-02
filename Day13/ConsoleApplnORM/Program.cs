using DAL;
using BOL;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
IDBmanager bd=new DBmanager();
List<Product> allproducts = bd.Getall();
foreach(var prod in allproducts)
{
    Console.WriteLine("id:{0},name:{1}",prod.ProductID,prod.ProductName);
}