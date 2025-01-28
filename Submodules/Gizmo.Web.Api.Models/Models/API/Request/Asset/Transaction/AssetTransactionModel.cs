using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Asset transaction.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class AssetTransactionModel : IAssetTransactionModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The date that the asset transaction was created.
        /// </summary>
        [Key(1)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The Id of the asset type the associated asset belongs to.
        /// </summary>
        [Key(2)]
        public int AssetTypeId { get; set; }

        /// <summary>
        /// The Id of the asset this asset transaction is associated with.
        /// </summary>
        [Key(3)]
        public int AssetId { get; set; }

        /// <summary>
        /// Whether the asset transaction is deleted.
        /// </summary>
        [Key(4)]
        public bool IsActive { get; set; }

        /// <summary>
        /// The Id of the operator who checked in the asset.
        /// </summary>
        [Key(5)]
        public int? CheckInOperatorId { get; set; }

        /// <summary>
        /// The date that the asset was checked in.
        /// </summary>
        [Key(6)]
        public DateTime? CheckInTime { get; set; }

        /// <summary>
        /// The Id of the operator who checked out the asset.
        /// </summary>
        [Key(7)]
        public int? CheckOutOperatorId { get; set; }

        /// <summary>
        /// The Id of the shift that the asset transaction belongs.
        /// </summary>
        [Key(8)]
        public int? ShiftId { get; set; }

        /// <summary>
        /// The Id of the register on which the asset transaction was performed.
        /// </summary>
        [Key(9)]
        public int? RegisterId { get; set; }

        #endregion
    }
}