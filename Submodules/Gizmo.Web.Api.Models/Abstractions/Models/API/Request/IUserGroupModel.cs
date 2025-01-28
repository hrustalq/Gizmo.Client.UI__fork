namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// User group.
    /// </summary>
    public interface IUserGroupModel : IWebApiModel
    {
        /// <summary>
        /// The name of the user group.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The description of the user group.
        /// </summary>
        string? Description { get; set; }

        /// <summary>
        /// The Id of the billing profile this user group is associated with.
        /// </summary>
        int? BillingProfileId { get; set; }

        /// <summary>
        /// The required user info object attached to this user group.
        /// </summary>
        UserModelRequiredInfo? RequiredUserInfo { get; set; }

        /// <summary>
        /// Whether to override the default application group.
        /// </summary>
        bool OverrideApplicationGroup { get; set; }

        /// <summary>
        /// The Id of the application profile this user group is associated with.
        /// </summary>
        int? ApplicationGroupId { get; set; }

        /// <summary>
        /// Whether to override the default security profile.
        /// </summary>
        bool OverrideSecurityProfile { get; set; }

        /// <summary>
        /// The Id of the security profile this user group is associated with.
        /// </summary>
        int? SecurityProfileId { get; set; }

        /// <summary>
        /// Whether to override the default age rating.
        /// </summary>
        bool OverrideAgeRating { get; set; }

        /// <summary>
        /// Whether the age rating is enabled for the user group.
        /// </summary>
        bool IsAgeRatingEnabled { get; set; }

        /// <summary>
        /// Enable personal storage.
        /// </summary>
        bool EnablePersonalStorage { get; set; }

        /// <summary>
        /// Hide logout button.
        /// </summary>
        bool HideLogoutButton { get; set; }

        /// <summary>
        /// Disallow login from client.
        /// </summary>
        bool DisallowLoginFromClient { get; set; }

        /// <summary>
        /// Allow guest use.
        /// </summary>
        bool GuestUse { get; set; }

        /// <summary>
        /// Allow only guest use.
        /// </summary>
        bool GuestUseOnly { get; set; }

        /// <summary>
        /// Disallow login from manager.
        /// </summary>
        bool DisallowLoginFromManager { get; set; }

        /// <summary>
        /// Whether the users of this user group are allowed to have negative balance.
        /// </summary>
        bool IsNegativeBalanceAllowed { get; set; }

        /// <summary>
        /// The credit limit of the user group.
        /// </summary>
        decimal CreditLimit { get; set; }

        /// <summary>
        /// The points award options of the user group.
        /// </summary>
        TimePointAwardOptionType PointsAwardOptions { get; set; }

        /// <summary>
        /// The points money ratio.
        /// </summary>
        decimal PointsMoneyRatio { get; set; }

        /// <summary>
        /// The points time ratio.
        /// </summary>
        int PointsTimeRatio { get; set; }

        /// <summary>
        /// The amount of points to award.
        /// </summary>
        int? PointsAward { get; set; }

        /// <summary>
        /// Whether the user group is default for new users.
        /// </summary>
        bool IsDefault { get; set; }

        /// <summary>
        /// Disable use of time offers.
        /// </summary>
        bool DisableTimeOffer { get; set; }

        /// <summary>
        /// Disable use of fixed time purchase.
        /// </summary>
        bool DisableFixedTime { get; set; }

        /// <summary>
        /// Disable use of deposits for time.
        /// </summary>
        bool DisableDeposit { get; set; }

        /// <summary>
        /// Whether the waiting line priority is enabled for the user group.
        /// </summary>
        bool IsWaitingLinePriorityEnabled { get; set; }

        /// <summary>
        /// The waiting line priority of the user group.
        /// </summary>
        int WaitingLinePriority { get; set; }
    }
}