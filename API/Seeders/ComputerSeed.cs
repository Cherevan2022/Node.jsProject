using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Seeders
{
    public class ComputerSeed
    {
        public static void SeedData(AppDbContext context)
        {
            if (context.Computers.Any())
                return;

            var computers = new[]
            {
                new Computer()
                {
                    Producer = "DELL",
                    Model = "Latitude 5520",
                    RAM = context.Rams.AsEnumerable().ElementAt(0),
                    CPU = context.Cpus.AsEnumerable().ElementAt(1),
                    GPU = context.Gpus.AsEnumerable().ElementAt(0),
                    Description = "The best gameplay laptop!",
                    Image = "https://content2.rozetka.com.ua/goods/images/original/195581670.jpg"
                },
                new Computer()
                {
                    Producer = "Apple",
                    Model = "Macbook Pro M1",
                    RAM = context.Rams.AsEnumerable().ElementAt(1),
                    CPU = context.Cpus.AsEnumerable().ElementAt(2),
                    GPU = context.Gpus.AsEnumerable().ElementAt(0),
                    Description = "The most fastest processor forever ^-^",
                    Image = "https://i.citrus.ua/imgcache/size_800/uploads/shop/6/6/66e466f9203a51c1f4f09e7737292585.jpg"
                },
                new Computer()
                {
                    Producer = "HP",
                    Model = "Envy 13-ba1013",
                    RAM = context.Rams.AsEnumerable().ElementAt(1),
                    CPU = context.Cpus.AsEnumerable().ElementAt(0),
                    GPU = context.Gpus.AsEnumerable().ElementAt(2),
                    Description = "A good one choise for people who study!",
                    Image = "https://content2.rozetka.com.ua/goods/images/big/179854898.jpg"
                },
                new Computer()
                {
                    Producer = "Apple",
                    Model = "Macbook Pro M2",
                    RAM = context.Rams.AsEnumerable().ElementAt(1),
                    CPU = context.Cpus.AsEnumerable().ElementAt(2),
                    GPU = context.Gpus.AsEnumerable().ElementAt(0),
                    Description = "The most fastest processor forever ^-^",
                    Image = "https://i.citrus.ua/imgcache/size_800/uploads/shop/6/6/66e466f9203a51c1f4f09e7737292585.jpg"
                },
            };

            foreach (Computer computer in computers)
            {
                context.Computers.Add(computer);
            }

            context.SaveChanges();
        }
    }
}
