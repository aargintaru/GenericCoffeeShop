using System;
using Entities;
using Interfaces;

namespace Menu
{
    public class MenuPrinter
    {
        public IGraphicUserInterface gui;

        public MenuPrinter(IGraphicUserInterface gui)
        {
            this.gui = gui;
        }

        public void PrintHelloMessage()
        {
            gui.PrintMessageOnLine("Hello! Welcome to Starbucks!");
            gui.PrintMessageOnLine("How can I help you?");
            gui.PrintMessageOnLine("1. Order a beverage");
            gui.PrintMessageOnLine("2. Cancel");
        }

        public void PrintAvailableBeverages()
        {
            gui.PrintMessageOnLine("What beverage do you want?");
            gui.PrintMessageOnLine($"1. {BeverageNames.CaramelMacchiato}");
            gui.PrintMessageOnLine($"2. {BeverageNames.CaffeLatte}");
            gui.PrintMessageOnLine($"3. {BeverageNames.Cappuccino}");
            gui.PrintMessageOnLine($"4. {BeverageNames.CaffeAmericano}");
            gui.PrintMessageOnLine($"5. {BeverageNames.WhiteChocolateMocha}");
            gui.PrintMessageOnLine($"6. {BeverageNames.CaffeMocha}");
            gui.PrintMessageOnLine($"7. {BeverageNames.ChaiTeaLatte}");
            gui.PrintMessageOnLine($"8. {BeverageNames.PumpkinSpiceLatte}");
            gui.PrintMessageOnLine($"9. {BeverageNames.DoppioEspressoMacchiato}");
            gui.PrintMessageOnLine($"10. {BeverageNames.EspressoShot}");
        }

        public void PrintAvailableBeverageSizes()
        {
            gui.PrintMessageOnLine("What size do you want your beverage?");
            gui.PrintMessageOnLine("1. Short");
            gui.PrintMessageOnLine("2. Tall");
            gui.PrintMessageOnLine("3. Grande");
            gui.PrintMessageOnLine("4. Venti");
        }

        public void PrintAvailableCoffeeTypes()
        {
            gui.PrintMessageOnLine("Do you want stronger coffee or a more flavored one?");
            gui.PrintMessageOnLine("1. Strong coffee");
            gui.PrintMessageOnLine("2. Flavored coffee");
        }
    }
}