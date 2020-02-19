using Menu;
using Interfaces;

namespace GenericCoffeeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            IGraphicUserInterface gui = new ConsoleUserInterface();
            MenuStateMachine menu = new MenuStateMachine(gui);
            menu.Start();
        }
    }
}
