using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Abstracts
{
	public interface IBaseEntity
	{
		
		public DateTime CreatedTime { get; set; } 
		public DateTime LastUpdatedTime { get; set; }
		public bool IsDeleted { get; set; } 
	}
}
