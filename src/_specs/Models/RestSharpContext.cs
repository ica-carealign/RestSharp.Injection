using RestSharp;
using RestSharp.Injection;

namespace _specs.Models
{
	public class RestSharpContext
	{
		public IRestSharpFactory Factory { get; set; }

		public IRestClient Client { get; set; }

		public IRestRequest Request { get; set; }
	}
}