﻿using RSM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.DAL.Interface
{
	public interface IProductRepository
	{
		Task<List<Product>> GetAllInformation();
	}
}
