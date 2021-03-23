using PrisonBack.Domain.Models;
using PrisonBack.Domain.Repositories;
using PrisonBack.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrisonBack.Persistence.Repositories
{
    public class PrisonRepository : BaseRepository, IPrisonRepository
    {
        public PrisonRepository(AppDbContext context) : base(context)
        {

        }


        public void CreatePrison(Prison prison)
        {
            if (prison != null)
            {
                _context.Add(prison);
                _context.SaveChanges();
            }
        }
    }
}
