using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace SmartCommerce.Application
{
#pragma warning disable CS1591 // O coment�rio XML ausente n�o foi encontrado para o tipo ou membro vis�vel publicamente
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
#pragma warning restore CS1591 // O coment�rio XML ausente n�o foi encontrado para o tipo ou membro vis�vel publicamente

}
