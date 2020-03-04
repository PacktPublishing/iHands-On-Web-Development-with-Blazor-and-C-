namespace BasicComponentStateChangesExperiment.Services
{
    using System;

    public class BlazorTimer : IDisposable
    {
        private System.Timers.Timer _timer;

        public void SetTimer(double interval)
        {
            _timer = new System.Timers.Timer(interval);
            _timer.Elapsed += NotifyTimerElapsed;
            _timer.Enabled = true;
        }

        public event Action OnElapsed;

        private void NotifyTimerElapsed(Object source, System.Timers.ElapsedEventArgs e)
        {
            OnElapsed?.Invoke();
        }

        public void Dispose()
        {
            _timer.Dispose();
        }
    }
}