﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.EN.DTO.Person.Search
{
	public class SearchPersonResponse
	{
		public int BusinessEntityID { get; set; }
		public string PersonType { get; set; }
		public string? Title { get; set; }
		public string FirstName { get; set; }
		public string? MiddleName { get; set; }
		public string LastName { get; set; }
		public string? Suffix { get; set; }
		public int EmailPromotion { get; set; }
		public Guid rowguid { get; set; }
		public DateTime ModifiedDate { get; set; }
	}
}
