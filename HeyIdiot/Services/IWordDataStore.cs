using System;
using System.Threading.Tasks;

namespace HeyIdiot.Services
{
    public interface IWordDataStore
    {
        Task<string> SearchWordAsync(string word);
    }
}
