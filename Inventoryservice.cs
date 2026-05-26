using System.Net.Http.Json;
using InventoryHub.BlazorUI.Models;

namespace InventoryHub.BlazorUI.Services
{
    public class InventoryService
    {
        private readonly HttpClient _httpClient;

        public InventoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<InventoryItem>> GetItems()
        {
            return await _httpClient.GetFromJsonAsync<List<InventoryItem>>("api/inventory")
                   ?? new List<InventoryItem>();
        }

        public async Task AddItem(InventoryItem item)
        {
            await _httpClient.PostAsJsonAsync("api/inventory", item);
        }
    }
}
