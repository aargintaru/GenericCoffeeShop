using Interfaces;

namespace Entities.Beverages
{
    public abstract class BaseBeverage : IBeverage, ICoffee
    {
        protected string name;
        protected BeverageType type;
        protected BeverageSize size;
        bool hasStandardSize;
        private CoffeeType coffeeType;

        public BaseBeverage(string name, BeverageType type)
        {
            this.name = name;
            this.type = type;
        }
        public BaseBeverage(string name, BeverageType type, BeverageSize size, bool hasStandardSize) : this(name, type)
        {
            this.size = size;
            this.hasStandardSize = hasStandardSize;
        }
        
        public string GetBeverageDetails()
        {
            if (type == BeverageType.Coffee)
            {
                return $"{name} with a size: {size} and {coffeeType} coffee";
            }
            return $"{name} with a size: {size}";
        }

        public bool HasCoffee()
        {
            return type == BeverageType.Coffee;
        }

        public bool HasStandardSize()
        {
            return hasStandardSize;
        }

        public void SetBeverageSize(BeverageSize size)
        {
            this.size = size;
        }

        public void SetCoffeeType(CoffeeType value)
        {
            coffeeType = value;
        }
    }
}