using Microsoft.EntityFrameworkCore;
using API_Survival.Model;

namespace API_Survival.Data
{
    public class DataContext: DbContext
    {
        public DbSet<InventoryModel> Inventory { get; set; }

        public DataContext(DbContextOptions options): base(options)
        {

        }
    }
}
