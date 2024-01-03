using BOL;
namespace DAL;

public interface IDBmanager{
    List<Product> Getall();
    string insert(Product ss);
    string update(Product ss);
    void Delete(int id);
}