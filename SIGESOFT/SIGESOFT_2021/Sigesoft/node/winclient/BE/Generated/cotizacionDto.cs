//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2021/12/12 - 23:39:35
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
    public partial class cotizacionDto
    {
        [DataMember()]
        public String v_CotizacionId { get; set; }

        [DataMember()]
        public String v_PersonId { get; set; }

        [DataMember()]
        public String v_ProtocolId { get; set; }

        [DataMember()]
        public Nullable<Decimal> d_CostoTotal { get; set; }

        [DataMember()]
        public Nullable<Decimal> d_aCuenta { get; set; }

        [DataMember()]
        public Nullable<Decimal> d_Saldo { get; set; }

        [DataMember()]
        public Nullable<Int32> i_IsDeleted { get; set; }

        [DataMember()]
        public Nullable<Int32> i_InsertUserId { get; set; }

        [DataMember()]
        public Nullable<DateTime> d_InsertDate { get; set; }

        [DataMember()]
        public Nullable<Int32> i_UpdateUserId { get; set; }

        [DataMember()]
        public Nullable<DateTime> d_UpdateDate { get; set; }

        [DataMember()]
        public Nullable<Int32> i_Procesado { get; set; }

        [DataMember()]
        public String v_Descripcion { get; set; }

        public cotizacionDto()
        {
        }

        public cotizacionDto(String v_CotizacionId, String v_PersonId, String v_ProtocolId, Nullable<Decimal> d_CostoTotal, Nullable<Decimal> d_aCuenta, Nullable<Decimal> d_Saldo, Nullable<Int32> i_IsDeleted, Nullable<Int32> i_InsertUserId, Nullable<DateTime> d_InsertDate, Nullable<Int32> i_UpdateUserId, Nullable<DateTime> d_UpdateDate, Nullable<Int32> i_Procesado, String v_Descripcion)
        {
			this.v_CotizacionId = v_CotizacionId;
			this.v_PersonId = v_PersonId;
			this.v_ProtocolId = v_ProtocolId;
			this.d_CostoTotal = d_CostoTotal;
			this.d_aCuenta = d_aCuenta;
			this.d_Saldo = d_Saldo;
			this.i_IsDeleted = i_IsDeleted;
			this.i_InsertUserId = i_InsertUserId;
			this.d_InsertDate = d_InsertDate;
			this.i_UpdateUserId = i_UpdateUserId;
			this.d_UpdateDate = d_UpdateDate;
			this.i_Procesado = i_Procesado;
			this.v_Descripcion = v_Descripcion;
        }
    }
}
