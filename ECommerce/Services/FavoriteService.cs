using ECommerce.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Services
{
    public class FavoriteService : IFavorite
    {
        private readonly ApplicationDbContext _context;

        public FavoriteService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddFavorite(Favorite favorite)
        {
            _context.Add(favorite);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Favorite> GetByUserId(string userId) =>
            _context.Favorits.Where(x => x.UserId == userId);

        public IEnumerable<Favorite> GetFavorites() =>
            _context.Favorits;

        public async Task RemoveFavorite(Favorite favorite)
        {
            _context.Remove(favorite);
            await _context.SaveChangesAsync();
        }

        public Favorite GetByUserIdAndProductId(string userId, int productId)=>
            _context.Favorits.Where(x => x.UserId == userId && x.ProductId == productId).FirstOrDefault();

        public Favorite GetByProductId(int id) =>
            GetFavorites().Where(x => x.ProductId == id).FirstOrDefault();
    }
}
