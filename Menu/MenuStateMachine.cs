using Entities;
using GenericCoffeeShop;
using Interfaces;

namespace Menu
{
    public class MenuStateMachine
    {
        private IGraphicUserInterface gui;
        private MenuStateMachineState currentState;
        private MenuPrinter menuPrinter;
        private MenuTransitionValidator menuTransitionValidator;
        private bool isStarted;
        private BeverageFactory beverageFactory;
        private IBeverage beverage;

        public MenuStateMachine(IGraphicUserInterface gui)
        {
            this.gui = gui;
            this.currentState = MenuStateMachineState.Initialized;
            this.menuPrinter = new MenuPrinter(gui);
            this.menuTransitionValidator = new MenuTransitionValidator();
            this.isStarted = false;
            this.beverageFactory = new BeverageFactory();
        }

        public void Start()
        {
            isStarted = true;
            while(isStarted)
            {
                int userInput;
                switch(currentState)
                {
                    case MenuStateMachineState.Initialized:
                        gui.ClearScreen();
                        menuPrinter.PrintHelloMessage();
                        userInput = gui.ReadInputInteger();
                        currentState = menuTransitionValidator.ValidateStateTransition(userInput, currentState);
                        break;
                    case MenuStateMachineState.OrderingBeverage:
                        gui.ClearScreen();
                        menuPrinter.PrintAvailableBeverages();
                        userInput = gui.ReadInputInteger();
                        beverage = beverageFactory.CreateBeverage(userInput);
                        currentState = menuTransitionValidator.ValidateStateTransition(userInput, currentState, beverage);
                        break;
                    case MenuStateMachineState.SelectBeverageSize:
                        gui.ClearScreen();
                        menuPrinter.PrintAvailableBeverageSizes();
                        userInput = gui.ReadInputInteger();
                        currentState = menuTransitionValidator.ValidateStateTransition(userInput, currentState, beverage);
                        beverage.SetBeverageSize(userInput.ToBeverageSize());
                        break;
                    case MenuStateMachineState.SelectCoffeeType:
                        gui.ClearScreen();
                        menuPrinter.PrintAvailableCoffeeTypes();
                        userInput = gui.ReadInputInteger();
                        currentState = menuTransitionValidator.ValidateStateTransition(userInput, currentState, beverage);
                        (beverage as ICoffee).SetCoffeeType(userInput.ToCoffeeType());
                        break;
                    case MenuStateMachineState.Finished:
                        gui.ClearScreen();
                        gui.PrintMessageOnLine("Thank you for ordering! Here is your coffee!");
                        gui.PrintMessageOnLine($"Your order: {beverage.GetBeverageDetails()}");
                        gui.PrintMessageOnLine("Please enjoy and come again!");
                        currentState = MenuStateMachineState.Exit;
                        break;
                    case MenuStateMachineState.Exit:
                        isStarted = false;
                        break;
                }
            }
        }
    }
}