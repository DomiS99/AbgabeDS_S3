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

        [HttpGet]
        public ResponseDTO Add (RequestDTO requestDTO)
        {
            return _mathService.Sum(requestDTO);
        }

        [HttpGet]
        public ResponseDTO Sub (RequestDTO requestDTO)
        {
            return _mathService.Sub(requestDTO);
        }

        [HttpGet]
        public RequestDTO Mult (RequestDTO requestDTO)
        {
            return _mathService.Mult(requestDTO);
        }
    }
}
