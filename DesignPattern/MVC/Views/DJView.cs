using System;
namespace CSharpDj
{
    public class DJView : BeatObserver, BpmObserver
    {
        IBeatModel model;
        IBeatController controller;

        // components
        string beatView;
        string beatPanel;
        int beatBar;
        int bpmLabel;


        public DJView(IBeatModel beatModel, IBeatController beatController)
        {
            this.model = beatModel;
            this.controller = beatController;
            model.RegisterObserver((BeatObserver)this);
            model.RegisterObserver((BpmObserver)this);
        }

        public void CreateView()
        {
            Console.WriteLine("view created");
        }

        public void UpdateBeat(IBeatModel model)
        {
            Console.WriteLine("updated beat");
            beatBar = 100;
        }

        public void UpdateBpm(IBeatModel model)
        {
            Console.WriteLine("updated bpm = " + model.GetBPM());
        }
    }
}
