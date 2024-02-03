using HireLATAM.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireLATAM.Application.Contracts.Persistence
{
    public interface IItemRepository : IGenericRepository<Item>
    {
    }
}
