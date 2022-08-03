//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/07/04 - 12:31:41
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
    /// Assembler for <see cref="hospitalizacionservice"/> and <see cref="hospitalizacionserviceDto"/>.
    /// </summary>
    public static partial class hospitalizacionserviceAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="hospitalizacionserviceDto"/> converted from <see cref="hospitalizacionservice"/>.</param>
        static partial void OnDTO(this hospitalizacionservice entity, hospitalizacionserviceDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="hospitalizacionservice"/> converted from <see cref="hospitalizacionserviceDto"/>.</param>
        static partial void OnEntity(this hospitalizacionserviceDto dto, hospitalizacionservice entity);

        /// <summary>
        /// Converts this instance of <see cref="hospitalizacionserviceDto"/> to an instance of <see cref="hospitalizacionservice"/>.
        /// </summary>
        /// <param name="dto"><see cref="hospitalizacionserviceDto"/> to convert.</param>
        public static hospitalizacionservice ToEntity(this hospitalizacionserviceDto dto)
        {
            if (dto == null) return null;

            var entity = new hospitalizacionservice();

            entity.v_HospitalizacionServiceId = dto.v_HospitalizacionServiceId;
            entity.v_HopitalizacionId = dto.v_HopitalizacionId;
            entity.v_ServiceId = dto.v_ServiceId;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;
            entity.v_ComentaryUpdate = dto.v_ComentaryUpdate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="hospitalizacionservice"/> to an instance of <see cref="hospitalizacionserviceDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="hospitalizacionservice"/> to convert.</param>
        public static hospitalizacionserviceDto ToDTO(this hospitalizacionservice entity)
        {
            if (entity == null) return null;

            var dto = new hospitalizacionserviceDto();

            dto.v_HospitalizacionServiceId = entity.v_HospitalizacionServiceId;
            dto.v_HopitalizacionId = entity.v_HopitalizacionId;
            dto.v_ServiceId = entity.v_ServiceId;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;
            dto.v_ComentaryUpdate = entity.v_ComentaryUpdate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="hospitalizacionserviceDto"/> to an instance of <see cref="hospitalizacionservice"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<hospitalizacionservice> ToEntities(this IEnumerable<hospitalizacionserviceDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="hospitalizacionservice"/> to an instance of <see cref="hospitalizacionserviceDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<hospitalizacionserviceDto> ToDTOs(this IEnumerable<hospitalizacionservice> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}