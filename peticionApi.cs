using System;
using RestSharp;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Peticion();
            Console.Read();
        }
        
        static async void Peticion()
        {
            var cliente = new RestClient("https://dog.ceo/api/breeds/list/all");
            var request = new RestRequest();
            RestResponse response = await cliente.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }
    }
}
