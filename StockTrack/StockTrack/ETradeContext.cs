using System.Data.Entity;

namespace StockTrack
{
    class ETradeContext:DbContext
    {
        public DbSet<Product> Products{ get; set; }
    }
}
