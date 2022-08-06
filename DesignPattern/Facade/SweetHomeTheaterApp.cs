using System;
namespace SweetHomeTheater
{
    public static class SweetHomeTheaterApp
    {
        public static void Perform()
        {
            var facade = new HomeTheaterFacade(
                new Amplifer(),
                new Tuner(),
                new StreamingPlayer(),
                new Projector(),
                new Screen(),
                new PopcornPopper(),
                new TheaterLights()
            );

            facade.WatchMovie("star wars");
            facade.EndMovie();
        }
    }
}
