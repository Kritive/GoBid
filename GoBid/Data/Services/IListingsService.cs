using GoBid.Models;
using System.Linq;
using System.Threading.Tasks;

namespace GoBid.Data.Services
{
    public interface IListingsService
    {
        IQueryable<Listing> GetAll();
        Task Add(Listing listing);
        Task<Listing> GetById(int? id);
        Task SaveChanges();
    }
}
