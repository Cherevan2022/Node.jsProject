using DAL;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace API.Seeders
{
    public static class HostExtension
    {
        public static IHost Seed(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<AppDbContext>();
                    context.Database.EnsureCreated();
                    CpuSeed.SeedData(context);
                    GpuSeed.SeedData(context);
                    RamSeed.SeedData(context);
                    ComputerSeed.SeedData(context);
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return host;
        }
    }
}
