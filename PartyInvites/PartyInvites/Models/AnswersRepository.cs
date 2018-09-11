using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
	public class AnswersRepository
	{
		private static List<GuestInfo> responses = new List<GuestInfo>();

		public static IEnumerable<GuestInfo> Responses
		{
			get
			{
				return responses;
			}			
		}

		public static void AddResponse(GuestInfo response)
		{
			if (response != null)
				responses.Add(response);
		}
	}
}
