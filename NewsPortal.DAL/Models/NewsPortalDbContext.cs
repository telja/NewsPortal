using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NewsPortal.DAL.Models
{
    public class NewsPortalDbContext : IdentityDbContext<IdentityUser>
    {
        public NewsPortalDbContext(DbContextOptions<NewsPortalDbContext> options) : base(options) { }


    }
}
