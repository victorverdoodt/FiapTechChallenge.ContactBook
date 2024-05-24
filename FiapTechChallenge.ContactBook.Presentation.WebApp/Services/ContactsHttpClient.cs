using FiapTechChallenge.ContactBook.Application.DTOs.Entities;
using FiapTechChallenge.ContactBook.Domain.Core.Models.Default;
using FiapTechChallenge.ContactBook.Presentation.WebApp.Helpers;

namespace FiapTechChallenge.ContactBook.Presentation.WebApp.Services
{
    public class ContactsHttpClient
    {
        private readonly HttpClient _httpClient;

        public ContactsHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PaginatedResponse<IEnumerable<ResponseContactDto>>> GetContactsAsync(FindContactsByRegionDTO dto)
        {
            var queryString = dto.ToQueryString();
            var url = string.IsNullOrEmpty(queryString) ? "api/contacts" : $"api/contacts?{queryString}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<PaginatedResponse<IEnumerable<ResponseContactDto>>>();
        }

        public async Task PostContactAsync(CreateContactDto contact)
        {
            var response = await _httpClient.PostAsJsonAsync("api/contacts", contact);
            response.EnsureSuccessStatusCode();
        }

        public async Task UpdateContactAsync(UpdateContactDto contact)
        {
            var response = await _httpClient.PutAsJsonAsync("api/contacts", contact);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteContactAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/contacts/{id}");
            response.EnsureSuccessStatusCode();
        }

        public async Task<Response<IEnumerable<ResponseRegionDto>>> GetRegionsAsync()
        {
            var response = await _httpClient.GetAsync("api/regions");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<Response<IEnumerable<ResponseRegionDto>>>();
        }
    }
}
