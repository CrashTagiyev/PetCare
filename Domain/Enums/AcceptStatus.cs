using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
	public enum Acceptstatus
	{
		[Description("Your request is accepted")]
		Accepted=1,
		[Description("Your request is pending right now")]
		Pending,
		[Description("Your request is denied")]
		Denied
	}
}
