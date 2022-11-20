using Microsoft.AspNetCore.Mvc;
using MyCompany.MathProgram.DTO;
using MyCompany.MathProgram.ServiceInterface;

namespace MyCompany.MathProgram.Controller
{
    [ApiController] // Zur Kompiltime fix
    [Route("[controller]")] //gibt die Rute/Pfat zum Controller durch vor ohne "controller"
    public class MathController :ControllerBase
    {
        private readonly IMathService _mathService; //Speichervariable für den MathController
        public MathController (IMathService mathService) //Zuweisung zum Interface, nur Methoden die im Interface definiert sind können verwendet werden
        {
            this._mathService = mathService;
        }

        [HttpGet("Add")] //"Add" beschriebt wie die Methode genannt wird im UI
        public ResponseDTO Add ([FromQuery] RequestDTO requestDTO) //From query benötig man bei get behlen die etwas ausgeben
        {
            return _mathService.Sum(requestDTO);
        }

        [HttpPost("Sub")]
        public ResponseDTO Sub (RequestDTO requestDTO)
        {
            return _mathService.Sub(requestDTO);
        }

        [HttpGet("Mult")]
        public RequestDTO Mult ([FromQuery] RequestDTO requestDTO)
        {
            return _mathService.Mult(requestDTO);
        }

        [HttpPost("Div")]
        public RequestDTO Div([FromQuery] RequestDTO requestDTO)
        {
            return _mathService.Div(requestDTO);
        }
    }
}
