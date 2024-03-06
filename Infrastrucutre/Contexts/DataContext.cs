using Infrastrucutre.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastrucutre.Contexts;

public class DataContext(DbContextOptions<DataContext> options) : IdentityDbContext<UserEntity>(options) 
{
    public DbSet<AddressEntity> Addresses { get; set; }
    
    public DbSet<FeatureEntity> Features { get; set; }
    public DbSet<FeatureBoxEntity> FeatureBoxes { get; set; }
}
