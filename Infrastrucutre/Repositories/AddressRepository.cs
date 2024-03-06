using Infrastrucutre.Contexts;
using Infrastrucutre.Entities;

namespace Infrastrucutre.Repositories;

public class AddressRepository(DataContext context) : BaseRepository<AddressEntity>(context)
{
    private readonly DataContext _context = context;


}
