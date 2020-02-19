using Interfaces;

namespace Entities.Beverages
{
    public class CaramelMacchiato : BaseBeverage
    {
        public CaramelMacchiato() : base(BeverageNames.CaramelMacchiato, BeverageType.Coffee)
        {
        }
    }

    public class CaffeLatte : BaseBeverage
    {
        public CaffeLatte() : base(BeverageNames.CaffeLatte, BeverageType.Coffee, BeverageSize.Grande, true)
        {
        }
    }

    public class Cappuccino : BaseBeverage
    {
        public Cappuccino() : base(BeverageNames.Cappuccino, BeverageType.Coffee)
        {
        }
    }

    public class CaffeAmericano : BaseBeverage
    {
        public CaffeAmericano() : base(BeverageNames.CaffeAmericano, BeverageType.Coffee, BeverageSize.Tall, true)
        {
        }
    }

    public class WhiteChocolateMocha : BaseBeverage
    {
        public WhiteChocolateMocha() : base(BeverageNames.WhiteChocolateMocha, BeverageType.Coffee, BeverageSize.Tall, true)
        {
        }
    }

    public class CaffeMocha : BaseBeverage
    {
        public CaffeMocha() : base(BeverageNames.CaffeMocha, BeverageType.Coffee)
        {
        }
    }

    public class ChaiTeaLatte : BaseBeverage
    {
        public ChaiTeaLatte() : base(BeverageNames.ChaiTeaLatte, BeverageType.Tea, BeverageSize.Tall, true)
        {
        }
    }

    public class PumpkinSpiceLatte : BaseBeverage
    {
        public PumpkinSpiceLatte() : base(BeverageNames.PumpkinSpiceLatte, BeverageType.Coffee, BeverageSize.Grande, true)
        {
        }
    }

    public class DoppioEspressoMacchiato : BaseBeverage
    {
        public DoppioEspressoMacchiato() : base(BeverageNames.DoppioEspressoMacchiato, BeverageType.Coffee)
        {
        }
    }

    public class EspressoShot : BaseBeverage
    {
        public EspressoShot() : base(BeverageNames.EspressoShot, BeverageType.Coffee, BeverageSize.Short, true)
        {
        }
    }
}