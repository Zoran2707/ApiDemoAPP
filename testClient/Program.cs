// See https://aka.ms/new-console-template for more information

using System.Net.Http.Headers;
using System.Net.Http.Json;
using testClient;

HttpClient client = new();
client.BaseAddress = new Uri("https://localhost:7034");
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

HttpResponseMessage response = await client.GetAsync("api/Supliers");
response.EnsureSuccessStatusCode();

if (response.IsSuccessStatusCode)
{
    var supliers = await response.Content.ReadFromJsonAsync < IEnumerable < SuplierDto >> ();
    foreach(var s in supliers)
    {
        Console.WriteLine(s.CompanyName + "  " + s.ContactName + "  " + s.Address);
    }
}
else
{
    Console.WriteLine("No results");
}

Console.ReadLine();


