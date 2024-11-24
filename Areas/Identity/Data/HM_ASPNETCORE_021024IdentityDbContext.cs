using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HM_ASPNETCORE_021024.Areas.Identity.Data;

public class HM_ASPNETCORE_021024IdentityDbContext : IdentityDbContext<IdentityUser>
{
    public HM_ASPNETCORE_021024IdentityDbContext(DbContextOptions<HM_ASPNETCORE_021024IdentityDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
