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
    
    public partial class StatusActividadKardex
    {
        public int PK_IdStatusActividadKardex { get; set; }
        public int FK_IdStatusActividad__SIS { get; set; }
        public int FK_IdActividad__UE { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Comentarios { get; set; }
    
        public virtual StatusActividad StatusActividad { get; set; }
        public virtual Actividad Actividad { get; set; }
    }
}