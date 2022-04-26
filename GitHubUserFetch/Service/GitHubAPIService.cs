using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using GitHubUserFetch.Model;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.WebUtilities;

namespace GitHubUserFetch.Service
{
    public interface IGitHubAPIService
    {
        /// <summary>
        /// Lists all users, in the order that they signed up on GitHub.
        /// This list includes personal user accounts and organization accounts.
        /// </summary>
        /// <seealso cref="https://docs.github.com/en/rest/users/users#list-users"/>
        /// <returns></returns>
        Task<List<GitHubUserResponse>> GetUsersAsync(GitHubUserRequest request = null);
    }

    public class GitHubAPIService : IGitHubAPIService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public GitHubAPIService(IHttpClientFactory httpClientFactory)
        {
            this._httpClientFactory = httpClientFactory;
        }

        /// <summary>
        /// Lists all users, in the order that they signed up on GitHub.
        /// This list includes personal user accounts and organization accounts.
        /// </summary>
        /// <seealso cref="https://docs.github.com/en/rest/users/users#list-users"/>
        /// <returns></returns>
        public async Task<List<GitHubUserResponse>> GetUsersAsync(GitHubUserRequest request = null)
        {
            var result = new List<GitHubUserResponse>();

            HttpClient httpClient = this._httpClientFactory.CreateClient("GitHub");

            string requestUri = "users";

            if (request != null)
            {
                var queryParams = request.GetQueryStringDict();

                requestUri = $"/users{QueryString.Create(queryParams)}";
            }

            var httpResponseMessage = await httpClient.GetAsync(requestUri);

            httpResponseMessage.EnsureSuccessStatusCode();

            using Stream contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();

            result = await JsonSerializer.DeserializeAsync<List<GitHubUserResponse>>(contentStream);

            return result;
        }
    }
}
