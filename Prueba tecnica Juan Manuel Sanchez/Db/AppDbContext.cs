using Microsoft.EntityFrameworkCore;
using Prueba_tecnica_Juan_Manuel_Sanchez.Models.UserModel;

namespace Prueba_tecnica_Juan_Manuel_Sanchez.Db
{
    public class AppDbContext : DbContext
    {
        public DbSet<CreateUserModel> UserModel { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
