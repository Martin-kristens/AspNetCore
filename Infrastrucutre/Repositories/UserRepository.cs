using Infrastrucutre.Contexts;
using Infrastrucutre.Entities;
using Infrastrucutre.Factories;
using Infrastrucutre.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastrucutre.Repositories;

public class UserRepository(DataContext context) : BaseRepository<UserEntity>(context)
{
    private readonly DataContext _context = context;

    public override async Task<ResponseResult> GetAllAsync()
    {
        try
        {
            IEnumerable<UserEntity> result = await _context.Users
                .Include(i => i.Address) 
                .ToListAsync();

            return ResponseFactory.Ok(result);
        }
        catch (Exception ex)
        {
            return ResponseFactory.Error(ex.Message);
        }
    }

    public override async Task<ResponseResult> GetOneAsync(Expression<Func<UserEntity, bool>> predicate)
    {
        try
        {
            var result = await _context.Set<UserEntity>()
                .Include(i => i.Address)
                .FirstOrDefaultAsync(predicate);

            if (result == null)
            {
                return ResponseFactory.NotFound();
            }

            return ResponseFactory.Ok(result);
        }
        catch (Exception ex)
        {
            return ResponseFactory.Error(ex.Message);
        }
    }
}
