using Interfaces;

namespace Menu
{
    public class MenuTransitionValidator
    {
        public MenuStateMachineState ValidateStateTransition(int userInput, MenuStateMachineState currentState, IBeverage beverage = null)
        {
            switch(currentState)
            {
                case MenuStateMachineState.Initialized:
                    if (userInput == 1)
                    {
                        return MenuStateMachineState.OrderingBeverage;
                    }
                    else
                    {
                        return MenuStateMachineState.Exit;
                    }
                case MenuStateMachineState.OrderingBeverage:
                    if (userInput >= 1 && userInput <= 10)
                    {
                        if (beverage.HasStandardSize() && !beverage.HasCoffee())
                        {
                            return MenuStateMachineState.Finished;
                        }
                        
                        if (beverage.HasStandardSize() && beverage.HasCoffee())
                        {
                            return MenuStateMachineState.SelectCoffeeType;
                        }

                        if (!beverage.HasStandardSize())
                        {
                            return MenuStateMachineState.SelectBeverageSize;
                        }
                    }
                    return MenuStateMachineState.OrderingBeverage;
                case MenuStateMachineState.SelectBeverageSize:
                    if (userInput >= 1 && userInput <= 4)
                    {
                        if (beverage.HasCoffee())
                        {
                            return MenuStateMachineState.SelectCoffeeType;
                        }
                        else
                        {
                            return MenuStateMachineState.Finished;
                        }
                    }
                    return MenuStateMachineState.SelectBeverageSize;
                case MenuStateMachineState.SelectCoffeeType:
                    if (userInput >= 1 && userInput <= 2)
                    {
                        return MenuStateMachineState.Finished;
                    }
                    return MenuStateMachineState.SelectBeverageSize;
                case MenuStateMachineState.Finished:
                    return MenuStateMachineState.Exit;
                default:
                    return MenuStateMachineState.Exit;
            }
        }
    }
}