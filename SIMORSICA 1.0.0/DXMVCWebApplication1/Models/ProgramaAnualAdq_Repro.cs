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
    
    public partial class ProgramaAnualAdq_Repro
    {
        public int Pk_IdProgramaAnualAdq { get; set; }
        public Nullable<int> Fk_IdProgramaAnualAdq_Orig { get; set; }
        public int Fk_IdAnio__SIS { get; set; }
        public Nullable<int> Fk_IdUnidadEjecutora__UE { get; set; }
        public int Fk_IdBienOServ__SIS { get; set; }
        public int Fk_IdUnidadDeMedida__SIS { get; set; }
        public Nullable<decimal> Cant_Ene { get; set; }
        public Nullable<decimal> Cant_Feb { get; set; }
        public Nullable<decimal> Cant_Mar { get; set; }
        public Nullable<decimal> Cant_Abr { get; set; }
        public Nullable<decimal> Cant_May { get; set; }
        public Nullable<decimal> Cant_Jun { get; set; }
        public Nullable<decimal> Cant_Jul { get; set; }
        public Nullable<decimal> Cant_Ago { get; set; }
        public Nullable<decimal> Cant_Sep { get; set; }
        public Nullable<decimal> Cant_Oct { get; set; }
        public Nullable<decimal> Cant_Nov { get; set; }
        public Nullable<decimal> Cant_Dic { get; set; }
        public Nullable<decimal> RecFed { get; set; }
        public Nullable<decimal> RecEst { get; set; }
        public Nullable<decimal> RecProp { get; set; }
        public string Justificacion { get; set; }
        public Nullable<decimal> imp_Ene { get; set; }
        public Nullable<decimal> imp_Feb { get; set; }
        public Nullable<decimal> imp_Mar { get; set; }
        public Nullable<decimal> imp_Abr { get; set; }
        public Nullable<decimal> imp_May { get; set; }
        public Nullable<decimal> imp_Jun { get; set; }
        public Nullable<decimal> imp_Jul { get; set; }
        public Nullable<decimal> imp_Ago { get; set; }
        public Nullable<decimal> imp_Sep { get; set; }
        public Nullable<decimal> imp_Oct { get; set; }
        public Nullable<decimal> imp_Nov { get; set; }
        public Nullable<decimal> imp_Dic { get; set; }
        public Nullable<int> Fk_IdCampania__UE { get; set; }
        public Nullable<int> Fk_IdAccionXCampania { get; set; }
        public Nullable<int> Fk_IdActividadXAccion { get; set; }
        public Nullable<decimal> Cant_Anual { get; set; }
        public Nullable<decimal> imp_Anual { get; set; }
        public Nullable<decimal> Gastos { get; set; }
        public string EstadoDeGasto { get; set; }
        public string CT_User { get; set; }
        public Nullable<System.DateTime> CT_Date { get; set; }
    
        public virtual AccionXCampania_Repro AccionXCampania_Repro { get; set; }
        public virtual Campania_Repro Campania_Repro { get; set; }
        public virtual Anio Anio { get; set; }
        public virtual UnidadDeMedida UnidadDeMedida { get; set; }
        public virtual UnidadEjecutora UnidadEjecutora { get; set; }
        public virtual ActividadXAccion_Repro ActividadXAccion_Repro { get; set; }
        public virtual BienOServ BienOServ { get; set; }
    }
}