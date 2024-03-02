using Infrastrucutre.Contexts;
using Infrastrucutre.Entities;
using Infrastrucutre.Factories;
using Infrastrucutre.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastrucutre.Repositories;

public class FeatureRepository(DataContext context) : BaseRepository<FeatureEntity>(context)
{
    private readonly DataContext _context = context;

    public override async Task<ResponseResult> GetAllAsync()
    {
        try
        {
            IEnumerable<FeatureEntity> result = await _context.Features
                .Include(i => i.FeaturesBoxes)
                .ToListAsync();

            return ResponseFactory.Ok(result);
        }
        catch (Exception ex)
        {
            return ResponseFactory.Error(ex.Message);
        }
    }
}
