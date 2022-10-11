//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2022/08/03 - 23:17:14
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
    /// Assembler for <see cref="adultomayor"/> and <see cref="adultomayorDto"/>.
    /// </summary>
    public static partial class adultomayorAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="adultomayorDto"/> converted from <see cref="adultomayor"/>.</param>
        static partial void OnDTO(this adultomayor entity, adultomayorDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="adultomayor"/> converted from <see cref="adultomayorDto"/>.</param>
        static partial void OnEntity(this adultomayorDto dto, adultomayor entity);

        /// <summary>
        /// Converts this instance of <see cref="adultomayorDto"/> to an instance of <see cref="adultomayor"/>.
        /// </summary>
        /// <param name="dto"><see cref="adultomayorDto"/> to convert.</param>
        public static adultomayor ToEntity(this adultomayorDto dto)
        {
            if (dto == null) return null;

            var entity = new adultomayor();

            entity.v_AdultoMayorId = dto.v_AdultoMayorId;
            entity.v_PersonId = dto.v_PersonId;
            entity.v_NombreCuidador = dto.v_NombreCuidador;
            entity.v_EdadCuidador = dto.v_EdadCuidador;
            entity.v_DniCuidador = dto.v_DniCuidador;
            entity.v_MedicamentoFrecuente = dto.v_MedicamentoFrecuente;
            entity.v_InicioRS = dto.v_InicioRS;
            entity.v_NroPs = dto.v_NroPs;
            entity.v_FechaUR = dto.v_FechaUR;
            entity.v_RC = dto.v_RC;
            entity.v_Parto = dto.v_Parto;
            entity.v_Prematuro = dto.v_Prematuro;
            entity.v_Aborto = dto.v_Aborto;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;
            entity.v_ReaccionAlergica = dto.v_ReaccionAlergica;
            entity.v_DescripciónAntecedentes = dto.v_DescripciónAntecedentes;
            entity.v_FlujoVaginal = dto.v_FlujoVaginal;
            entity.v_ObservacionesEmbarazo = dto.v_ObservacionesEmbarazo;
            entity.v_ComentaryUpdate = dto.v_ComentaryUpdate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="adultomayor"/> to an instance of <see cref="adultomayorDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="adultomayor"/> to convert.</param>
        public static adultomayorDto ToDTO(this adultomayor entity)
        {
            if (entity == null) return null;

            var dto = new adultomayorDto();

            dto.v_AdultoMayorId = entity.v_AdultoMayorId;
            dto.v_PersonId = entity.v_PersonId;
            dto.v_NombreCuidador = entity.v_NombreCuidador;
            dto.v_EdadCuidador = entity.v_EdadCuidador;
            dto.v_DniCuidador = entity.v_DniCuidador;
            dto.v_MedicamentoFrecuente = entity.v_MedicamentoFrecuente;
            dto.v_InicioRS = entity.v_InicioRS;
            dto.v_NroPs = entity.v_NroPs;
            dto.v_FechaUR = entity.v_FechaUR;
            dto.v_RC = entity.v_RC;
            dto.v_Parto = entity.v_Parto;
            dto.v_Prematuro = entity.v_Prematuro;
            dto.v_Aborto = entity.v_Aborto;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;
            dto.v_ReaccionAlergica = entity.v_ReaccionAlergica;
            dto.v_DescripciónAntecedentes = entity.v_DescripciónAntecedentes;
            dto.v_FlujoVaginal = entity.v_FlujoVaginal;
            dto.v_ObservacionesEmbarazo = entity.v_ObservacionesEmbarazo;
            dto.v_ComentaryUpdate = entity.v_ComentaryUpdate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="adultomayorDto"/> to an instance of <see cref="adultomayor"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<adultomayor> ToEntities(this IEnumerable<adultomayorDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="adultomayor"/> to an instance of <see cref="adultomayorDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<adultomayorDto> ToDTOs(this IEnumerable<adultomayor> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
