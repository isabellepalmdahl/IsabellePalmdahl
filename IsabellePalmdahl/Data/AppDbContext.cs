using Microsoft.EntityFrameworkCore;
using IsabellePalmdahl.Models.POCOs;

namespace IsabellePalmdahl.Data
{
	public class AppDbContext : DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Client> Clients { get; set; }
    }
}
