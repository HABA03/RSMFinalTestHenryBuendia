using RSM.DAL.Context;
using RSM.DAL.Interface;
using RSM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RSM.DAL.Implementation
{
	public class SalesOrderHeaderRepository : ISalesOrderHeaderRepository
	{
		private FinalTestDbContext _context { get; set; }

        public SalesOrderHeaderRepository(FinalTestDbContext context)
        {
            _context = context;
        }

        public async Task<List<SalesOrderHeader>> GetAllInformation()
		{
			var result = await _context.Set<SalesOrderHeader>().Take(10).ToListAsync();
			return result;
		}
	}
}
