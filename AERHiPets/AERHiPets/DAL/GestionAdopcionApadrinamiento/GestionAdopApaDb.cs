﻿using AERHiPets.Models.GestionAdopcionApadrinamiento;
using AERHiPets.Models.GestionAdopcionApadrinamiento.GestionAdopcion;
using AERHiPets.Models.GestionAdopcionApadrinamiento.GestionApadrinamiento;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AERHiPets.DAL.GestionAdopcionApadrinamiento
{
    public class GestionAdopApaDb : DbContext
    {
         public GestionAdopApaDb() : base("DefaultConnection")
        {
        }

         

         public DbSet<Adopcion> adopciones { get; set; }
         public DbSet<EstadoAdopcion> estadosAdopciones { get; set; }
         public DbSet<TipoAdopcion> tiposAdopciones { get; set; }

         public DbSet<Apadrinamiento> apadrinamientos { get; set; }
         public DbSet<EstadoApadrinamiento> estadosApadrinamientos { get; set; }

         

    }
}