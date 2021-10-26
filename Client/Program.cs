using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MoviesProy.Client.Services;

namespace MoviesProy.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddTransient<MostPopularServiceInterface, MostPopularService>();
            builder.Services.AddTransient<ComingSoonServiceInterface, ComingSoonService>();
            builder.Services.AddTransient<TitleDataServiceInterface, TitleDataService>();
            ConfigureServices(builder.Services);
            await builder.Build().RunAsync();
        }

        private static void ConfigureServices(IServiceCollection services){
            services.AddSingleton<IServicesMovie,ServicesMovie>();
            services.AddSingleton<IServicesActor,ServicesActor>();
            services.AddSingleton<IServicesCategory,ServicesCategory>();
        }
    }
}
