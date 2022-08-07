using System;
namespace CSharpDj
{
    public interface IBeatController
    {
        void Start();
        void Stop();
        void IncreaseBpm();
        void DecreaseBpm();
        void SetBpm(int bpm);
    }
}
