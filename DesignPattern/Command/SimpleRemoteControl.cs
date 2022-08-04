using System;
namespace HomeAutomation
{
    public class SimpleRemoteControl
    {
        ICommand slot;

        public SimpleRemoteControl()
        {
        }

        public void SetCommand(ICommand command) => slot = command;

        public void OnPressedButton()
        {
            if (slot == null) return;

            slot.Execute();
        }
    }
}
