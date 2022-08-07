using System;
namespace CSharpDj
{
    public class BeatController : IBeatController
    {
        IBeatModel model;
        DJView view;

        public BeatController()
        {
            model = new BeatModel();
            view = new DJView(model, this);
            view.CreateView();
            model.Init();
        }

        public void DecreaseBpm()
        {
            model.SetBPM(model.GetBPM() - 1);
        }

        public void IncreaseBpm()
        {
            model.SetBPM(model.GetBPM() + 1);
        }

        public void SetBpm(int bpm)
        {
            model.SetBPM(bpm);
        }

        public void Start()
        {
            model.On();
        }

        public void Stop()
        {
            model.Off();
        }
    }
}
