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
	public class CustomerRepository : ICustomerRepository
	{
		private FinalTestDbContext _context {  get; set; }

        public CustomerRepository(FinalTestDbContext context)
        {
            _context = context;
        }

        public async Task<List<Customer>> GetAllInformation()
		{
			var result = await _context.Set<Customer>().Take(20).ToListAsync();
			return result;
		}
	}
}
