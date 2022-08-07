using System;
using System.Collections.Generic;

namespace CSharpDj
{
    public class BeatModel : IBeatModel
    {
        List<BeatObserver> beatObservers = new List<BeatObserver>();
        List<BpmObserver> bpmObservers = new List<BpmObserver>();
        bool isRunning = false;
        int bpm = 90;

        public BeatModel()
        {
        }

        public int GetBPM() => bpm;

        public void Init()
        {
            Console.WriteLine("Init beat model");
        }

        public void Off()
        {
            SetBPM(0);
            isRunning = false;
        }

        public void On()
        {
            SetBPM(90);
            isRunning = true;
        }

        public void SetBPM(int bpm)
        {
            this.bpm = bpm;
            BpmNotify();
        }

        public void RegisterObserver(BeatObserver o) => beatObservers.Add(o);
        public void RemoveObserver(BeatObserver o) => beatObservers.Remove(o);
        public void RegisterObserver(BpmObserver o) => bpmObservers.Add(o);
        public void RemoveObserver(BpmObserver o) => bpmObservers.Remove(o);
        void BeatNotify() => beatObservers.ForEach(x => x.UpdateBeat(this));
        void BpmNotify() => bpmObservers.ForEach(x => x.UpdateBpm(this));

    }
}
