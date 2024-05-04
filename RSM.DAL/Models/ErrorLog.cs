using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.DAL.Models
{
	public class ErrorLog
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(255)]
		public string ErrorType { get; set; }

		[Required]
		public string ErrorMessage { get; set; }

		public string Location { get; set; }

		public string StackTrace { get; set; }

		[MaxLength(100)]
		public string AffectedUser { get; set; }

		[MaxLength(255)]
		public string ApplicationContext { get; set; }

		[MaxLength(255)]
		public string RequestId { get; set; }

		[MaxLength(50)]
		public string SeverityLevel { get; set; }

		[MaxLength(50)]
		public string ApplicationVersion { get; set; }

		[Required]
		public DateTime Timestamp { get; set; }
	}
}
