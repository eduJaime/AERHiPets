﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AERHiPets.Models.GestionAnimal
{
    public class Raza
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "No se permiten mas de 50 caracteres.")]
        [Display(Name = "Raza")]
        public String nombre { get; set; }


        [StringLength(150, ErrorMessage = "No se permiten mas de 150 caracteres.")]
        [Display(Name = "Caracteristicas")]
        public String descripcion { get; set; }

        public int? especieID { get; set; }
        public Especie especie { get; set; }

        [Display(Name = "Fecha de Baja")]
        public DateTime? fechaBaja { get; set; }
    }
}