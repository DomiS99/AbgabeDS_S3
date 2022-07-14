using MyCompany.MathProgram.DTO;
using MyCompany.MathProgram.ServiceInterface;

namespace MyCompany.MathProgram.Service
{
    public class MathService : IMathService
    {

        public ResponseDTO Sum(RequestDTO requestDTO)
        {
            var result = requestDTO.NumberOne + requestDTO.NumberTwo; //Definition der Methode

            var ResponseDTO = new ResponseDTO(); //Response DTO wird initialisiert
            //Variablen werden für Rückgabe zugewiesen
            ResponseDTO.NumberOne = requestDTO.NumberOne;
            ResponseDTO.NumberTwo = requestDTO.NumberTwo;
            ResponseDTO.Result = result;
            return ResponseDTO;
        }

        public ResponseDTO Sub(RequestDTO requestDTO)
        {
            var result = requestDTO.NumberOne - requestDTO.NumberTwo; //Definition der Methode

            var ResponseDTO = new ResponseDTO(); //Response DTO wird initialisiert
            //Variablen werden für Rückgabe zugewiesen
            ResponseDTO.NumberOne = requestDTO.NumberOne;
            ResponseDTO.NumberTwo = requestDTO.NumberTwo;
            ResponseDTO.Result = result;
            return ResponseDTO;
        }

        public ResponseDTO Mult(RequestDTO requestDTO)
        {
            var result = requestDTO.NumberOne * requestDTO.NumberTwo; //Definition der Methode

            var ResponseDTO = new ResponseDTO(); //Response DTO wird initialisiert
            //Variablen werden für Rückgabe zugewiesen
            ResponseDTO.NumberOne = requestDTO.NumberOne;
            ResponseDTO.NumberTwo = requestDTO.NumberTwo;
            ResponseDTO.Result = result;
            return ResponseDTO;
        }
    }
}
Up