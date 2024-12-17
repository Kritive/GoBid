using GoBid.Models;

namespace GoBid.Data.Services
{
    public interface ICommentsService
    {
        Task Add(Comment comment);
    }
}
