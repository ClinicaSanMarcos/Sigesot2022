//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/07/04 - 12:30:19
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Sigesoft.Server.WebClientAdmin.BE
{
    [DataContract()]
    public partial class recetadespachoDto
    {
        [DataMember()]
        public Int32 i_IdDespacho { get; set; }

        [DataMember()]
        public Nullable<Int32> i_IdReceta { get; set; }

        [DataMember()]
        public Nullable<Decimal> d_MontoDespachado { get; set; }

        [DataMember()]
        public Nullable<DateTime> t_FechaDespacho { get; set; }

        [DataMember()]
        public String v_ComentaryUpdate { get; set; }

        public recetadespachoDto()
        {
        }

        public recetadespachoDto(Int32 i_IdDespacho, Nullable<Int32> i_IdReceta, Nullable<Decimal> d_MontoDespachado, Nullable<DateTime> t_FechaDespacho, String v_ComentaryUpdate)
        {
			this.i_IdDespacho = i_IdDespacho;
			this.i_IdReceta = i_IdReceta;
			this.d_MontoDespachado = d_MontoDespachado;
			this.t_FechaDespacho = t_FechaDespacho;
			this.v_ComentaryUpdate = v_ComentaryUpdate;
        }
    }
}
