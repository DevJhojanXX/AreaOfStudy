using ConversorDivisasConsole.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConversorDivisasConsole.Conn
{
    public class Connect
    {
        public string? ApiKey { get; set; }
        public string? EndPoint { get; set; }

        HttpClient client = new HttpClient();
        private string _responseBody;
        private Divisa _divisa;
        public async Task<Divisa?> GET()
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", ApiKey);

            var response = await client.GetAsync(EndPoint);
            try
            {
                _responseBody = await response.Content.ReadAsStringAsync();
                _divisa = JsonSerializer.Deserialize<Divisa>(_responseBody);
                return _divisa;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error the respuesta {response.StatusCode}, \n The Exception = {ex}");
                return _divisa;
            }
        }
    }
}

