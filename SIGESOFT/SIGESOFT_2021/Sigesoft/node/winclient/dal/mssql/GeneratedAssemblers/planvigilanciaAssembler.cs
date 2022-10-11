//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2022/08/03 - 23:17:51
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Linq;
using Sigesoft.Node.WinClient.DAL;

namespace Sigesoft.Node.WinClient.BE
{

    /// <summary>
    /// Assembler for <see cref="planvigilancia"/> and <see cref="planvigilanciaDto"/>.
    /// </summary>
    public static partial class planvigilanciaAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="planvigilanciaDto"/> converted from <see cref="planvigilancia"/>.</param>
        static partial void OnDTO(this planvigilancia entity, planvigilanciaDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="planvigilancia"/> converted from <see cref="planvigilanciaDto"/>.</param>
        static partial void OnEntity(this planvigilanciaDto dto, planvigilancia entity);

        /// <summary>
        /// Converts this instance of <see cref="planvigilanciaDto"/> to an instance of <see cref="planvigilancia"/>.
        /// </summary>
        /// <param name="dto"><see cref="planvigilanciaDto"/> to convert.</param>
        public static planvigilancia ToEntity(this planvigilanciaDto dto)
        {
            if (dto == null) return null;

            var entity = new planvigilancia();

            entity.v_PlanVigilanciaId = dto.v_PlanVigilanciaId;
            entity.v_Name = dto.v_Name;
            entity.v_Description = dto.v_Description;
            entity.v_OrganizationId = dto.v_OrganizationId;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="planvigilancia"/> to an instance of <see cref="planvigilanciaDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="planvigilancia"/> to convert.</param>
        public static planvigilanciaDto ToDTO(this planvigilancia entity)
        {
            if (entity == null) return null;

            var dto = new planvigilanciaDto();

            dto.v_PlanVigilanciaId = entity.v_PlanVigilanciaId;
            dto.v_Name = entity.v_Name;
            dto.v_Description = entity.v_Description;
            dto.v_OrganizationId = entity.v_OrganizationId;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="planvigilanciaDto"/> to an instance of <see cref="planvigilancia"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<planvigilancia> ToEntities(this IEnumerable<planvigilanciaDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="planvigilancia"/> to an instance of <see cref="planvigilanciaDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<planvigilanciaDto> ToDTOs(this IEnumerable<planvigilancia> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
