using System;
namespace MightyGumball
{
    public static class MightyGumballApp
    {
        public static void Perform()
        {
            var stateMachine = new GumballMachine(3);

            stateMachine.InsertQuarter();
            stateMachine.InsertQuarter();
            stateMachine.TurnCrank();
            stateMachine.Dispense();

        }
    }
}
