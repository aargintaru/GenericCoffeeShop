using Entities;

namespace GenericCoffeeShop
{
    public static class ExtensionMethods
    {
        public static BeverageSize ToBeverageSize(this int input)
        {
            switch (input)
            {
                case 1:
                    return BeverageSize.Short;
                case 2:
                    return BeverageSize.Tall;
                case 3:
                    return BeverageSize.Grande;
                case 4:
                    return BeverageSize.Venti;
                default:
                    return BeverageSize.Short;
            }
        }

        public static CoffeeType ToCoffeeType(this int input)
        {
            switch (input)
            {
                case 1:
                    return CoffeeType.Strong;
                case 2:
                    return CoffeeType.Flavored;
                default:
                    return CoffeeType.Strong;
            }
        }
    }
}