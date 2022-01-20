using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Seeders
{
    public class GpuSeed
    {
        public static void SeedData(AppDbContext context)
        {
            if (context.Gpus.Any())
                return;

            var gpus = new[]
            {
                new GPU()
                {
                    Brand = "NVIDIA GeForce GTX 1650",
                    Size = 4096
                },
                new GPU()
                {
                    Brand = "Nvidia GeForce GTX 1070 Ti",
                    Size = 8192
                },
                new GPU()
                {
                    Brand = "AMD Radeon RX Vega 56",
                    Size = 8192
                }
            };

            foreach (GPU gpu in gpus)
            {
                context.Gpus.Add(gpu);
            }

            context.SaveChanges();
        }
    }
}
