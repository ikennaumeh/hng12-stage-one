
using System.Net.Http;
using System;

namespace HNGStageOne.API.Repository
{
    public class FunFactRepository : IFunFactRepository
    {
        private readonly HttpClient httpClient;

        public FunFactRepository(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<string> GetFunFact(int number)
        {
            try
            {
                string url = $"http://numbersapi.com/{number}/math";
                return await httpClient.GetStringAsync(url);                
            }
            catch
            { 
                return "Fun fact not available";
            }
             
        }
    }
}
