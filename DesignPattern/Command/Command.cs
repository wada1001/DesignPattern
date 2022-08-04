using System;
namespace HomeAutomation
{
    public class NoCommand : ICommand
    {
        public void Execute() => Console.WriteLine("not registered");
        public void Undo() => Console.WriteLine("not registered");
    }

    public class LightOnCommand : ICommand
    {
        Light light;

        public LightOnCommand(Light light) => this.light = light;
        public void Execute() => light.On();
        public void Undo() => light.Off();
    }

    public class LightOffCommand : ICommand
    {
        Light light;

        public LightOffCommand(Light light) => this.light = light;
        public void Execute() => light.Off();
        public void Undo() => light.On();
    }

    public class GarageDoorOpenCommand : ICommand
    {
        GarageDoor garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor) => this.garageDoor = garageDoor;
        public void Execute() => garageDoor.Up();
        public void Undo() => garageDoor.Down();
    }

    public class GarageDoorCloseCommand : ICommand
    {
        GarageDoor garageDoor;

        public GarageDoorCloseCommand(GarageDoor garageDoor) => this.garageDoor = garageDoor;
        public void Execute() => garageDoor.Down();
        public void Undo() => garageDoor.Up();
    }

    public class StereoOnWithCommand : ICommand
    {
        Stereo stereo;

        public StereoOnWithCommand(Stereo stereo) => this.stereo = stereo;

        public void Execute()
        {
            stereo.On();
            stereo.SetCd();
            stereo.SetVolume(10);
        }

        public void Undo()
        {
            stereo.SetVolume(0);
            stereo.Off();
        }
    }

    public class StereoOffWithCommand : ICommand
    {
        Stereo stereo;

        public StereoOffWithCommand(Stereo stereo) => this.stereo = stereo;

        public void Execute()
        {
            stereo.SetVolume(0);
            stereo.Off();
        }

        public void Undo()
        {
            stereo.On();
            stereo.SetCd();
            stereo.SetVolume(10);
        }
    }

    public class CeilingFanHightCommand : ICommand
    {
        CeilingFan ceilingFan;
        CeilingFan.Speed prev;

        public CeilingFanHightCommand(CeilingFan ceilingFan) => this.ceilingFan = ceilingFan;

        public void Execute()
        {
            prev = ceilingFan.Current;
            ceilingFan.Hight();
        }

        public void Undo()
        {
            switch(prev)
            {
                case CeilingFan.Speed.Hight:
                    ceilingFan.Midiun();
                    prev = ceilingFan.Current;
                    break;
                case CeilingFan.Speed.Midium:
                    ceilingFan.Midiun();
                    prev = ceilingFan.Current;
                    break;
                case CeilingFan.Speed.Low:
                    ceilingFan.Low();
                    prev = ceilingFan.Current;
                    break;
                default:
                    return;
            }
        }
    }

    public class MacroCommand : ICommand
    {
        ICommand[] commands;

        public MacroCommand(ICommand[] commands)
        {
            this.commands = commands;
        }

        public void Execute()
        {
            Array.ForEach(commands, x => x.Execute());
        }

        public void Undo()
        {
            Array.ForEach(commands, x => x.Undo());
        }
    }
    
}
