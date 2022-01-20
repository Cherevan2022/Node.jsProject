using DAL;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class ComputerService
    {
        private readonly AppDbContext context;

        public ComputerService(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Computer> GetComputers()
        {
            return context.Computers.Include(c => c.RAM).Include(c => c.CPU).Include(c => c.GPU);
        }

        public Computer GetComputerById(Guid id)
        {
            return context.Computers.Include(c => c.RAM).Include(c => c.CPU).Include(c => c.GPU).FirstOrDefault(c => c.Id == id);
        }
    }
}
