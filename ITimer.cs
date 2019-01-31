using System;

namespace OliveGameStudio.Core.Timers
{
    public interface ITimer
    {
        /// <summary>Has the timer completed?</summary>
        bool IsCompleted { get; }

        /// <summary>The percent complete of the timer.</summary>
        float PercentComplete { get; }

        /// <summary>The current time.</summary>
        TimeSpan Time { get; }

        /// <summary>Update the timer.</summary>
        /// <param name="time">The time since last update.</param>
        void Update(TimeSpan time);
    }
}
