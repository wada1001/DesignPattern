using System;
namespace SweetHomeTheater
{
    public class Amplifer
    {
        public enum SoundMode
        {
            Stereo,
            Surround
        }

        Tuner tuner;
        StreamingPlayer player;
        int volume;
        SoundMode mode;

        public void On() => Console.WriteLine("amplifer on sound mode = " + mode.ToString());
        public void Off() => Console.WriteLine("amplifer off");
        public void SetPlayer(StreamingPlayer player) => this.player = player;
        public void SetSound(SoundMode mode) => this.mode = mode;
        public void SetTuner(Tuner tuner) => this.tuner = tuner;
        public void SetVolume(int volume) => this.volume = volume;
        public override string ToString() => "";

    }

    public class Tuner
    {
        public void On() => Console.WriteLine("tuner on");
        public void Off() => Console.WriteLine("tuner on");
        public void SetAm() => Console.WriteLine("tuner set am");
        public void SetFm() => Console.WriteLine("tuner set fm");
        public void SetFrequenty() => Console.WriteLine("tuner set frequenty");
        public override string ToString() => "";
    }

    public class StreamingPlayer
    {
        public enum AudioMode
        {
            Surround,
            TwoChannel
        }

        AudioMode mode;

        public void On() => Console.WriteLine("player on. mode = " + mode.ToString());
        public void Off() => Console.WriteLine("player off");
        public void Play(string movie) => Console.WriteLine("player play = " + movie);
        public void Pause() => Console.WriteLine("player pause");
        public void SetAudio(AudioMode mode) => this.mode = mode;
        public void Dio() => Console.WriteLine("amplifer on");
        public void Stop() => Console.WriteLine("amplifer on");

        public override string ToString() => "";
    }

    public class Projector
    {
        public enum Mode
        {
            TV,
            Wide
        }

        Mode mode;

        public void On() => Console.WriteLine("projector on");
        public void Off() => Console.WriteLine("projector on");
        public void SetMode(Mode mode) => this.mode = mode;
        public override string ToString() => "";
    }

    public class Screen
    {
        public void Up() => Console.WriteLine("screen up");
        public void Down() => Console.WriteLine("screen  down");
        public override string ToString() => "";
    }

    public class PopcornPopper
    {
        public void On() => Console.WriteLine("popcorn on");
        public void Off() => Console.WriteLine("popcorn off");
        public void Pop() => Console.WriteLine("popcorn pop");
        public override string ToString() => "";
    }

    public class TheaterLights
    {
        int dim;

        public void On() => Console.WriteLine("amplifer on");
        public void Off() => Console.WriteLine("amplifer on");
        public void Dim(int dim) => this.dim = dim;

        public override string ToString() => "";
    }
}
