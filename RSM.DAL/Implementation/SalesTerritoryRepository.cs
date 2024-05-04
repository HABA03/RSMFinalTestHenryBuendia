using Microsoft.EntityFrameworkCore;
using RSM.DAL.Context;
using RSM.DAL.Interface;
using RSM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.DAL.Implementation
{
	public class SalesTerritoryRepository : ISalesTerrirotyRepository
	{
		private FinalTestDbContext _context {  get; set; }

        public SalesTerritoryRepository(FinalTestDbContext context)
        {
            _context = context;
        }

        public async Task<List<SalesTerritory>> GetAllInformation()
		{
			var result = await _context.Set<SalesTerritory>().Take(20).ToListAsync();
			return result;
		}
	}
}
