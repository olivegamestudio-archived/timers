using System;

namespace OliveGameStudio.Core.Timers
{
    public class Stopwatch : IStopwatch
    {
        readonly TimeSpan _time;

        public float PercentCompleteReverse => 1 - PercentComplete;

        public float PercentComplete => (float) (Time.TotalMilliseconds / _time.TotalMilliseconds);

        /// <inheritdoc />
        public TimeSpan Time { get; private set; }

        /// <inheritdoc />
        public bool IsCompleted { get; private set; }

        public Stopwatch(TimeSpan time)
        {
            _time = time;
        }

        /// <inheritdoc />
        public void Update(TimeSpan time)
        {
            if (IsRunning)
            {
                Time += time;
                if (Time >= _time)
                {
                    Time = _time;
                    Stop();
                }
            }
        }

        /// <inheritdoc />
        public bool IsRunning { get; private set; }

        /// <inheritdoc />
        public void Start()
        {
            IsCompleted = false;
            IsRunning = true;
            Time = TimeSpan.Zero;
        }

        /// <inheritdoc />
        public void Stop()
        {
            IsCompleted = true;
            IsRunning = false;
        }
    }
}
