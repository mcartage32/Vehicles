﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehiclesAPI.Data.Entities;

namespace VehiclesAPI.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        { }


        public DbSet<VehicleType> VehicleTypes { get; set; }// VehicleTypes es la coleccion de los tipos de vehiculo, debe ser plural

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<VehicleType>().HasIndex(x => x.Description).IsUnique(); //se define que el campo descripcion es unico
        }
    }
}
