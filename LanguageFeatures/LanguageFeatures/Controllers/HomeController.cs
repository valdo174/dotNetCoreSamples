using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers
{
	public class HomeController : Controller
	{
		public async Task<long?> Index()
		{
			long? contentLength = await MyAsyncMethods.GetPageLength();

			return contentLength;
		}
	}
}
