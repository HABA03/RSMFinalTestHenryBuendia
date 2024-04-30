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
	public class ProductRepository : IProductRepository
	{
		private FinalTestDbContext _context;

        public ProductRepository(FinalTestDbContext context)
        {
            _context = context;
        }

		public async Task<List<Product>> GetAllInformation()
		{
			var result = await _context.Set<Product>().Take(10).ToListAsync();
			return result;
		}
	}
}
