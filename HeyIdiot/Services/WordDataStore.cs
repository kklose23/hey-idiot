using System.Net.Http;
using System.Threading.Tasks;
using HeyIdiot.Services;
using Xamarin.Forms;

namespace HeyIdiot.Services
{
  public class WordDataStore : IWordDataStore
  {
    private const string DictionaryEndpoint = "https://api.dictionaryapi.dev/api/v2/entries/en/";

    private readonly HttpClient _httpClient;

    public WordDataStore()
    {
      this._httpClient = DependencyService.Get<HttpClient>();
    }

    // https://dictionaryapi.dev
    public async Task<string> SearchWordAsync(string word)
    {
      var searchEndpoint = DictionaryEndpoint + word;

      var response = await this._httpClient.GetAsync(searchEndpoint);

      //response.EnsureSuccessStatusCode();
      var responseBody = await response.Content.ReadAsStringAsync();

      return responseBody;
    }

  }
}
