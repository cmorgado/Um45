using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Um45.Code;
using Um45.Models.Rest;

namespace Um45.Services
{
   public class MiniGitHubClient
    {
        private readonly HttpClient _client = new HttpClient();
        public string BaseUrl { get; set; } = "https://api.github.com";

        public MiniGitHubClient()
        {
            _client.DefaultRequestHeaders.Add("User-Agent", "xamarin-um45");
        }

        public async Task<RestResult<SearchResults>> Search(string query)
        {
            return await DoHttpGet<SearchResults>($"/search/users?q={query}");
        }

        public async Task<RestResult<UserDetails>> UserDetails(string login)
        {
            return await DoHttpGet<UserDetails>($"/users/{login}");
        }

        private async Task<RestResult<T>> DoHttpGet<T>(string url)
        {
            var r = new RestResult<T>();

            var response = new HttpResponseMessage();
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, new Uri(BaseUrl + url, UriKind.RelativeOrAbsolute));

             

                response = await _client.SendAsync(request);
                switch (response.StatusCode)
                {
                    case HttpStatusCode.OK:
                        {
                            var content = await response.Content.ReadAsStringAsync();
                            r.Error = new Error { HasError = false };
                            ExtractResponse(r, content);
                        }
                        break;
                    case HttpStatusCode.BadRequest:
                        {
                            var content = await response.Content.ReadAsStringAsync();
                            r.Error = new Error
                            {
                                HasError = true,
                                ErrorCode = response.StatusCode.ToString()
                            };
                            r.Data = content.FromJson<T>();
                        }
                        break;
                    default:
                        r.Error.HasError = true;

                        r.Error.Message = $"http error: {response.StatusCode}";
                        r.Error.ErrorCode = response.StatusCode.ToString();
                        r.Raw = await response.Content.ReadAsStringAsync();
                        break;
                }
            }
            catch (HttpRequestException hex)
            {
                SetHttpError(r, hex, response);
            }
            catch (Exception ex)
            {
                SetUnhandledError(r, ex);
            }
            return r;
        }


        private static void SetUnhandledError<T>(RestResult<T> r, Exception ex)
        {
            r.Error.HasError = true;
            r.Error.Message = $"http error: {ex.Message}";
            r.Error.Type = ErrorType.Other;
        }

        private static void SetHttpError<T>(RestResult<T> r, HttpRequestException hex, HttpResponseMessage response)
        {
            r.Error.HasError = true;
            r.Error.Message = $"http error: {hex.Message}";
            r.Error.ErrorCode = response.StatusCode.ToString();
            r.Error.Type = ErrorType.Http;
        }


        private static void ExtractResponse<T>(RestResult<T> r, string content)
        {
            if (typeof(T) != typeof(string))
                r.Data = content.FromJson<T>();
            else
                r.Raw = content;
        }
    }
}
