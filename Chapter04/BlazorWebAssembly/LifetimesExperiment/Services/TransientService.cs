namespace LifetimesExperiment.Services
{
    using System;

    public class TransientService
    {
        private DateTime initialized;

        public TransientService()
        {
            this.initialized = DateTime.Now;
        }

        public string GetMessage() => "Message from the Transient service";

        public DateTime GetInitializationDate() => this.initialized;
    }
}