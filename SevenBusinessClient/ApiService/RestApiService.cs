using Newtonsoft.Json;
using System;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MotherStoreBusiness.ApiService
{
    public class RestApiService
    {
        private readonly HttpClient _httpClient;

        public RestApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        private async Task<TResult> ExecuteWithHandlingAsync<TResult>(Func<Task<TResult>> operation, string operationName)
        {
            try
            {
                return await operation();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Erreur lors de l'opération {operationName}: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Une erreur inattendue est survenue lors de l'opération {operationName}.", ex);
            }
        }

        private async Task ExecuteWithHandlingAsync(Func<Task> operation, string operationName)
        {
            try
            {
                await operation();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Erreur lors de l'opération {operationName}: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Une erreur inattendue est survenue lors de l'opération {operationName}.", ex);
            }
        }

        // Exemple d'utilisation pour les méthodes CRUD
        public  async Task<List<TModel>> GetAllDataAsync<TModel>(string path) where TModel : class
        {
            return await ExecuteWithHandlingAsync(async () =>
            {
                string response = await _httpClient.GetStringAsync(path);
                return JsonConvert.DeserializeObject<List<TModel>>(response) ?? new List<TModel>();
            }, "GetAllData");
        }

        public async Task<TModel> GetDataAsync<TModel>(string path) where TModel : class
        {
            return await ExecuteWithHandlingAsync(async () =>
            {
                string response = await _httpClient.GetStringAsync(path);
                return JsonConvert.DeserializeObject<TModel>(response) ?? throw new Exception("L'objet récupéré est nul.");
            }, "GetData");
        }

        public async Task<bool> PostDataAsync<TModel>(string path, TModel model) where TModel : class
        {
            return await ExecuteWithHandlingAsync(async () =>
            {
                var response = await _httpClient.PostAsJsonAsync(path, model);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Code de statut incorrect : {response.StatusCode}");
                }return response.IsSuccessStatusCode;
            }, "PostData");
        }

        public async Task<bool> PutDataAsync<TModel>(string path, TModel model) where TModel : class
        {
            return  await ExecuteWithHandlingAsync(async () =>
            {
                var response = await _httpClient.PutAsJsonAsync(path, model);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Code de statut incorrect : {response.StatusCode}");
                }
                return response.IsSuccessStatusCode;
            }, "PutData");
        }

        public async Task<bool> DeleteDataAsync<TModel>(string path) where TModel : class
        {
            return await ExecuteWithHandlingAsync(async () =>
            {
                var response = await _httpClient.DeleteAsync(path);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Code de statut incorrect : {response.StatusCode}");
                } return response.IsSuccessStatusCode;
            }, "DeleteData");
        }
    }
}
