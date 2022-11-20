using Microsoft.AspNetCore.Mvc;
using MyCompany.MathProgram.DTO;
using MyCompany.MathProgram.DTO.QuickType;
using MyCompany.MathProgram.ServiceInterface;

namespace MyCompany.MathProgram.Controller
{

        [ApiController]
        [Route("[controller]")]
        public class DictionaryController : ControllerBase
        {
        private readonly IDictionaryService _dictionaryService;

        public DictionaryController (IDictionaryService dictionaryService)
        {
            this._dictionaryService = dictionaryService;
        }

        [HttpGet]
        public DictionaryDTO Get([FromQuery]string word)
        {
            return _dictionaryService.Get(word);
        }
    }
           

    
}
