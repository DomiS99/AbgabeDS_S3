using MyCompany.MathProgram.ServiceInterface;

namespace MyCompany.MathProgram.Service
{
    public class MathService : IMathService
    {
        public double Sum(double x, double y)
        {
            return x + y;
        }
    }
}
