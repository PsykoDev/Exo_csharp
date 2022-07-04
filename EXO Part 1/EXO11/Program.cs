using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace EXO11 {
    class Program {
        static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args) {

            HttpResponseMessage response = await client.GetAsync("http://www.perdu.com/");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);

        }
    }
}


//MODIF
// recherche internet ok
// Result : 

/*
        Server: Apache
        Upgrade: h2
        Connection: Upgrade
        ETag: "cc-5344555136fe9"
        Accept-Ranges: bytes
        Cache-Control: max-age=600
        Vary: Accept-Encoding,User-Agent
*/