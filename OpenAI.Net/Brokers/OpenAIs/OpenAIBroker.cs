using OpenAI.Net.Models;
using RESTFulSense.Clients;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace OpenAI.Net.Brokers.OpenAIs
{
    internal partial class OpenAIBroker : IOpenAIBroker
    {
        private readonly ApiConfigurations apiConfigurations;
        private readonly HttpClient httpClient;
        private readonly IRESTFulApiFactoryClient apiClient;

        public OpenAIBroker(ApiConfigurations apiConfigurations)
        {
            this.apiConfigurations = apiConfigurations;
            this.httpClient = SetupHttClient();
            this.apiClient = SetupApiClient();
        }

        public async ValueTask<T> GetAsync<T>(string relativeUrl) => 
            await this.apiClient.GetContentAsync<T>(relativeUrl);

        public async ValueTask<T> PostAsync<T>(string relativeUrl, T content) =>
            await this.apiClient.PostContentAsync<T>(relativeUrl, content);

        public async ValueTask<TResult> PostAsync<TRequest,TResult>(string relativeUrl, TRequest content) =>
            await this.apiClient.PostContentAsync<TRequest, TResult>(relativeUrl, content,"application/json");

        public async ValueTask<T> PutAsync<T>(string relativeUrl, T content) =>
           await this.apiClient.PutContentAsync<T>(relativeUrl, content);

        public async ValueTask<T> DeleteAsync<T>(string relativeUrl) =>
           await this.apiClient.DeleteContentAsync<T>(relativeUrl);

        private HttpClient SetupHttClient()
        {
            var httpClient = new HttpClient()
            {

                BaseAddress =
                    new Uri(uriString: this.apiConfigurations.ApiUrl)
            };

            httpClient.DefaultRequestHeaders.Authorization = 
                new AuthenticationHeaderValue(
                    scheme:"Bearer", 
                    parameter: this.apiConfigurations.ApiKey);

            httpClient.DefaultRequestHeaders.Add(
                name: "OpenAI-Organization",
                value: this.apiConfigurations.OrganisationId );

            return httpClient;
        }

        private IRESTFulApiFactoryClient SetupApiClient() => new RESTFulApiFactoryClient(this.httpClient);
    }
}
