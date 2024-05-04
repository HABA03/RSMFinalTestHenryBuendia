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
	public class SalesOrderDetailRepository : ISalesOrderDetailRepository
	{
		private FinalTestDbContext _context { get; set; }

        public SalesOrderDetailRepository(FinalTestDbContext context)
        {
            _context = context;
        }

        public async Task<List<SalesOrderDetail>> GetAllInformation()
		{
			var result = await _context.Set<SalesOrderDetail>().Take(10).ToListAsync();
			return result;
		}
	}
}
