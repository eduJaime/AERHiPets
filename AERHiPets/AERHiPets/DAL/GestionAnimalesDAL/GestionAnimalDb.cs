﻿using AERHiPets.Models.GestionAnimal;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AERHiPets.DAL.GestionAnimalesDAL
{
    public class GestionAnimalDb :DbContext

    {
        public GestionAnimalDb()
            : base("DefaultConnection")
        {/*
            Database.SetInitializer<AerDb>(null); // Remove default initializer
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;*/
        }

         public DbSet<Especie> Especies { get; set; }
         public DbSet<Raza> Razas { get; set; }
         public DbSet<Animal> Animales { get; set; }
         public DbSet<Tamanio> Tamanios { get; set; }
    }
}