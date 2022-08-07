using System;
namespace CSharpDj
{
    public interface BeatObserver
    {
        void UpdateBeat(IBeatModel model);
    }

    public interface BpmObserver
    {
        void UpdateBpm(IBeatModel model);
    }
}
