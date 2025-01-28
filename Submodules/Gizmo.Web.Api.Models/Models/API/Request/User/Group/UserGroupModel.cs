using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User group.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserGroupModel : IUserGroupModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The name of the user group.
        /// </summary>
        [StringLength(45)]
        [MessagePack.Key(1)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The description of the user group.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(2)]
        public string? Description { get; set; }

        /// <summary>
        /// The Id of the billing profile this user group is associated with.
        /// </summary>
        [MessagePack.Key(3)]
        public int? BillingProfileId { get; set; }

        /// <summary>
        /// The required user info object attached to this user group.
        /// </summary>
        [MessagePack.Key(4)]
        public UserModelRequiredInfo? RequiredUserInfo { get; set; }

        /// <summary>
        /// Whether to override the default application group.
        /// </summary>
        [MessagePack.Key(5)]
        public bool OverrideApplicationGroup { get; set; }

        /// <summary>
        /// The Id of the application profile this user group is associated with.
        /// </summary>
        [MessagePack.Key(6)]
        public int? ApplicationGroupId { get; set; }

        /// <summary>
        /// Whether to override the default security profile.
        /// </summary>
        [MessagePack.Key(7)]
        public bool OverrideSecurityProfile { get; set; }

        /// <summary>
        /// The Id of the security profile this user group is associated with.
        /// </summary>
        [MessagePack.Key(8)]
        public int? SecurityProfileId { get; set; }

        /// <summary>
        /// Whether to override the default age rating.
        /// </summary>
        [MessagePack.Key(9)]
        public bool OverrideAgeRating { get; set; }

        /// <summary>
        /// Whether the age rating is enabled for the user group.
        /// </summary>
        [MessagePack.Key(10)]
        public bool IsAgeRatingEnabled { get; set; }

        /// <summary>
        /// Enable personal storage.
        /// </summary>
        [MessagePack.Key(11)]
        public bool EnablePersonalStorage { get; set; }

        /// <summary>
        /// Hide logout button.
        /// </summary>
        [MessagePack.Key(12)]
        public bool HideLogoutButton { get; set; }

        /// <summary>
        /// Disallow login from client.
        /// </summary>
        [MessagePack.Key(13)]
        public bool DisallowLoginFromClient { get; set; }

        /// <summary>
        /// Allow guest use.
        /// </summary>
        [MessagePack.Key(14)]
        public bool GuestUse { get; set; }

        /// <summary>
        /// Allow only guest use.
        /// </summary>
        [MessagePack.Key(15)]
        public bool GuestUseOnly { get; set; }

        /// <summary>
        /// Disallow login from manager.
        /// </summary>
        [MessagePack.Key(16)]
        public bool DisallowLoginFromManager { get; set; }

        /// <summary>
        /// Whether the users of this user group are allowed to have negative balance.
        /// </summary>
        [MessagePack.Key(17)]
        public bool IsNegativeBalanceAllowed { get; set; }

        /// <summary>
        /// The credit limit of the user group.
        /// </summary>
        [MessagePack.Key(18)]
        public decimal CreditLimit { get; set; }

        /// <summary>
        /// The points award options of the user group.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(19)]
        public TimePointAwardOptionType PointsAwardOptions { get; set; }

        /// <summary>
        /// The points money ratio.
        /// </summary>
        [MessagePack.Key(20)]
        public decimal PointsMoneyRatio { get; set; }

        /// <summary>
        /// The points time ratio.
        /// </summary>
        [MessagePack.Key(21)]
        public int PointsTimeRatio { get; set; }

        /// <summary>
        /// The amount of points to award.
        /// </summary>
        [MessagePack.Key(22)]
        public int? PointsAward { get; set; }

        /// <summary>
        /// Whether the user group is default for new users.
        /// </summary>
        [MessagePack.Key(23)]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Disable use of time offers.
        /// </summary>
        [MessagePack.Key(24)]
        public bool DisableTimeOffer { get; set; }

        /// <summary>
        /// Disable use of fixed time purchase.
        /// </summary>
        [MessagePack.Key(25)]
        public bool DisableFixedTime { get; set; }

        /// <summary>
        /// Disable use of deposits for time.
        /// </summary>
        [MessagePack.Key(26)]
        public bool DisableDeposit { get; set; }

        /// <summary>
        /// Whether the waiting line priority is enabled for the user group.
        /// </summary>
        [MessagePack.Key(27)]
        public bool IsWaitingLinePriorityEnabled { get; set; }

        /// <summary>
        /// The waiting line priority of the user group.
        /// </summary>
        [MessagePack.Key(28)]
        public int WaitingLinePriority { get; set; }

        #endregion
    }
}