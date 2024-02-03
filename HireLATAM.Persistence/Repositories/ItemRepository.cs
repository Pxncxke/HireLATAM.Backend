using HireLATAM.Application.Contracts.Persistence;
using HireLATAM.Domain.Models;
using HireLATAM.Persistence.DataBaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireLATAM.Persistence.Repositories
{
    public class ItemRepository : GenericRepository<Item>, IItemRepository
    {
        public ItemRepository(HireLATAMDbContext context) : base(context)
        {
        }
    }
}
