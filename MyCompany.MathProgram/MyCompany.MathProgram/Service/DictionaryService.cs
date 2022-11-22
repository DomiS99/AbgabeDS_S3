using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCompany.MathProgram.ServiceInterface;
using Newtonsoft.Json;
using System;
using System.ComponentModel.Design;
using System.Net.Http;
using IDictionaryService = MyCompany.MathProgram.ServiceInterface.IDictionaryService;

namespace MyCompany.MathProgram.Service
{
    [ApiController]
    [Route("[controller]")]
    public class DictionaryService : IDictionaryService
    {
        public DictionaryService GetWord(string Word)
        {
            var httpRequest = new HttpRequestMessage();
            httpRequest.Method = HttpMethod.Get;
            httpRequest.RequestUri = new Uri($"https://api.dictionaryapi.dev/api/v2/entries/en/{Word}");

            var httpClient = new HttpClient();
            var httpResponse = httpClient.Send(httpRequest);
            var message = httpResponse.Content.ReadAsStringAsync().Result;
            var WordResult = JsonConvert.DeserializeObject<DictionaryService>(message);
            return WordResult;
        }
    }
}
