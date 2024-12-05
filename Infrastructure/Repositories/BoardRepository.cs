using Application.Common.Interfaces.Repositories;
using Domain.Entities;
using Domain.Persistence.Repositories;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class BoardRepository : EfBaseRepository<Board, AppDbContext>, IBoardRepository
    {
        public BoardRepository(AppDbContext appDbContext)
            : base(appDbContext)
        { }
    }
}
