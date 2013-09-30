using FluentAssertions;

using RestSharp;
using RestSharp.Injection;

using TechTalk.SpecFlow;

using _specs.Models;

namespace _specs.Steps
{
	[Binding]
	public class FactorySteps
	{
		private readonly RestSharpContext _restSharp;

		public FactorySteps(RestSharpContext restSharp)
		{
			_restSharp = restSharp;
		}

		[Given(@"I have a default RestSharp service factory")]
		public void CreateDefaultFactory()
		{
			_restSharp.Factory = new DefaultRestSharpFactory();
		}

		[When(@"I create a client with the URL ""(.*)""")]
		public void CreateClient(string url)
		{
			_restSharp.Client = _restSharp.Factory.CreateClient(url);
		}

		[When(@"I create a request with a specific (.+) and (.+)")]
		public void CreateRequest(Method method, string resource)
		{
			_restSharp.Request = _restSharp.Factory.CreateRequest(resource, method);
		}

		[Then(@"my client should be the default client type")]
		public void AssertClientType()
		{
			_restSharp.Client.Should().BeOfType<RestClient>();
		}

		[Then(@"my request should be the default request type")]
		public void AssertRequestType()
		{
			_restSharp.Request.Should().BeOfType<RestRequest>();
		}

		[Then(@"my client's URL should be ""(.*)""")]
		public void AssertClientUrl(string url)
		{
			_restSharp.Client.BaseUrl.Should().Be(url);
		}

		[Then(@"my request's method should be (.+)")]
		public void AssertRequestMethod(Method method)
		{
			_restSharp.Request.Method.Should().Be(method);
		}

		[Then(@"my request's resource should be (.+)")]
		public void AssertRequestResource(string resource)
		{
			_restSharp.Request.Resource.Should().Be(resource);
		}
	}
}