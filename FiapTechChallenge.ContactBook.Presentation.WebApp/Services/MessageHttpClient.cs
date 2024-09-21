using FiapTechChallenge.ContactBook.Application.DTOs.Contracts;

namespace FiapTechChallenge.ContactBook.Presentation.WebApp.Services
{
    public class MessageHttpClient
    {
        private readonly HttpClient _httpClient;
        public MessageHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task PostMessageAsync(MessageContractDto contact)
        {
            var response = await _httpClient.PostAsJsonAsync("api/message", contact);
            response.EnsureSuccessStatusCode();
        }
    }
}
