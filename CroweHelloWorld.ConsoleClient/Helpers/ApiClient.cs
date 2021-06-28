using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CroweHelloWorld.ConsoleClient.Helpers
{
    public static class ApiClient
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<string> GetMessage(string controller)
        {
            client.DefaultRequestHeaders.Accept.Clear();

            var test = await client.GetStringAsync($"http://localhost:9798/api/{controller}/GetMessage");

            return test;
        }
    }
}
