using BasicDependencyInjectionUsingOwningComponentBase.Services;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace BasicDependencyInjectionUsingOwningComponentBase
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddSingleton<AuthorService>();
            builder.Services.AddScoped<IBookService, BookService>();
            builder.RootComponents.Add<App>("app");

            var host = builder.Build();
            await host.RunAsync();
        }
    }
}