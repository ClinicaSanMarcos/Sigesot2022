//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2021/12/12 - 23:41:29
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
    public partial class workersscheduledetailDto
    {
        [DataMember()]
        public String v_ScheduleDetailId { get; set; }

        [DataMember()]
        public String v_ScheduleId { get; set; }

        [DataMember()]
        public String v_PersonId { get; set; }

        [DataMember()]
        public Nullable<DateTime> d_Date { get; set; }

        [DataMember()]
        public Nullable<TimeSpan> t_StartDate { get; set; }

        [DataMember()]
        public Nullable<TimeSpan> t_StartBreak { get; set; }

        [DataMember()]
        public Nullable<TimeSpan> t_EndBreak { get; set; }

        [DataMember()]
        public Nullable<TimeSpan> t_EndDate { get; set; }

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

        public workersscheduledetailDto()
        {
        }

        public workersscheduledetailDto(String v_ScheduleDetailId, String v_ScheduleId, String v_PersonId, Nullable<DateTime> d_Date, Nullable<TimeSpan> t_StartDate, Nullable<TimeSpan> t_StartBreak, Nullable<TimeSpan> t_EndBreak, Nullable<TimeSpan> t_EndDate, Nullable<Int32> i_IsDeleted, Nullable<Int32> i_InsertUserId, Nullable<DateTime> d_InsertDate, Nullable<Int32> i_UpdateUserId, Nullable<DateTime> d_UpdateDate)
        {
			this.v_ScheduleDetailId = v_ScheduleDetailId;
			this.v_ScheduleId = v_ScheduleId;
			this.v_PersonId = v_PersonId;
			this.d_Date = d_Date;
			this.t_StartDate = t_StartDate;
			this.t_StartBreak = t_StartBreak;
			this.t_EndBreak = t_EndBreak;
			this.t_EndDate = t_EndDate;
			this.i_IsDeleted = i_IsDeleted;
			this.i_InsertUserId = i_InsertUserId;
			this.d_InsertDate = d_InsertDate;
			this.i_UpdateUserId = i_UpdateUserId;
			this.d_UpdateDate = d_UpdateDate;
        }
    }
}
