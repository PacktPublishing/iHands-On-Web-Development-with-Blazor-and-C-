using BasicDependencyInjectionWithDependencyInversion.Services;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace BasicDependencyInjectionWithDependencyInversion
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddSingleton<IBookAuthoringService, BookAuthoringService>();
            builder.RootComponents.Add<App>("app");

            var host = builder.Build();

            IBookAuthoringService bookAuthoringService = host.Services.GetRequiredService<IBookAuthoringService>();
            bookAuthoringService.Initialize();
            
            await host.RunAsync();
        }
    }
}