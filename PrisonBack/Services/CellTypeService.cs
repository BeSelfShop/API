using PrisonBack.Domain.Models;
using PrisonBack.Domain.Repositories;
using PrisonBack.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrisonBack.Services
{
    public class CellTypeService : ICellTypeService
    {
        private readonly ICellTypeRepository _cellTypeRepository;
        public CellTypeService(ICellTypeRepository cellTypeRepository)
        {
            _cellTypeRepository = cellTypeRepository;
        }

        public Task<IEnumerable<CellType>> AllCellType()
        {
            return _cellTypeRepository.AllCellType();
        }
    }
}
