using Microsoft.EntityFrameworkCore;
using Project.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.API.DataRepository
{
    public class CustomerDbContext:DbContext
    {
        public CustomerDbContext(DbContextOptions options) : base(options)
        { }
        DbSet<Customer> Customers { get; set; }
    }
}
