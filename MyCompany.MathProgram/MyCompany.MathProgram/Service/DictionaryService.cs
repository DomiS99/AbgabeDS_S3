


namespace MyCompany.MathProgram.Service;


    using Newtonsoft.Json;
    using System;
    using System.Net.Http;

    public class DictionaryService : MyCompany.MathProgram.ServiceInterface.IDictionaryService
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

