//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/07/04 - 12:32:13
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Linq;
using Sigesoft.Server.WebClientAdmin.DAL;

namespace Sigesoft.Server.WebClientAdmin.BE
{

    /// <summary>
    /// Assembler for <see cref="serversyncstatus"/> and <see cref="serversyncstatusDto"/>.
    /// </summary>
    public static partial class serversyncstatusAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="serversyncstatusDto"/> converted from <see cref="serversyncstatus"/>.</param>
        static partial void OnDTO(this serversyncstatus entity, serversyncstatusDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="serversyncstatus"/> converted from <see cref="serversyncstatusDto"/>.</param>
        static partial void OnEntity(this serversyncstatusDto dto, serversyncstatus entity);

        /// <summary>
        /// Converts this instance of <see cref="serversyncstatusDto"/> to an instance of <see cref="serversyncstatus"/>.
        /// </summary>
        /// <param name="dto"><see cref="serversyncstatusDto"/> to convert.</param>
        public static serversyncstatus ToEntity(this serversyncstatusDto dto)
        {
            if (dto == null) return null;

            var entity = new serversyncstatus();

            entity.i_NodeId = dto.i_NodeId;
            entity.i_Enabled = dto.i_Enabled;
            entity.v_ComentaryUpdate = dto.v_ComentaryUpdate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="serversyncstatus"/> to an instance of <see cref="serversyncstatusDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="serversyncstatus"/> to convert.</param>
        public static serversyncstatusDto ToDTO(this serversyncstatus entity)
        {
            if (entity == null) return null;

            var dto = new serversyncstatusDto();

            dto.i_NodeId = entity.i_NodeId;
            dto.i_Enabled = entity.i_Enabled;
            dto.v_ComentaryUpdate = entity.v_ComentaryUpdate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="serversyncstatusDto"/> to an instance of <see cref="serversyncstatus"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<serversyncstatus> ToEntities(this IEnumerable<serversyncstatusDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="serversyncstatus"/> to an instance of <see cref="serversyncstatusDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<serversyncstatusDto> ToDTOs(this IEnumerable<serversyncstatus> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
