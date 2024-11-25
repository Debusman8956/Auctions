using Auctions.Data;

namespace Auctions.Service
{
    public class ListingsService
    {
        private readonly ApplicationDbContext _context;

        public ListingsController(ApplicationDbContext context)
        {
            _context = context;
        }

    }
}
