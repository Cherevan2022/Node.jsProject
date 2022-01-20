using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Seeders
{
    public class CpuSeed
    {
        public static void SeedData(AppDbContext context)
        {
            if (context.Cpus.Any())
                return;

            var cpus = new[]
            {
                new CPU()
                {
                    Brand = "Intel Core i9-12900K",
                    CoresCount = 8
                },
                new CPU()
                {
                    Brand = "Intel Core i5-12600K",
                    CoresCount = 4
                },
                new CPU()
                {
                    Brand = "Intel Core i7-12700K",
                    CoresCount = 6
                }
            };

            foreach (CPU cpu in cpus)
            {
                context.Cpus.Add(cpu);
            }

            context.SaveChanges();
        }
    }
}
