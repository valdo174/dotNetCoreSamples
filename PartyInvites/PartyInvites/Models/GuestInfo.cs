using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class GuestInfo
    {
		public string Name { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public bool? WillAttend { get; set; }
    }
}
