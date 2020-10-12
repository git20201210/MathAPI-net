using MathAPI.Services.Interfaces;

namespace MathAPI.Services.Implementation
{
    public class AddService : IAddService
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}
