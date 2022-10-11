//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2022/08/03 - 23:17:37
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
    /// Assembler for <see cref="movement"/> and <see cref="movementDto"/>.
    /// </summary>
    public static partial class movementAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="movementDto"/> converted from <see cref="movement"/>.</param>
        static partial void OnDTO(this movement entity, movementDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="movement"/> converted from <see cref="movementDto"/>.</param>
        static partial void OnEntity(this movementDto dto, movement entity);

        /// <summary>
        /// Converts this instance of <see cref="movementDto"/> to an instance of <see cref="movement"/>.
        /// </summary>
        /// <param name="dto"><see cref="movementDto"/> to convert.</param>
        public static movement ToEntity(this movementDto dto)
        {
            if (dto == null) return null;

            var entity = new movement();

            entity.v_MovementId = dto.v_MovementId;
            entity.v_WarehouseId = dto.v_WarehouseId;
            entity.v_SupplierId = dto.v_SupplierId;
            entity.i_ProcessTypeId = dto.i_ProcessTypeId;
            entity.v_ParentMovementId = dto.v_ParentMovementId;
            entity.v_Motive = dto.v_Motive;
            entity.i_MotiveTypeId = dto.i_MotiveTypeId;
            entity.d_Date = dto.d_Date;
            entity.r_TotalQuantity = dto.r_TotalQuantity;
            entity.i_MovementTypeId = dto.i_MovementTypeId;
            entity.i_RequireRemoteProcess = dto.i_RequireRemoteProcess;
            entity.v_RemoteWarehouseId = dto.v_RemoteWarehouseId;
            entity.i_CurrencyId = dto.i_CurrencyId;
            entity.r_ExchangeRate = dto.r_ExchangeRate;
            entity.v_ReferenceDocument = dto.v_ReferenceDocument;
            entity.i_CostCenterId = dto.i_CostCenterId;
            entity.v_Observations = dto.v_Observations;
            entity.i_IsLocallyProcessed = dto.i_IsLocallyProcessed;
            entity.i_IsRemoteProcessed = dto.i_IsRemoteProcessed;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;
            entity.i_UpdateNodeId = dto.i_UpdateNodeId;
            entity.v_ComentaryUpdate = dto.v_ComentaryUpdate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="movement"/> to an instance of <see cref="movementDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="movement"/> to convert.</param>
        public static movementDto ToDTO(this movement entity)
        {
            if (entity == null) return null;

            var dto = new movementDto();

            dto.v_MovementId = entity.v_MovementId;
            dto.v_WarehouseId = entity.v_WarehouseId;
            dto.v_SupplierId = entity.v_SupplierId;
            dto.i_ProcessTypeId = entity.i_ProcessTypeId;
            dto.v_ParentMovementId = entity.v_ParentMovementId;
            dto.v_Motive = entity.v_Motive;
            dto.i_MotiveTypeId = entity.i_MotiveTypeId;
            dto.d_Date = entity.d_Date;
            dto.r_TotalQuantity = entity.r_TotalQuantity;
            dto.i_MovementTypeId = entity.i_MovementTypeId;
            dto.i_RequireRemoteProcess = entity.i_RequireRemoteProcess;
            dto.v_RemoteWarehouseId = entity.v_RemoteWarehouseId;
            dto.i_CurrencyId = entity.i_CurrencyId;
            dto.r_ExchangeRate = entity.r_ExchangeRate;
            dto.v_ReferenceDocument = entity.v_ReferenceDocument;
            dto.i_CostCenterId = entity.i_CostCenterId;
            dto.v_Observations = entity.v_Observations;
            dto.i_IsLocallyProcessed = entity.i_IsLocallyProcessed;
            dto.i_IsRemoteProcessed = entity.i_IsRemoteProcessed;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;
            dto.i_UpdateNodeId = entity.i_UpdateNodeId;
            dto.v_ComentaryUpdate = entity.v_ComentaryUpdate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="movementDto"/> to an instance of <see cref="movement"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<movement> ToEntities(this IEnumerable<movementDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="movement"/> to an instance of <see cref="movementDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<movementDto> ToDTOs(this IEnumerable<movement> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
