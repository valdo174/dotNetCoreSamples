using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace LanguageFeatures.Models
{
	public static class MyAsyncMethods
	{
		public static Task<long?> GetPageLength()
		{
			var client = new HttpClient();
			var httpTask = client.GetAsync("http://apress.com");

			return httpTask.ContinueWith((Task<HttpResponseMessage> antecedent) =>
			 {
				 return antecedent.Result.Content.Headers.ContentLength;
			 });
		}

		public async static Task<long?> GetPageLengthAsync()
		{
			var client = new HttpClient();
			var response = await client.GetAsync("http://apress.com");

			return response.Content.Headers.ContentLength;
		}
	}
}
