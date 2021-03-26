using PrisonBack.Domain.Models;
using PrisonBack.Domain.Repositories;
using PrisonBack.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrisonBack.Services
{
    public class ReasonService : IReasonService
    {
        private readonly IReasonRepository _reasonRepository;
        public ReasonService(IReasonRepository reasonRepository)
        {
            _reasonRepository = reasonRepository;
        }

        public async Task<IEnumerable<Reason>> AllReasons()
        {
            return await _reasonRepository.AllReasons();
        }
    }
}
