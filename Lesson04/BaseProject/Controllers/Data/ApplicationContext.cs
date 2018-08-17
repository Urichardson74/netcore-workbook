﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BaseProject.Models;
namespace BaseProject.Controllers.Data
{
    
  
        public class ApplicationContext : DbContext
        {
            public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {} 
        public DbSet<User> Users
        {
            get;
            set;
        }
        }
}
