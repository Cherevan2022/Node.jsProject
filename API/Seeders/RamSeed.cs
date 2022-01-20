using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Seeders
{
    public class RamSeed
    {
        public static void SeedData(AppDbContext context)
        {
            if (context.Rams.Any())
                return;

            var rams = new[]
            {
                new RAM()
                {
                    Size = 4096,
                    Generation = "DDR4"
                },
                new RAM()
                {
                    Size = 8192,
                    Generation = "DDR5"
                },
                new RAM()
                {
                    Size = 16384,
                    Generation = "DDR5"
                }
            };

            foreach (RAM ram in rams)
            {
                context.Rams.Add(ram);
            }

            context.SaveChanges();
        }
    }
}
