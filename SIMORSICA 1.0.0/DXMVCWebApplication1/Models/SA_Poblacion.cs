//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DXMVCWebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SA_Poblacion
    {
        public int Pk_IdSAPoblacion { get; set; }
        public int Fk_IdCampania { get; set; }
        public string Raza { get; set; }
        public Nullable<int> UnidadesDeProduc { get; set; }
        public Nullable<int> Region { get; set; }
        public Nullable<int> Fk_IdMunicipio { get; set; }
        public Nullable<double> ZonaAmortig { get; set; }
        public Nullable<double> PoblacionTotalReg { get; set; }
        public Nullable<int> UPRegional { get; set; }
        public Nullable<double> AnioAntUPAtendidos { get; set; }
        public Nullable<double> AnioAntCabezasAtendidas { get; set; }
        public Nullable<double> AnioActUPEstimados { get; set; }
        public Nullable<double> AnioActCabezasEstimadas { get; set; }
    
        public virtual Municipio Municipio { get; set; }
        public virtual Campania Campania { get; set; }
    }
}