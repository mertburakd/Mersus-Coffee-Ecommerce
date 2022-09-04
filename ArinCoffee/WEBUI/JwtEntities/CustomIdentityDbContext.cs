using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WEBUI.JwtEntities
{
    public class CustomIdentityDbContext:IdentityDbContext<CustomIdentityUser,CustomIdentityRole,int>
    {
        public CustomIdentityDbContext(DbContextOptions<CustomIdentityDbContext> options):base(options)
        {
            //this.Database.EnsureCreated();

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
    }
}
