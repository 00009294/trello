using Domain.Entities;
using Domain.Persistence.Repositories;

namespace Application.Common.Interfaces.Repositories
{
    public interface IBoardRepository : IAsyncRepository<Board>
    {
    }
}
