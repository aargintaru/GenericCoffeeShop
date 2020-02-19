using Entities;

namespace Interfaces
{
    public interface ICoffee : IBeverage
    {
        void SetCoffeeType(CoffeeType type);
    }
}