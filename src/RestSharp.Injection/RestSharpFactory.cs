using System;

namespace RestSharp.Injection
{
	/// <summary>
	///    Provides a Dependency Inversion-based implementation of <see cref="IRestSharpFactory" />.
	/// </summary>
	public class RestSharpFactory : IRestSharpFactory
	{
		private readonly Func<string, IRestClient> _clientCreator;
		private readonly Func<string, Method, IRestRequest> _requestCreator;

		/// <summary>
		/// Initializes a new instance of the <see cref="RestSharpFactory"/> class.
		/// </summary>
		/// <param name="clientCreator">The client creator.</param>
		/// <param name="requestCreator">The request creator.</param>
		public RestSharpFactory(Func<string, IRestClient> clientCreator, Func<string, Method, IRestRequest> requestCreator)
		{
			_clientCreator = clientCreator;
			_requestCreator = requestCreator;
		}

		/// <summary>
		///    Creates the client.
		/// </summary>
		/// <param name="url">The URL.</param>
		public IRestClient CreateClient(string url)
		{
			return _clientCreator(url);
		}

		/// <summary>
		///    Creates the request.
		/// </summary>
		/// <param name="resource">The resource.</param>
		/// <param name="method">The method.</param>
		public IRestRequest CreateRequest(string resource, Method method)
		{
			return _requestCreator(resource, method);
		}
	}
}