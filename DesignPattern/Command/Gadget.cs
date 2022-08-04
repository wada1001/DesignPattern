using System;
namespace HomeAutomation
{
    public class Light
    {
        public Light() { }

        public void On() => Console.WriteLine("lighting!!");
        public void Off() => Console.WriteLine("darkness...");
    }

    public class GarageDoor
    {
        public void Up() => Console.WriteLine("garage up");
        public void Down() => Console.WriteLine("garage down");
        public void Stop() => Console.WriteLine("garage stop");
        public void LightOn() => Console.WriteLine("garage light on");
        public void LightOff() => Console.WriteLine("garage light off");
    }

    public class Stereo
    {
        public void On() => Console.WriteLine("stereo on");
        public void Off() => Console.WriteLine("stereo off");
        public void SetCd() => Console.WriteLine("stereo set cd");
        public void SetDvd() => Console.WriteLine("stereo set dvd");
        public void SetRadio() => Console.WriteLine("stereo set radio");
        public void SetVolume(int volume) => Console.WriteLine("stereo set volume = " + volume.ToString());
    }

    public class CeilingFan
    {
        public enum Speed
        {
            Off,
            Hight,
            Midium,
            Low
        }
        public Speed Current = Speed.Off;

        public void Hight()
        {
            Console.WriteLine("ceiling fan hight");
            Current = Speed.Hight;
        }

        public void Midiun()
        {
            Console.WriteLine("ceiling fan midium");
            Current = Speed.Midium;
        }

        public void Low()
        {
            Console.WriteLine("ceiling fan low");
            Current = Speed.Low;
        }

        public void Off()
        {
            Console.WriteLine("ceiling fan off");
            Current = Speed.Off;
        }
    }
}
