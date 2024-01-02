using DAL;
using BOL;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
IDBmanager bd=new DBmanager();
int ch=0;
while(ch!=5)
{
    Console.WriteLine("1. get all data\n2. insert new record\n3. updating existing record\n4. delete record\n5. exit..");
    ch=int.Parse(Console.ReadLine());
    switch (ch)
    {
        case 1:
            List<Product> allproducts = bd.Getall();
            foreach(var prod in allproducts)
            {
                Console.WriteLine("id:{0},   name:{1}",prod.ProductID,prod.ProductName);
            }
            Console.WriteLine("\n\n");
            break;

        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            Console.WriteLine("Thank you for staying with us....");
            break;
        default:
            break;
    }


}


