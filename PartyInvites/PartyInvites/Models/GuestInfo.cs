using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class GuestInfo
    {
		[Required(ErrorMessage = "Please enter your name")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Please enter your phone")]
		public string Phone { get; set; }

		[Required(ErrorMessage = "Please enter your e-mail")]
		[RegularExpression(".+\\@.+\\..+", ErrorMessage = "Enter a valid e-mail")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Please specify whether you'll attend")]
		public bool? WillAttend { get; set; }
    }
}
