//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AERHiPets.DAL.NewDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipoIncidentes
    {
        public TipoIncidentes()
        {
            this.Incidentes = new HashSet<Incidentes>();
        }
    
        public int Id { get; set; }
        public string tipoIncidente { get; set; }
        public string descripcion { get; set; }
    
        public virtual ICollection<Incidentes> Incidentes { get; set; }
    }
}
