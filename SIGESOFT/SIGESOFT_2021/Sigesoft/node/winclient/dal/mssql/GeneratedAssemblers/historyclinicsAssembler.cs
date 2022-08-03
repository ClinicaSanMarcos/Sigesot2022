//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2021/12/12 - 23:41:47
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
    /// Assembler for <see cref="historyclinics"/> and <see cref="historyclinicsDto"/>.
    /// </summary>
    public static partial class historyclinicsAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="historyclinicsDto"/> converted from <see cref="historyclinics"/>.</param>
        static partial void OnDTO(this historyclinics entity, historyclinicsDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="historyclinics"/> converted from <see cref="historyclinicsDto"/>.</param>
        static partial void OnEntity(this historyclinicsDto dto, historyclinics entity);

        /// <summary>
        /// Converts this instance of <see cref="historyclinicsDto"/> to an instance of <see cref="historyclinics"/>.
        /// </summary>
        /// <param name="dto"><see cref="historyclinicsDto"/> to convert.</param>
        public static historyclinics ToEntity(this historyclinicsDto dto)
        {
            if (dto == null) return null;

            var entity = new historyclinics();

            entity.v_HCLId = dto.v_HCLId;
            entity.v_PersonId = dto.v_PersonId;
            entity.v_nroHistoria = dto.v_nroHistoria;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="historyclinics"/> to an instance of <see cref="historyclinicsDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="historyclinics"/> to convert.</param>
        public static historyclinicsDto ToDTO(this historyclinics entity)
        {
            if (entity == null) return null;

            var dto = new historyclinicsDto();

            dto.v_HCLId = entity.v_HCLId;
            dto.v_PersonId = entity.v_PersonId;
            dto.v_nroHistoria = entity.v_nroHistoria;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="historyclinicsDto"/> to an instance of <see cref="historyclinics"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<historyclinics> ToEntities(this IEnumerable<historyclinicsDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="historyclinics"/> to an instance of <see cref="historyclinicsDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<historyclinicsDto> ToDTOs(this IEnumerable<historyclinics> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}