using System;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Asset transaction.
    /// </summary>
    public interface IAssetTransactionModel : IWebApiModel
    {
        /// <summary>
        /// The date that the asset transaction was created.
        /// </summary>
        DateTime Date { get; set; }

        /// <summary>
        /// The Id of the asset type the associated asset belongs to.
        /// </summary>
        int AssetTypeId { get; set; }

        /// <summary>
        /// The Id of the asset this asset transaction is associated with.
        /// </summary>
        int AssetId { get; set; }

        /// <summary>
        /// Whether the asset transaction is deleted.
        /// </summary>
        bool IsActive { get; set; }

        /// <summary>
        /// The Id of the operator who checked in the asset.
        /// </summary>
        int? CheckInOperatorId { get; set; }

        /// <summary>
        /// The date that the asset was checked in.
        /// </summary>
        DateTime? CheckInTime { get; set; }

        /// <summary>
        /// The Id of the operator who checked out the asset.
        /// </summary>
        int? CheckOutOperatorId { get; set; }

        /// <summary>
        /// The Id of the shift that the asset transaction belongs.
        /// </summary>
        int? ShiftId { get; set; }

        /// <summary>
        /// The Id of the register on which the asset transaction was performed.
        /// </summary>
        int? RegisterId { get; set; }
    }
}