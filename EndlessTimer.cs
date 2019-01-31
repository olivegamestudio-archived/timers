using System;
using OliveGameStudio.Core.Timers;

namespace OliveGameStudio.Core.Timers
{
    public class EndlessTimer : ITimer
    {
        TimeSpan _time;

        /// <inheritdoc />
        public bool IsCompleted => false;

        /// <inheritdoc />
        public float PercentComplete => 0;

        /// <inheritdoc />
        public TimeSpan Time => _time;

        /// <inheritdoc />
        public void Update(TimeSpan time)
        {
            _time += time;
        }
    }
}
