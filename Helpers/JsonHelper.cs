using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace FindRemoveSensitiveData.Helpers
{
    public static class JsonHelper
    {
        public static async Task<T> ReadFileAsync<T>(string filePath)
        {
            using var stream = File.OpenRead(filePath);
            return await JsonSerializer.DeserializeAsync<T>(stream);
        }
    }
}
