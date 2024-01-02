using Microsoft.EntityFrameworkCore;

// using MySQL.Data.Entity.Extensions; 
// using Microsoft.EntityFrameworkCore;
using BOL;

class CollectionContext:DbContext
{
    public DbSet<Product> Products{
        get;set;
    }

    // protected override void OnConfiguring(DbContextOptionsBuilder ob)
    // {
    //     string stringS=@"server=localhost; port=3306;user=root;password=welcome;database=dotnetpract";
        
    //     ob.UseMySQl(stringS);
    // }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conString=@"server=localhost;port=3306;user=root;password=welcome;database=dotnetpract";       
        optionsBuilder.UseMySQL(conString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>(entity=>{
            entity.HasKey(e=>e.ProductID);
            entity.HasKey(e=>e.ProductName );
        });
        modelBuilder.Entity<Product>().ToTable("products");

    }

}