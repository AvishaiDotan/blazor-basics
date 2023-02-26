//using VeggieFarmer.Shared;
//using static System.Net.WebRequestMethods;

namespace VeggieFarmer.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _http;

        public List<Category> Categories { get; set; } = new List<Category>();

        public CategoryService(HttpClient Http)
        {
            _http = Http;
        }

        public async Task GetCategories()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/category");

            if (result != null && result.Data != null) Categories = result.Data;
        }
    }
}
