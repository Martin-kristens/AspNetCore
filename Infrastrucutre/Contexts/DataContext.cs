using Infrastrucutre.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastrucutre.Contexts;

public class DataContext(DbContextOptions<DataContext> options) : IdentityDbContext<UserEntity>(options) 
{
    public DbSet<AddressEntity> Addresses { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<AddressEntity>()
           .HasMany(x => x.Users)
           .WithOne(x => x.Address)
           .HasForeignKey(x => x.AddressId)
           .OnDelete(DeleteBehavior.Restrict);
    }
}
