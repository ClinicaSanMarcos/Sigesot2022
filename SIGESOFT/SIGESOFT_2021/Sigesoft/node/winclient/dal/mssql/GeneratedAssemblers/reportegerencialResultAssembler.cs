//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2021/12/12 - 23:41:33
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
    /// Assembler for <see cref="reportegerencialResult"/> and <see cref="reportegerencialResultDto"/>.
    /// </summary>
    public static partial class reportegerencialResultAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="reportegerencialResultDto"/> converted from <see cref="reportegerencialResult"/>.</param>
        static partial void OnDTO(this reportegerencialResult entity, reportegerencialResultDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="reportegerencialResult"/> converted from <see cref="reportegerencialResultDto"/>.</param>
        static partial void OnEntity(this reportegerencialResultDto dto, reportegerencialResult entity);

        /// <summary>
        /// Converts this instance of <see cref="reportegerencialResultDto"/> to an instance of <see cref="reportegerencialResult"/>.
        /// </summary>
        /// <param name="dto"><see cref="reportegerencialResultDto"/> to convert.</param>
        public static reportegerencialResult ToEntity(this reportegerencialResultDto dto)
        {
            if (dto == null) return null;

            var entity = new reportegerencialResult();

            entity.Mes = dto.Mes;
            entity.Fecha = dto.Fecha;
            entity.TipoDocumento = dto.TipoDocumento;
            entity.Ingreso = dto.Ingreso;
            entity.Egreso = dto.Egreso;
            entity.Saldo = dto.Saldo;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="reportegerencialResult"/> to an instance of <see cref="reportegerencialResultDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="reportegerencialResult"/> to convert.</param>
        public static reportegerencialResultDto ToDTO(this reportegerencialResult entity)
        {
            if (entity == null) return null;

            var dto = new reportegerencialResultDto();

            dto.Mes = entity.Mes;
            dto.Fecha = entity.Fecha;
            dto.TipoDocumento = entity.TipoDocumento;
            dto.Ingreso = entity.Ingreso;
            dto.Egreso = entity.Egreso;
            dto.Saldo = entity.Saldo;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="reportegerencialResultDto"/> to an instance of <see cref="reportegerencialResult"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<reportegerencialResult> ToEntities(this IEnumerable<reportegerencialResultDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="reportegerencialResult"/> to an instance of <see cref="reportegerencialResultDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<reportegerencialResultDto> ToDTOs(this IEnumerable<reportegerencialResult> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
