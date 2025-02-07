using Microsoft.EntityFrameworkCore;
using SQLControllerTest.Models;

namespace SQLControllerTest.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Potato> Potatoes { get; set; }
    }
}
