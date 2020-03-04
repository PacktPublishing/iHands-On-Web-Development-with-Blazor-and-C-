namespace LifetimesExperiment.Services
{
    using System;

    public class SingletonService
    {
        private DateTime initialized;

        public SingletonService()
        {
            this.initialized = DateTime.Now;
        }

        public string GetMessage() => "Message from the Singleton service";

        public DateTime GetInitializationDate() => this.initialized;
    }
}