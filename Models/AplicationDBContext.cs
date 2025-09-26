using Microsoft.EntityFrameworkCore;

namespace WebAppFormMVC.Models
{
    public class AplicationDBContext : DbContext
    {
        public AplicationDBContext(DbContextOptions<AplicationDBContext> options) 
            : base(options) { }

        public DbSet<ContactMessages> ContactMessages { get; set; }
    }
}
