//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/07/04 - 12:32:21
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
    /// Assembler for <see cref="staffmarking"/> and <see cref="staffmarkingDto"/>.
    /// </summary>
    public static partial class staffmarkingAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="staffmarkingDto"/> converted from <see cref="staffmarking"/>.</param>
        static partial void OnDTO(this staffmarking entity, staffmarkingDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="staffmarking"/> converted from <see cref="staffmarkingDto"/>.</param>
        static partial void OnEntity(this staffmarkingDto dto, staffmarking entity);

        /// <summary>
        /// Converts this instance of <see cref="staffmarkingDto"/> to an instance of <see cref="staffmarking"/>.
        /// </summary>
        /// <param name="dto"><see cref="staffmarkingDto"/> to convert.</param>
        public static staffmarking ToEntity(this staffmarkingDto dto)
        {
            if (dto == null) return null;

            var entity = new staffmarking();

            entity.v_RegistrationId = dto.v_RegistrationId;
            entity.v_PersonId = dto.v_PersonId;
            entity.d_RegistrationDate = dto.d_RegistrationDate;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="staffmarking"/> to an instance of <see cref="staffmarkingDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="staffmarking"/> to convert.</param>
        public static staffmarkingDto ToDTO(this staffmarking entity)
        {
            if (entity == null) return null;

            var dto = new staffmarkingDto();

            dto.v_RegistrationId = entity.v_RegistrationId;
            dto.v_PersonId = entity.v_PersonId;
            dto.d_RegistrationDate = entity.d_RegistrationDate;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="staffmarkingDto"/> to an instance of <see cref="staffmarking"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<staffmarking> ToEntities(this IEnumerable<staffmarkingDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="staffmarking"/> to an instance of <see cref="staffmarkingDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<staffmarkingDto> ToDTOs(this IEnumerable<staffmarking> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}