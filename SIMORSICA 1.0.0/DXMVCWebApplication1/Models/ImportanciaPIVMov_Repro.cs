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
    
    public partial class ImportanciaPIVMov_Repro
    {
        public int Pk_IdImportanciaPIVMov { get; set; }
        public Nullable<int> Fk_IdImportanciaPIVMov_Orig { get; set; }
        public int Fk_IdCampania { get; set; }
        public int NumPIVsFitosanitario { get; set; }
        public int NumPIVsZoosanitario { get; set; }
        public int NumPIVsFitoZoosaniatrio { get; set; }
        public double NumSitiosInspeccion { get; set; }
        public double NumRutasItinerantes { get; set; }
        public string CT_User { get; set; }
        public System.DateTime CT_Date { get; set; }
    
        public virtual Campania_Repro Campania_Repro { get; set; }
    }
}