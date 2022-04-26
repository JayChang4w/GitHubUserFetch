using Microsoft.Net.Http.Headers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;

using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GitHubUserFetch.Service.Tests
{
    [TestClass()]
    public class GitHubAPIServiceTests
    {
        [TestMethod()]
        public async Task GetUsersAsyncTest()
        {
            using var httpClient = new HttpClient();

            httpClient.BaseAddress = new Uri("https://api.github.com/");

            // using Microsoft.Net.Http.Headers;
            // The GitHub API requires two headers.
            httpClient.DefaultRequestHeaders.Add(
                HeaderNames.Accept, "application/vnd.github.v3+json");
            httpClient.DefaultRequestHeaders.Add(
                HeaderNames.UserAgent, "HttpRequestsSample");

            var mockFactory = new Mock<IHttpClientFactory>();

            mockFactory.Setup(factory => factory.CreateClient(It.IsAny<string>()))
                       .Returns(httpClient);

            IGitHubAPIService gitHubUserService = new GitHubAPIService(mockFactory.Object);

            var result = await gitHubUserService.GetUsersAsync(new Model.GitHubUserRequest() { Since = 30});

            //Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());
        }
    }
}