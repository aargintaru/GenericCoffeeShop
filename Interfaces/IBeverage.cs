using Entities;

namespace Interfaces
{
    public interface IBeverage
    {
        void SetBeverageSize(BeverageSize size);
        bool HasStandardSize();
        bool HasCoffee();
        string GetBeverageDetails();
    }
}