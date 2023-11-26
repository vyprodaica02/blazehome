using MudBlazorTemplates1.IServices;
using System.Net.Http;
using TodoList;
using TodoList.Entity;

namespace MudBlazorTemplates1.Services
{
    public class ApiUserServices : IApiUser
    {
        private readonly HttpClient _httpClient;
        public ApiUserServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task CreatUser(User user)
        {
            var apiUrl = "https://localhost:7286/api/User/creatUser";
            var response = await _httpClient.PostAsJsonAsync(apiUrl, user);
        }

        public async Task DeleteUser(int id)
        {
            var apiUrl = $"https://localhost:7286/api/User/Delete/id?id={id}";
            var response = await _httpClient.DeleteAsync(apiUrl);

        }

        public async Task<List<User>> GetDataUsers()
        {
            return await _httpClient.GetFromJsonAsync<List<User>>("https://localhost:7286/api/User/getFilter");
        }

        public async Task UpdateUser(User user)
        {
            var apiUrl = "https://localhost:7286/api/User/updateUser";
            var response = await _httpClient.PutAsJsonAsync(apiUrl, user);

        }
    }
}
