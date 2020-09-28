using ECommerce.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce.Services
{
    public interface IFavorite
    {
        IEnumerable<Favorite> GetFavorites();

        Task AddFavorite(Favorite favorite);
    }
}
