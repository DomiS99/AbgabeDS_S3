using Microsoft.AspNetCore.Mvc;
using MyCompany.MathProgram.ServiceInterface;

namespace MyCompany.MathProgram.Controller
{
    [ApiController] // Zur Kompiltime fix
    [Route("[controller]")] //gibt die Rute/Pfat zum Controller durch vor ohne "controller"
    public class MathController :ControllerBase
    {
        private readonly IMathService _mathService;
        public MathController (IMathService mathService)
        {
            this._mathService = mathService;
        }

        [HttpGet]
        public double Add (double zahl1, double zahl2)
        {
            return this._mathService.Sum(zahl1,zahl2);
        }

        [HttpGet]
    }
}
