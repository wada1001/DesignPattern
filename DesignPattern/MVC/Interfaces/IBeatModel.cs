using System;
namespace CSharpDj
{
    public interface IBeatModel
    {
        void Init();
        void On();
        void Off();
        void SetBPM(int bpm);
        int GetBPM();
        void RegisterObserver(BeatObserver o);
        void RemoveObserver(BeatObserver o);
        void RegisterObserver(BpmObserver o);
        void RemoveObserver(BpmObserver o);
    }
}
