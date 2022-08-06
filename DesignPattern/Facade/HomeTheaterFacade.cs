using System;
namespace SweetHomeTheater
{
    public class HomeTheaterFacade
    {
        Amplifer amplifer;
        Tuner tuner;
        StreamingPlayer player;
        Projector projector;
        Screen screen;
        PopcornPopper popcornPopper;
        TheaterLights theaterLights;

        public HomeTheaterFacade(
            Amplifer amplifer,
            Tuner tuner,
            StreamingPlayer player,
            Projector projector,
            Screen screen,
            PopcornPopper popcornPopper,
            TheaterLights theaterLights
        ) {
            this.amplifer = amplifer;
            this.tuner = tuner;
            this.player = player;
            this.projector = projector;
            this.popcornPopper = popcornPopper;
            this.screen = screen;
            this.theaterLights = theaterLights;
        }


        public void WatchMovie(string movie)
        {
            Console.WriteLine("set up movie");

            popcornPopper.On();
            popcornPopper.Pop();

            theaterLights.Dim(10);
            screen.Down();
            projector.On();
            projector.SetMode(Projector.Mode.Wide);

            amplifer.SetPlayer(player);
            amplifer.SetSound(Amplifer.SoundMode.Stereo);
            amplifer.SetVolume(10);
            player.On();
            player.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("end movie");
            popcornPopper.Off();
            theaterLights.Off();
            screen.Up();
            projector.Off();
            amplifer.Off();
            player.Stop();
            player.Off();
        }
    }
}
