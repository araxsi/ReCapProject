﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //DB Bilgilerinin giriş yaptığı alandır.
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=RentDB;Trusted_Connection=true");
        }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Colors> Color { get; set; }
        public DbSet<Cars> Car { get; set; }

    }
}