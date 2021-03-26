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
    public class ReasonRepository : BaseRepository, IReasonRepository
    {

        public ReasonRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Reason>> AllReasons()
        {
            var reason = _context.Reasons.ToListAsync();
            return await reason;
        }
    }
}
