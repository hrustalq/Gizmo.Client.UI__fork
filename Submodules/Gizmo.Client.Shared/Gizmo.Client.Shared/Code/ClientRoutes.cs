namespace Gizmo.Client
{
    public class ClientRoutes
    {
        public const string LoginRoute = "/";

        public const string PasswordRecoveryRoute = "/passwordrecovery";
        public const string PasswordRecoveryConfirmationRoute = "/passwordrecoveryconfirmation";
        public const string PasswordRecoverySetNewPasswordRoute = "/passwordrecoverysetnewpassword";

        public const string RegistrationIndexRoute = "/registrationindex";
        public const string RegistrationConfirmationMethodRoute = "/registrationconfirmationmethod";
        public const string RegistrationConfirmationRoute = "/registrationconfirmation";
        public const string RegistrationBasicFieldsRoute = "/registrationbasicfields";
        public const string RegistrationAdditionalFieldsRoute = "/registrationadditionalfields";

        public const string HomeRoute = "/home";
        public const string ApplicationsRoute = "/apps";
        public const string ApplicationDetailsRoute = "/appdetails";
        public const string ShopRoute = "/shop";
        public const string ProductDetailsRoute = "/productdetails";

        public const string UserProfileRoute = "/profile";
        public const string UserDepositsRoute = "/profile/deposits";
        public const string UserProductsRoute = "/profile/products";
        public const string UserPurchasesRoute = "/profile/purchases";
        public const string UserSettingsRoute = "/settings";
    }
}
