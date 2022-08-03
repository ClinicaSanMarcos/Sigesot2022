//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2021/12/12 - 23:41:24
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
    public partial class vigilanciaDto
    {
        [DataMember()]
        public String v_VigilanciaId { get; set; }

        [DataMember()]
        public String v_PersonId { get; set; }

        [DataMember()]
        public String v_PlanVigilanciaId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_WasNotifiedId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_ConfirmedNotification { get; set; }

        [DataMember()]
        public String v_Commentary { get; set; }

        [DataMember()]
        public Nullable<Int32> i_DoctorRespondibleId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_StateVigilanciaId { get; set; }

        [DataMember()]
        public Nullable<DateTime> d_StartDate { get; set; }

        [DataMember()]
        public Nullable<DateTime> d_EndDate { get; set; }

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
        public planvigilanciaDto planvigilancia { get; set; }

        [DataMember()]
        public personDto person { get; set; }

        [DataMember()]
        public List<vigilanciaserviceDto> vigilanciaservice { get; set; }

        public vigilanciaDto()
        {
        }

        public vigilanciaDto(String v_VigilanciaId, String v_PersonId, String v_PlanVigilanciaId, Nullable<Int32> i_WasNotifiedId, Nullable<Int32> i_ConfirmedNotification, String v_Commentary, Nullable<Int32> i_DoctorRespondibleId, Nullable<Int32> i_StateVigilanciaId, Nullable<DateTime> d_StartDate, Nullable<DateTime> d_EndDate, Nullable<Int32> i_IsDeleted, Nullable<Int32> i_InsertUserId, Nullable<DateTime> d_InsertDate, Nullable<Int32> i_UpdateUserId, Nullable<DateTime> d_UpdateDate, planvigilanciaDto planvigilancia, personDto person, List<vigilanciaserviceDto> vigilanciaservice)
        {
			this.v_VigilanciaId = v_VigilanciaId;
			this.v_PersonId = v_PersonId;
			this.v_PlanVigilanciaId = v_PlanVigilanciaId;
			this.i_WasNotifiedId = i_WasNotifiedId;
			this.i_ConfirmedNotification = i_ConfirmedNotification;
			this.v_Commentary = v_Commentary;
			this.i_DoctorRespondibleId = i_DoctorRespondibleId;
			this.i_StateVigilanciaId = i_StateVigilanciaId;
			this.d_StartDate = d_StartDate;
			this.d_EndDate = d_EndDate;
			this.i_IsDeleted = i_IsDeleted;
			this.i_InsertUserId = i_InsertUserId;
			this.d_InsertDate = d_InsertDate;
			this.i_UpdateUserId = i_UpdateUserId;
			this.d_UpdateDate = d_UpdateDate;
			this.planvigilancia = planvigilancia;
			this.person = person;
			this.vigilanciaservice = vigilanciaservice;
        }
    }
}
