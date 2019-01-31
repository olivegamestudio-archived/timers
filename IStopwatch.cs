namespace OliveGameStudio.Core.Timers
{
    public interface IStopwatch : ITimer
    {
        /// <summary>Is the stopwatch running?</summary>
        bool IsRunning { get; }

        /// <summary>Start the stopwatch.</summary>
        void Start();

        /// <summary>Stop the stopwatch.</summary>
        void Stop();
    }
}
