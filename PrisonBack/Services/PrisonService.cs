using PrisonBack.Domain.Models;
using PrisonBack.Domain.Repositories;
using PrisonBack.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrisonBack.Services
{
    public class PrisonService : IPrisonService
    {
        private readonly IPrisonRepository _prisonRepository;
        public PrisonService(IPrisonRepository prisonRepository)
        {
            _prisonRepository = prisonRepository;
        }

        public void CreatePrison(Prison prison)
        {
            _prisonRepository.CreatePrison(prison);
        }
    }
}
