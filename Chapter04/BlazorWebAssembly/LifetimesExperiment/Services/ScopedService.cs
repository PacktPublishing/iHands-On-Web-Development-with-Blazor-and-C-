namespace LifetimesExperiment.Services
{
    using System;

    public class ScopedService
    {
        private DateTime initialized;

        public ScopedService()
        {
            this.initialized = DateTime.Now;
        }

        public string GetMessage() => "Message from the Scoped service";

        public DateTime GetInitializationDate() => this.initialized;
    }
}