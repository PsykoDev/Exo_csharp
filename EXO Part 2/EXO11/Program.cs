using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace EXO11 {
    class Program {
        static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args) {

            HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos/1");
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);

        }

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Root {
            public int userId { get; set; }
            public int id { get; set; }
            public string title { get; set; }
            public bool completed { get; set; }
        }
    }
}


//MODIF
// recherche internet ok
// Result : print uniquement le titre 

/*
        delectus aut autem
*/