
using TalentoTrack.Common.Entities;

namespace TalentoTrack.Common.Repositories
{
    public interface IAccountRepository
    {
        Task<LoginDetails> GetLoginDetails(string username, string password);
    }
}
