using PrisonBack.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrisonBack.Domain.Repositories
{
    public interface IReasonRepository
    {
        Task<IEnumerable<Reason>> AllReasons();

    }
}
