using BOL;
namespace DAL;

public class DBmanager:IDBmanager{
    public List<Product> Getall()
    {
        using (var context = new CollectionContext())
        {
            var prod=from ProductName in context.Products select ProductName;
            return prod.ToList<Product>();
        }
    }
    public string insert(Product ss)
    {
       
        using(var context =new CollectionContext())
        {
            context.Products.Add(ss);
            context.SaveChanges();

        }
        return "DATA INSERTED...";
    }

    public string update(Product ss)
    {
        // var s=ss.ProductID;
        using(var context=new CollectionContext()){
            
            var p=context.Products.Find(ss.ProductID);
           
            p.ProductName=ss.ProductName;
            

            context.SaveChanges();
        }
        return "DATA UPDATED...";
    }
    public void Delete(int id)
    {
        using(var context = new CollectionContext())
        {
            context.Products.Remove(context.Products.Find(id));
            context.SaveChanges();
        }
    }

}