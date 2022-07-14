using MyCompany.MathProgram.DTO;

namespace MyCompany.MathProgram.ServiceInterface
{
    public interface IMathService
    {
        ResponseDTO Sum(RequestDTO requestDTO); //Gibt immer eine Klasse ResponseDTO zuück und muss ein RequestDTO übergeben bekommen

        ResponseDTO Sub(RequestDTO requestDTO);
        ResponseDTO Mult(RequestDTO requestDTO);
    }
}
