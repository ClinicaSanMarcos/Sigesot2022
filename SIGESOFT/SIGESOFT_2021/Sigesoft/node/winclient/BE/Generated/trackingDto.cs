//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2022/08/03 - 23:16:54
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Sigesoft.Node.WinClient.BE
{
    [DataContract()]
    public partial class trackingDto
    {
        [DataMember()]
        public String v_SeguroId { get; set; }

        [DataMember()]
        public String v_PersonId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_Agenda { get; set; }

        [DataMember()]
        public Nullable<Int32> i_CartaGarantia { get; set; }

        [DataMember()]
        public Nullable<Int32> i_AtencionMedica { get; set; }

        [DataMember()]
        public Nullable<Int32> i_PreLiquidacion { get; set; }

        [DataMember()]
        public Nullable<Int32> i_ControlCalidad { get; set; }

        [DataMember()]
        public Nullable<Int32> i_Facturacion { get; set; }

        [DataMember()]
        public Nullable<Int32> i_Culminado { get; set; }

        [DataMember()]
        public String v_ServiceId { get; set; }

        public trackingDto()
        {
        }

        public trackingDto(String v_SeguroId, String v_PersonId, Nullable<Int32> i_Agenda, Nullable<Int32> i_CartaGarantia, Nullable<Int32> i_AtencionMedica, Nullable<Int32> i_PreLiquidacion, Nullable<Int32> i_ControlCalidad, Nullable<Int32> i_Facturacion, Nullable<Int32> i_Culminado, String v_ServiceId)
        {
			this.v_SeguroId = v_SeguroId;
			this.v_PersonId = v_PersonId;
			this.i_Agenda = i_Agenda;
			this.i_CartaGarantia = i_CartaGarantia;
			this.i_AtencionMedica = i_AtencionMedica;
			this.i_PreLiquidacion = i_PreLiquidacion;
			this.i_ControlCalidad = i_ControlCalidad;
			this.i_Facturacion = i_Facturacion;
			this.i_Culminado = i_Culminado;
			this.v_ServiceId = v_ServiceId;
        }
    }
}
