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
}