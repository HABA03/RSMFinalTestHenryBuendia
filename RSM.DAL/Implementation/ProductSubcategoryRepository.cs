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
	public class ProductSubcategoryRepository : IProductSubcategoryRepository
	{
		private FinalTestDbContext _context;

        public ProductSubcategoryRepository(FinalTestDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProductSubcategory>> GetAllInformation()
		{
			var result = await _context.Set<ProductSubcategory>().Take(20).ToListAsync();
			return result;
		}
	}
}
