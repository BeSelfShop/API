using Microsoft.EntityFrameworkCore;
using PrisonBack.Domain.Models;
using PrisonBack.Domain.Repositories;
using PrisonBack.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrisonBack.Persistence.Repositories
{
    public class CellTypeRepository : BaseRepository, ICellTypeRepository
    {
        public CellTypeRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<CellType>> AllCellType()
        {
            var cellType = _context.CellTypes.ToListAsync();
            return await cellType;
        }
    }
}
