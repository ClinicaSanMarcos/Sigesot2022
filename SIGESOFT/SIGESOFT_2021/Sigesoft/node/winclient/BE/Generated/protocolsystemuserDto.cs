//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2021/12/12 - 23:40:41
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
    public partial class protocolsystemuserDto
    {
        [DataMember()]
        public String v_ProtocolSystemUserId { get; set; }

        [DataMember()]
        public Int32 i_SystemUserId { get; set; }

        [DataMember()]
        public String v_ProtocolId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_ApplicationHierarchyId { get; set; }

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
        public String v_ComentaryUpdate { get; set; }

        [DataMember()]
        public applicationhierarchyDto applicationhierarchy { get; set; }

        [DataMember()]
        public protocolDto protocol { get; set; }

        public protocolsystemuserDto()
        {
        }

        public protocolsystemuserDto(String v_ProtocolSystemUserId, Int32 i_SystemUserId, String v_ProtocolId, Nullable<Int32> i_ApplicationHierarchyId, Nullable<Int32> i_IsDeleted, Nullable<Int32> i_InsertUserId, Nullable<DateTime> d_InsertDate, Nullable<Int32> i_UpdateUserId, Nullable<DateTime> d_UpdateDate, String v_ComentaryUpdate, applicationhierarchyDto applicationhierarchy, protocolDto protocol)
        {
			this.v_ProtocolSystemUserId = v_ProtocolSystemUserId;
			this.i_SystemUserId = i_SystemUserId;
			this.v_ProtocolId = v_ProtocolId;
			this.i_ApplicationHierarchyId = i_ApplicationHierarchyId;
			this.i_IsDeleted = i_IsDeleted;
			this.i_InsertUserId = i_InsertUserId;
			this.d_InsertDate = d_InsertDate;
			this.i_UpdateUserId = i_UpdateUserId;
			this.d_UpdateDate = d_UpdateDate;
			this.v_ComentaryUpdate = v_ComentaryUpdate;
			this.applicationhierarchy = applicationhierarchy;
			this.protocol = protocol;
        }
    }
}
