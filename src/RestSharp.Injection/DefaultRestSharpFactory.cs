namespace RestSharp.Injection
{
	/// <summary>
	///    Provides a default implementation of <see cref="IRestSharpFactory" />.
	/// </summary>
	public class DefaultRestSharpFactory : IRestSharpFactory
	{
		/// <summary>
		///    Creates the client.
		/// </summary>
		/// <param name="url">The URL.</param>
		public IRestClient CreateClient(string url)
		{
			return new RestClient(url);
		}

		/// <summary>
		///    Creates the request.
		/// </summary>
		/// <param name="resource">The resource.</param>
		/// <param name="method">The method.</param>
		public IRestRequest CreateRequest(string resource, Method method)
		{
			return new RestRequest(resource, method);
		}
	}
}