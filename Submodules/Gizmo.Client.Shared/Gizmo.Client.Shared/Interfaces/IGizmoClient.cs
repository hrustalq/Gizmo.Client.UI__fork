#nullable enable

using Gizmo.Client.UI;
using Gizmo.Web.Api.Models;

namespace Gizmo.Client
{
    /// <summary>
    /// Gizmo client interface.
    /// </summary>
    public interface IGizmoClient
    {
        #region PROPERTIES

        /// <summary>
        /// Indicates that a connection is being initiated.
        /// </summary>
        bool IsConnected { get; }

        /// <summary>
        /// Indicates that a connection is made.
        /// </summary>
        bool IsConnecting { get; }

        /// <summary>
        /// Gets client number.
        /// </summary>
        public int Number { get; }

        /// <summary>
        /// Gets client host group id.
        /// </summary>
        public int? HostGroupId { get; }

        /// <summary>
        /// Indicates that system is currently out of order.
        /// </summary>
        public bool IsOutOfOrder { get; }

        /// <summary>
        /// Indicates that input is currently locked (blocked).
        /// </summary>
        public bool IsInputLocked { get; }

        #endregion

        #region EVENTS

        /// <summary>
        /// Raised when one of execution context state changes.
        /// </summary>
        event EventHandler<ClientExecutionContextStateArgs>? ExecutionContextStateChange;

        /// <summary>
        /// Raised when user login state changes.
        /// </summary>
        event EventHandler<UserLoginStateChangeEventArgs>? LoginStateChange;

        /// <summary>
        /// Raised when current user balance changes.
        /// </summary>
        event EventHandler<UserBalanceEventArgs>? UserBalanceChange;

        /// <summary>
        /// Raised when system user becomes idle.
        /// </summary>
        event EventHandler<UserIdleEventArgs> UserIdleChange;

        /// <summary>
        /// Raised when app enterprise changes.
        /// </summary>
        event EventHandler<AppEnterpriseChangeEventArgs>? AppEnterpriseChange;

        /// <summary>
        /// Raised when app category changes.
        /// </summary>
        event EventHandler<AppCategoryChangeEventArgs>? AppCategoryChange;

        /// <summary>
        /// Raised when host group changes.
        /// </summary>
        event EventHandler<HostGroupChangeEventArgs>? HostGroupChange;

        /// <summary>
        /// Raised when app changes.
        /// </summary>
        event EventHandler<AppChangeEventArgs>? AppChange;

        /// <summary>
        /// Raised when app exe changes.
        /// </summary>
        event EventHandler<AppExeChangeEventArgs>? AppExeChange;

        /// <summary>
        /// Raised when feed changes.
        /// </summary>
        event EventHandler<FeedChangeEventArgs>? FeedChange;

        /// <summary>
        /// Raised when news changes.
        /// </summary>
        event EventHandler<NewsChangeEventArgs>? NewsChange;

        /// <summary>
        /// Raised when personal file changes.
        /// </summary>
        event EventHandler<PersonalFileChangeEventArgs>? PersonalFileChange;

        /// <summary>
        /// Raised when app link changes.
        /// </summary>
        event EventHandler<AppLinkChangeEventArgs>? AppLinkChange;

        /// <summary>
        /// Raised when client connection state changes.
        /// </summary>
        event EventHandler<ConnectionStateEventArgs>? ConnectionStateChange;

        /// <summary>
        /// Raised when input lock state changes.
        /// </summary>
        event EventHandler<LockStateEventArgs> LockStateChange;

        /// <summary>
        /// Raised when out of order state changes.
        /// </summary>
        event EventHandler<OutOfOrderStateEventArgs> OutOfOrderStateChange;

        /// <summary>
        /// Raised when host reservation changes.
        /// </summary>
        event EventHandler<ReservationChangeEventArgs> ReservationChange;

        #endregion

        /// <summary>
        /// Checks if specified app passes current profile.
        /// </summary>
        /// <param name="appId">App id.</param>
        /// <returns>True if app profile have passed or there is no profile currently set, otherwise false.</returns>
        bool AppCurrentProfilePass(int appId);

        /// <summary>
        /// Tries to obtain execution context.
        /// </summary>
        /// <param name="appExeId">Application executable id.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Execution context result.</returns>
        Task<IAppExecutionContextResult> AppExeExecutionContextGetAsync(int appExeId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Checks if app exe passes age rating check.
        /// </summary>
        /// <param name="appExeId">App exe id.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <remarks>
        /// The function returns true if age rating is disabled.<br></br>
        /// The check is done against currently logged in user, if no user logged in or current user is guest true is returned.
        /// </remarks>
        /// <returns>True or false if age rating is passed, false in case of error.</returns>
        Task<bool> AppExePassAgeRatingAsync(int appExeId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Checks if app exe passes execution limit.
        /// </summary>
        /// <param name="appExeId">App exe id.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>True or false if execution limit check is passed, false in case of error.</returns>
        Task<bool> AppExeExecutionLimitPassAsync(int appExeId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets expanded path to the executable file.
        /// </summary>
        /// <param name="appExeId">App executable id.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <remarks>The path is always expanded in system and app context.</remarks>
        /// <returns>Path to the executable, empty string in case of error.</returns>
        Task<string> AppExePathGetAsync(int appExeId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Checks if executable file exists.
        /// </summary>
        /// <param name="appExeId">App executable id.</param>
        /// <param name="ignoreDeployments">Indicates if executable deployments should be considered.<br></br>
        /// We always consider that executable file exists if any deployments attached to the executable, setting this value to 
        /// true will ignore deployments and check if actual executable file exists.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>True if app exe has deployments or file exists, false if file not found or error.</returns>
        Task<bool> AppExeFileExistsAsync(int appExeId, bool ignoreDeployments = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Checks if personal file source directory exists.
        /// </summary>
        /// <param name="appExeId">App executable id.</param>
        /// <param name="personalFileId">Personal file id.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>True if directory exists, false if directory not found or error.</returns>
        Task<bool> PersonalFileExistAsync(int appExeId, int personalFileId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets expanded path to personal file folder.
        /// </summary>
        /// <param name="appExeId">App exe id.</param>
        /// <param name="personalFileId">Personal file id.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <remarks>The path is always expanded in system,app and executable context.</remarks>
        /// <returns>Path to the personal file folder, empty string in case of error or if personal file source is registry.</returns>
        Task<string> PersonalFilePathGetAsync(int appExeId, int personalFileId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Initiates user login.
        /// </summary>
        /// <param name="username">Username.</param>
        /// <param name="password">Optional password.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<LoginResult> UserLoginAsync(string username, string? password, CancellationToken cancellationToken = default);

        /// <summary>
        /// Initiates user logout.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns></returns>
        public Task UserLogoutAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns all user agreements based on supplied <paramref name="filter"/>.
        /// </summary>
        /// <param name="filter">Filter.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns></returns>
        public Task<PagedList<UserAgreementModel>> UserAgreementsGetAsync(UserAgreementsFilter filter, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets pending user agreements.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<PagedList<UserAgreementModel>> UserAgreementsPendingGetAsync(UserAgreementsFilter filter, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns all agreement states for current user.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<List<UserAgreementModelState>> UserAgreementsStatesGetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Accepts user agreement specified by <paramref name="userAgreementId"/> parameter.
        /// </summary>
        /// <param name="userAgreementId">User agreement id.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<UpdateResult> UserAgreementAcceptAsync(int userAgreementId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Rejects user agreement specified by <paramref name="userAgreementId"/> parameter.
        /// </summary>
        /// <param name="userAgreementId">User agreement id.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<UpdateResult> UserAgreementRejectAsync(int userAgreementId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set user agreement state.
        /// </summary>
        /// <param name="userAgreementId">User agreement id.</param>
        /// <param name="state">State.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<UpdateResult> UserAgreementStateSetAsync(int userAgreementId, Gizmo.UserAgreementAcceptState state, CancellationToken cancellationToken = default);

        /// <summary>
        /// Checks if specified user email exist.
        /// </summary>
        /// <param name="email">User email address.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>True or false.</returns>
        public Task<bool> UserEmailExistAsync(string email, CancellationToken cancellationToken = default);

        /// <summary>
        /// Checks if specified user mobile exist.
        /// </summary>
        /// <param name="mobilePhone">User mobile phone.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>True or false.</returns>
        public Task<bool> UserMobileExistAsync(string mobilePhone, CancellationToken cancellationToken = default);

        /// <summary>
        /// Checks if specified user exist.
        /// </summary>
        /// <param name="userNameEmailOrMobile">User user name, email or mobile phone.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <remarks>
        /// <b>The function will return true if user with username, email or mobile phone specified by <paramref name="userNameEmailOrMobile"/> exists.</b>
        /// </remarks>
        /// <returns>True or false.</returns>
        public Task<bool> UserExistAsync(string userNameEmailOrMobile, CancellationToken cancellationToken = default);

        /// <summary>
        /// Checks if specified token is valid.
        /// </summary>
        /// <param name="tokenType">Token type.</param>
        /// <param name="token">Token value.</param>
        /// <param name="confirmationCode">Confirmation code.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>True or false.</returns>
        public Task<bool> TokenIsValidAsync(TokenType tokenType, string token, string confirmationCode, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets required user info for default user group.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Required info, the value will be null if no default user group exist.</returns>
        public Task<UserModelRequiredInfo?> UserGroupDefaultRequiredInfoGetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Initiates user creation by email address.
        /// </summary>
        /// <param name="email">Email address.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Creation result.</returns>
        public Task<AccountCreationResultModelByEmail> UserCreateByEmailStartAsync(string email, CancellationToken cancellationToken = default);

        /// <summary>
        /// Initiates user creation by mobile phone.
        /// </summary>
        /// <param name="mobilePhone">Mobile phone.</param>
        /// <param name="confirmationCodeDeliveryMethod">Confirmation code delivery method.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Creation result.</returns>
        public Task<AccountCreationResultModelByMobilePhone> UserCreateByMobileStartAsync(string mobilePhone, Gizmo.ConfirmationCodeDeliveryMethod confirmationCodeDeliveryMethod = Gizmo.ConfirmationCodeDeliveryMethod.Undetermined, CancellationToken cancellationToken = default);

        /// <summary>
        /// Completes user creation.
        /// </summary>
        /// <param name="user">User profile model.</param>
        /// <param name="password">User password.</param>
        /// <param name="agreementStates">User agreement states.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Completion result.</returns>
        public Task<AccountCreationCompleteResultModel> UserCreateCompleteAsync(UserProfileModelCreate user, string password, List<UserAgreementModelState> agreementStates, CancellationToken cancellationToken = default);

        /// <summary>
        /// Completes user creation.
        /// </summary>
        /// <param name="token">Token value.</param>
        /// <param name="user">User profile model.</param>
        /// <param name="password">User password.</param>
        /// <param name="agreementStates">User agreement states.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Completion result.</returns>
        public Task<AccountCreationCompleteResultModelByToken> UserCreateByTokenCompleteAsync(string token, UserProfileModelCreate user, string password, List<UserAgreementModelState> agreementStates, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets user password recovery methods for specified user.
        /// </summary>
        /// <param name="userNameEmailOrMobile">User name, mobile or email address.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>User password recovery methods result model.</returns>
        public Task<UserRecoveryMethodGetResultModel> UserPasswordRecoveryMethodGetAsync(string userNameEmailOrMobile, CancellationToken cancellationToken = default);

        /// <summary>
        /// Initiates user password recovery by mobile phone.
        /// </summary>
        /// <param name="mobilePhone">Mobile phone.</param>
        /// <param name="confirmationCodeDeliveryMethod">Confirmation code delivery method.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Recovery procedure result.</returns>
        public Task<PasswordRecoveryStartResultModelByMobile> UserPasswordRecoveryByMobileStartAsync(string mobilePhone, Gizmo.ConfirmationCodeDeliveryMethod confirmationCodeDeliveryMethod = Gizmo.ConfirmationCodeDeliveryMethod.Undetermined, CancellationToken cancellationToken = default);

        /// <summary>
        /// Initiates user password recovery by email address.
        /// </summary>
        /// <param name="email">User email address.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Recovery procedure result.</returns>
        public Task<PasswordRecoveryStartResultModelByEmail> UserPasswordRecoveryByEmailStartAsync(string email, CancellationToken cancellationToken = default);

        /// <summary>
        /// Completes user password recovery process.
        /// </summary>
        /// <param name="token">Token value.</param>
        /// <param name="confirmationCode">Confirmation code.</param>
        /// <param name="newPassword">New user password.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Recovery procedure completion result.</returns>
        public Task<PasswordRecoveryCompleteResultCode> UserPasswordRecoveryCompleteAsync(string token, string confirmationCode, string newPassword, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets user balance.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Current user balance.</returns>
        public Task<UserBalanceModel> UserBalanceGetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets current user profile.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Current user profile.</returns>
        public Task<UserProfileModel> UserProfileGetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates current user profile.
        /// </summary>
        /// <param name="user">User profile.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<UpdateResult> UserProfileUpdateAsync(UserProfileModelUpdate user, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates current user password.
        /// </summary>
        /// <param name="oldPassword">Old user password.</param>
        /// <param name="newPassword">New user password.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<UpdateResult> UserPasswordUpdateAsync(string oldPassword, string newPassword, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates deposit payment intent.
        /// </summary>
        /// <param name="parameters">Deposit intent parameters.</param>
        /// <param name="cancellationToken">>Cancellation token.</param>
        /// <returns>Creation result.</returns>
        public Task<PaymentIntentCreateResultModel> PaymentIntentCreateAsync(PaymentIntentCreateParametersDepositModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets online deposit configuration.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Online deposit configuration.</returns>
        public Task<PaymentOnlineConfigurationModel> OnlinePaymentsConfigurationGetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets user usage session.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<UserUsageSessionModel> UserUsageSessionGetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets client reservation.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<ClientReservationModel> ClientReservationGetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns all news based on supplied <paramref name="filters"/>.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="cToken">Cancellation token.</param>
        public Task<PagedList<NewsModel>> NewsGetAsync(NewsFilter filters, CancellationToken cToken = default);

        /// <summary>
        /// Returns the news based on supplied <paramref name="id"/>.
        /// </summary>
        /// <param name="cToken">Cancellation token.</param>
        public Task<NewsModel?> NewsGetAsync(int id, CancellationToken cToken = default);

        /// <summary>
        /// Returns all feeds based on supplied <paramref name="filters"/>.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<PagedList<FeedModel>> FeedsGetAsync(FeedsFilter filters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns all user product groups based on supplied <paramref name="filters"/>.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="cToken">Cancellation token.</param>
        public Task<PagedList<UserProductGroupModel>> UserProductGroupsGetAsync(UserProductGroupsFilter filters, CancellationToken cToken = default);

        /// <summary>
        /// Returns the user product group specified by <paramref name="id"/>.
        /// </summary>
        /// <param name="id">Id of the product to get.</param>
        /// <param name="cToken">Cancellation token.</param>
        public Task<UserProductGroupModel?> UserProductGroupGetAsync(int id, CancellationToken cToken = default);

        /// <summary>
        /// Returns the user product specified by <paramref name="id"/>.
        /// </summary>
        /// <param name="id">Id of the product to get.</param>
        /// <param name="cToken">Cancellation token.</param>
        public Task<UserProductModel?> UserProductGetAsync(int id, CancellationToken cToken = default);

        /// <summary>
        /// Returns all user products based on supplied <paramref name="filters"/>.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="cToken">Cancellation token.</param>
        public Task<PagedList<UserProductModel>> UserProductsGetAsync(UserProductsFilter filters, CancellationToken cToken = default);

        /// <summary>
        /// Returns all user payment methods based on supplied <paramref name="filters"/>.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<PagedList<UserPaymentMethodModel>> UserPaymentMethodsGetAsync(UserPaymentMethodsFilter filters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns all user application enterprises based on supplied <paramref name="filters"/>.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<PagedList<UserApplicationEnterpriseModel>> UserApplicationEnterprisesGetAsync(UserApplicationEnterprisesFilter filters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns the user application enterprise specified by <paramref name="id"/>.
        /// </summary>
        /// <param name="id">Id of the user application enterprise to get.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<UserApplicationEnterpriseModel?> UserApplicationEnterpriseGetAsync(int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns all user application categories based on supplied <paramref name="filters"/>.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<PagedList<UserApplicationCategoryModel>> UserApplicationCategoriesGetAsync(UserApplicationCategoriesFilter filters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns the user application category specified by <paramref name="id"/>.
        /// </summary>
        /// <param name="id">Id of the user application category to get.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<UserApplicationCategoryModel?> UserApplicationCategoryGetAsync(int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns all user applications based on supplied <paramref name="filters"/>.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<PagedList<UserApplicationModel>> UserApplicationsGetAsync(UserApplicationsFilter filters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns user payment method by <paramref name="id"/>.
        /// </summary>
        /// <param name="cToken">Cancellation token.</param>
        public Task<UserPaymentMethodModel?> UserPaymentMethodGetAsync(int id, CancellationToken cToken = default);

        /// <summary>
        /// Returns the application specified by <paramref name="id"/>.
        /// </summary>
        /// <param name="id">Id of the application to get.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<UserApplicationModel?> UserApplicationGetAsync(int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns all user executables based on supplied <paramref name="filters"/>.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<PagedList<UserExecutableModel>> UserExecutablesGetAsync(UserExecutablesFilter filters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns the executable specified by <paramref name="id"/>.
        /// </summary>
        /// <param name="id">Id of the executable to get.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<UserExecutableModel?> UserExecutableGetAsync(int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns all user application links based on supplied <paramref name="filters"/>.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<PagedList<UserApplicationLinkModel>> UserApplicationLinksGetAsync(UserApplicationLinksFilter filters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns the user application link specified by <paramref name="id"/>.
        /// </summary>
        /// <param name="id">Id of the user application link to get.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<UserApplicationLinkModel?> UserApplicationLinkGetAsync(int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns all user personal files based on supplied <paramref name="filters"/>.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<PagedList<UserPersonalFileModel>> UserPersonalFilesGetAsync(UserPersonalFilesFilter filters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns the personal file specified by <paramref name="id"/>.
        /// </summary>
        /// <param name="id">Id of the personal file to get.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<UserPersonalFileModel?> UserPersonalFileGetAsync(int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns the registration verification method.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task<RegistrationVerificationMethod> RegistrationVerificationMethodGetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns the password recovery method.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<UserRecoveryMethod> PasswordRecoveryMethodGetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns the list of user popular applications.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<IEnumerable<PopularApplicationModel>> UserPopularApplicationsGetAsync(UserPopularApplicationsFilter filters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns the list of popular executables.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<IEnumerable<PopularExecutableModel>> UserPopularExecutablesGetAsync(UserPopularExecutablesFilter filters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns the list of user popular products.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<IEnumerable<PopularProductModel>> UserPopularProductsGetAsync(UserPopularProductsFilter filters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates host QR Code.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Generated host qr code.</returns>
        public Task<HostQRCodeResult> HostQRCodeGeneratAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns the list of user orders.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns></returns>
        public Task<PagedList<UserOrderModel>> UserOrdersGetAsync(UserOrdersFilter filters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Checks user's order line availability.
        /// </summary>
        /// <param name="userOrderLineModelCreate"></param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns></returns>
        public Task<UserProductAvailabilityCheckResult> UserProductAvailabilityCheckAsync(UserOrderLineModelCreate userOrderLineModelCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates an user order.
        /// </summary>
        /// <param name="userOrderModelCreate"></param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns></returns>
        public Task<UserOrderCreateResultModel> UserOrderCreateAsync(UserOrderModelCreate userOrderModelCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns true if client registration is enabled, otherwise returns false.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns></returns>
        public Task<bool> IsClientRegistrationEnabledGetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns the list of user host groups.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns></returns>
        public Task<PagedList<UserHostGroupModel>> UserHostGroupsGetAsync(UserHostGroupsFilter filters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns the user host group specified by <paramref name="id"/>.
        /// </summary>
        /// <param name="id">Id of the executable to get.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns></returns>
        public Task<UserHostGroupModel?> UserHostGroupGetAsync(int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns the next host reservation.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns></returns>
        public Task<NextHostReservationModel?> NextHostReservationGetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns the reservation configuration.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns></returns>
        public Task<ClientReservationOptions> ReservationConfigurationGetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Attempts to enter full screen mode.
        /// </summary>
        /// <param name="enterOptions">Options.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <remarks>
        /// This function does not throw any exceptions and any errors are logged instead.
        /// </remarks>
        /// <returns>Enter result.</returns>
        Task<FullScreenEnterResult> EnterFullSceenAsync(FullScreenEnterOptions? enterOptions = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Attempts to exit full screen mode.
        /// </summary>
        /// <param name="enterOptions">Options.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <remarks>
        /// This function does not throw any exceptions and any errors are logged instead.
        /// </remarks>
        /// <returns>Exit result.</returns>
        Task<FullScreenExitResult> ExitFullSceenAsync(FullScreenExitOptions? exitOptions = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Notifies user of app exe failed launch.
        /// </summary>
        /// <param name="appExeId">App exe id.</param>
        /// <param name="reason">Failure reason.</param>
        /// <param name="exception">Optional exception.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        public Task NotifyAppExeLaunchFailureAsync(int appExeId, AppExeLaunchFailReason reason = AppExeLaunchFailReason.Unknown, Exception? exception =null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets current cache location path.
        /// </summary>
        /// <remarks>
        /// Default path will be returned if one is not provided by client settings.<br></br>
        /// Default path location: C:\ProgramData\Application Data\NETProjects\Gizmo Client\Cache
        /// </remarks>
        /// <returns>Cache folder path.</returns>
        string CachePathGet();

        /// <summary>
        /// Enter into user lock mode.
        /// </summary>
        public Task UserLockEnterAsync();

        /// <summary>
        /// Exit user lock mode.
        /// </summary>
        public Task UserLockExitAsync();
    }
}
