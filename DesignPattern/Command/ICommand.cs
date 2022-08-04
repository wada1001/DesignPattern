using System;
namespace HomeAutomation
{
    public interface ICommand
    {
        void Execute();
        void Undo();

        // selialization
        // void Store();
        // void Load();
    }
}
