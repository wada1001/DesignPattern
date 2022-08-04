using System;
namespace HomeAutomation
{
    public static class HomeAutomationApp
    {
        public static void Perform()
        {
            var remocon = new RemoteControl();

            var light = new Light();
            var garageDoor = new GarageDoor();
            var stereo = new Stereo();

            var com1 = new LightOnCommand(light);
            var com2 = new LightOffCommand(light);
            var com3 = new GarageDoorOpenCommand(garageDoor);
            var com4 = new GarageDoorCloseCommand(garageDoor);
            var com5 = new StereoOnWithCommand(stereo);
            var com6 = new StereoOffWithCommand(stereo);



            var macroOn = new MacroCommand(new ICommand[] { com1, com3, com5 });
            var macroOff = new MacroCommand(new ICommand[] { com2, com4, com6 });

            remocon.SetCommand(1, com1, com2);
            remocon.SetCommand(2, com3, com4);
            remocon.SetCommand(3, com5, com6);
            remocon.SetCommand(4, macroOn, macroOff);

            Console.WriteLine(remocon.ToString());

            remocon.OnButtonPressed(0);
            remocon.OffButtonPressed(0);
            remocon.OnButtonPressed(1);
            remocon.OffButtonPressed(1);
            remocon.OnButtonPressed(2);
            remocon.OffButtonPressed(2);
            remocon.OnButtonPressed(3);
            remocon.OffButtonPressed(3);
            remocon.OnButtonPressed(4);
            remocon.OffButtonPressed(4);
        }
    }
}
