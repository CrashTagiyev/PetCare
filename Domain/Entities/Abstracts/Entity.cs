using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Abstracts
{
	public abstract class Entity : IBaseEntity
	{
		public int Id { get; set; }
		public DateTime CreatedTime { get; set; } = DateTime.Now;
		public DateTime LastUpdatedTime { get; set; }
		public bool IsDeleted { get; set; }=false;

	}
}
