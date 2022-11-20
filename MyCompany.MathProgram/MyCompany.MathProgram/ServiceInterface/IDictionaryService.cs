using MyCompany.MathProgram.Service;

namespace MyCompany.MathProgram.ServiceInterface
{
    public interface IDictionaryService
    {
        public DictionaryService Get(string Word);
    }
}
