﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModelLayer;

namespace RepositoryLayer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base (options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

        
    }
}
