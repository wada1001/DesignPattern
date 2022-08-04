using System;
namespace HomeAutomation
{
    public class RemoteControl
    {
        // ICommand have a only command "Execute"
        // so it can replace with delegate
        //delegate void Executable();

        //Executable[] onExecutes;
        //Executable[] offExecutes;

        ICommand[] onCommands;
        ICommand[] offCommands;
        ICommand undoCommands;

        public RemoteControl()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];
            undoCommands = new NoCommand();

            for (int i = 0; i < onCommands.Length; i++)
            {
                onCommands[i] = new NoCommand();
                offCommands[i] = new NoCommand();    
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            this.onCommands[slot] = onCommand;
            this.offCommands[slot] = offCommand;
        }

        public void UndoButtonPressed()
        {
            undoCommands.Execute();
        }

        public void OnButtonPressed(int slot)
        {
            onCommands[slot].Execute();
            undoCommands = onCommands[slot];
        }

        public void OffButtonPressed(int slot)
        {
            offCommands[slot].Execute();
            undoCommands = onCommands[slot];
        }

        public override string ToString()
        {
            var ret = "";

            for (int i = 0; i < onCommands.Length; i++)
            {
                ret += onCommands[i].GetType().ToString() + ", ";
                ret += offCommands[i].GetType().ToString() + "\n";
            }

            return ret;
        }
    }
}
