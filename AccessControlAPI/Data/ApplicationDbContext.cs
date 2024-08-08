using Microsoft.EntityFrameworkCore;

namespace AccessControlAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }
    }
}
