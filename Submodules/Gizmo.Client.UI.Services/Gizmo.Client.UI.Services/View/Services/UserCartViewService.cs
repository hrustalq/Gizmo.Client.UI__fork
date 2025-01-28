﻿using System.Globalization;
using Gizmo.Client.UI.Services;
using Gizmo.Client.UI.View.States;
using Gizmo.UI;
using Gizmo.UI.Services;
using Gizmo.UI.View.Services;
using Gizmo.Web.Api.Models;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Gizmo.Client.UI.View.Services
{
    [Register]
    [Route(ClientRoutes.ShopRoute)]
    public sealed class UserCartViewService : ValidatingViewStateServiceBase<UserCartViewState>
    {
        #region CONSTRUCTOR
        public UserCartViewService(
            IServiceProvider serviceProvider,
            ILogger<UserCartViewService> logger,
            UserCartViewState viewState,
            UserProductViewStateLookupService userProductViewStateLookupService,
            UserCartProductItemViewStateLookupService userCartProductItemLookupService,
            IClientDialogService dialogService,
            IGizmoClient gizmoClient,
            ILocalizationService localizationService) : base(viewState, logger, serviceProvider)
        {
            _userProductViewStateLookupService = userProductViewStateLookupService;
            _userCartProductItemLookupService = userCartProductItemLookupService;
            _dialogService = dialogService;
            _gizmoClient = gizmoClient;
            _localizationService = localizationService;
        }
        #endregion

        #region FIELDS
        private readonly UserProductViewStateLookupService _userProductViewStateLookupService;
        private readonly UserCartProductItemViewStateLookupService _userCartProductItemLookupService;
        private readonly IClientDialogService _dialogService;
        private readonly IGizmoClient _gizmoClient;
        private readonly ILocalizationService _localizationService;
        #endregion

        #region FUNCTIONS
        public async Task<UserProductViewState> GetCartProductViewStateAsync(int productId) =>
           await _userProductViewStateLookupService.GetStateAsync(productId);

        public async Task<UserCartProductItemViewState> GetCartProductItemViewStateAsync(int productId) =>
            await _userCartProductItemLookupService.GetStateAsync(productId);

        public async Task AddUserCartProductAsync(int productId, int quantity = 1)
        {
            try
            {
                var product = await _userProductViewStateLookupService.GetStateAsync(productId);
                var productItem = await _userCartProductItemLookupService.GetStateAsync(productId);

                //If PurchaseOptions is And then we cannot set PayType other than Mixed.
                if (product.PurchaseOptions == PurchaseOptionType.And)
                {
                    productItem.PayType = OrderLinePayType.Mixed;
                }

                if ((productItem.PayType == OrderLinePayType.Points || productItem.PayType == OrderLinePayType.Mixed) && product.UnitPointsPrice > 0)
                {
                    var userBalanceViewState = ServiceProvider.GetRequiredService<UserBalanceViewState>();

                    if (ViewState.PointsTotal + product.UnitPointsPrice > userBalanceViewState.PointsBalance)
                    {
                        if (productItem.Quantity == 0 && product.PurchaseOptions == PurchaseOptionType.Or)
                        {
                            //There is a case where the user previously used all his points and bought this product with points.
                            //When this product is added again in the cart the pay type is Points, but the user does'n have enough points to add it in the cart.
                            //Change the pay type to Cash to unblock add to cart.
                            productItem.PayType = OrderLinePayType.Cash;
                        }
                        else
                        {
                            await _dialogService.ShowAlertDialogAsync(_localizationService.GetString("GIZ_GEN_ERROR"), _localizationService.GetString("GIZ_INSUFFICIENT_POINTS"), AlertDialogButtons.OK, AlertTypes.Danger);
                            return;
                        }
                    }
                }

                if (product.IsStockLimited ||
                    product.PurchaseAvailability != null)
                {
                    try
                    {
                        var checkResult = await _gizmoClient.UserProductAvailabilityCheckAsync(new UserOrderLineModelCreate()
                        {
                            Guid = Guid.NewGuid(),
                            ProductId = productId,
                            Quantity = productItem.Quantity + quantity,
                            PayType = productItem.PayType
                        });

                        if (checkResult != UserProductAvailabilityCheckResult.Success)
                        {
                            await _dialogService.ShowAlertDialogAsync(_localizationService.GetString("GIZ_GEN_ERROR"), checkResult.ToString(), AlertDialogButtons.OK, AlertTypes.Danger);
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.LogError(ex, "User product availability check error.");
                        return;
                    }
                    finally
                    {
                    }
                }

                if (productItem.Quantity == 0 && product.ProductType == ProductType.ProductTime && product.TimeProduct?.UsageAvailability != null)
                {
                    bool verifyNotAvailableTimeProduct = false;

                    if (product.TimeProduct.UsageAvailability.DateRange)
                    {
                        if ((product.TimeProduct.UsageAvailability.StartDate.HasValue && product.TimeProduct.UsageAvailability.StartDate.Value > DateTime.Now) ||
                            (product.TimeProduct.UsageAvailability.EndDate.HasValue && product.TimeProduct.UsageAvailability.EndDate.Value < DateTime.Now))
                        {
                            verifyNotAvailableTimeProduct = true;
                        }
                    }

                    if (product.TimeProduct.UsageAvailability.TimeRange)
                    {
                        var daySecond = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second).TotalSeconds;

                        if (product.TimeProduct.UsageAvailability.DaysAvailable.Where(day => day.Day == DateTime.Now.DayOfWeek && day.DayTimesAvailable != null && day.DayTimesAvailable.Where(time => time.StartSecond <= daySecond && time.EndSecond > daySecond).Any()).Any() == false)
                        {
                            verifyNotAvailableTimeProduct = true;
                        }
                    }

                    if (verifyNotAvailableTimeProduct)
                    {
                        var dialogResult = await _dialogService.ShowAlertDialogAsync(_localizationService.GetString("GIZ_GEN_WARNING"), _localizationService.GetString("GIZ_PRODUCT_TIME_CURRENTLY_UNAVAILABLE_VERIFY"), AlertDialogButtons.YesNo, AlertTypes.Warning);
                        var dialogResponse = await dialogResult.WaitForResultAsync();
                        if (dialogResponse?.Button == AlertDialogResultButton.No)
                        {
                            return;
                        }
                    }
                }

                productItem.Quantity += quantity;

                await UpdateUserCartProductsAsync();

                productItem.RaiseChanged();

                //If current uri is not shop or product details then navigate to shop.
                var currentUri = NavigationService.GetUri();

                //TODO: A USE CONSTS?
                if (!currentUri.EndsWith("/shop") && !currentUri.Contains("/productdetails"))
                    NavigationService.NavigateTo(ClientRoutes.ShopRoute);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Failed to add user cart product.");
            }
        }

        public async Task RemoveUserCartProductAsync(int productId, int quantity = 1)
        {
            try
            {
                var productItem = await _userCartProductItemLookupService.GetStateAsync(productId);

                productItem.Quantity -= quantity;

                await UpdateUserCartProductsAsync();

                productItem.RaiseChanged();
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Failed to remove user cart product.");
            }
        }

        public async Task DeleteUserCartProductAsync(int productId)
        {
            try
            {
                var productItem = await _userCartProductItemLookupService.GetStateAsync(productId);

                productItem.Quantity = 0;

                await UpdateUserCartProductsAsync();

                productItem.RaiseChanged();
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Failed to delete user cart product.");
            }
        }

        private async Task ClearProductsAsync()
        {
            try
            {
                var productItems = await _userCartProductItemLookupService.GetStatesAsync();
                var products = productItems.Where(x => x.Quantity > 0).ToList();

                foreach (var item in products)
                {
                    item.Quantity = 0;
                }

                await UpdateUserCartProductsAsync();

                foreach (var item in products)
                {
                    item.RaiseChanged();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Failed to clear user cart products.");
            }
        }

        public async Task ClearUserCartProductsAsync()
        {
            var s = await _dialogService.ShowAlertDialogAsync(_localizationService.GetString("GIZ_GEN_VERIFY"), _localizationService.GetString("GIZ_SHOP_VERIFY_CLEAR_CART"), AlertDialogButtons.YesNo);
            if (s.Result == AddComponentResultCode.Opened)
            {
                var result = await s.WaitForResultAsync();

                if (s.Result == AddComponentResultCode.Ok && result!.Button == AlertDialogResultButton.Yes)
                    await ClearProductsAsync();
            }
        }

        private async Task UpdateUserCartProductsAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                var productItems = await _userCartProductItemLookupService.GetStatesAsync(cancellationToken);

                ViewState.Products = productItems.Where(x => x.Quantity > 0).ToList();

                foreach (var item in ViewState.Products)
                {
                    var product = await _userProductViewStateLookupService.GetStateAsync(item.ProductId, false, cancellationToken);

                    item.TotalPrice = product.UnitPrice * item.Quantity;
                    item.TotalPointsPrice = product.UnitPointsPrice * item.Quantity;
                    item.TotalPointsAward = product.UnitPointsAward * item.Quantity;
                    //TODO: A RaiseChanged ?
                }

                ViewState.Total = ViewState.Products.Where(a => a.PayType == OrderLinePayType.Cash || a.PayType == OrderLinePayType.Mixed).Select(a => a.TotalPrice).Sum();
                ViewState.PointsTotal = ViewState.Products.Where(a => a.PayType == OrderLinePayType.Points || a.PayType == OrderLinePayType.Mixed).Select(a => (a.TotalPointsPrice ?? 0)).Sum();
                ViewState.PointsAward = ViewState.Products.Select(a => (a.TotalPointsAward ?? 0)).Sum();

                if (ViewState.Total == 0)
                {
                    //Payment method is not required, it's not even visible when the total price is 0.
                    //In case the user previously had validation error for payment method, the submit is blocked.
                    //Clear this error to unblock order submit.
                    ClearError(() => ViewState.PaymentMethodId);
                }

                ViewState.RaiseChanged();
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Failed to update user cart products.");
            }
        }

        public void SetNotes(string value)
        {
            ViewState.Notes = value;
            ValidateProperty(() => ViewState.Notes);
        }

        public void SetOrderPaymentMethod(int? paymentMethodId)
        {
            ViewState.PaymentMethodId = paymentMethodId;
            ValidateProperty(() => ViewState.PaymentMethodId);
        }

        public async Task ChangeProductPayTypeAsync(int productId, OrderLinePayType payType)
        {
            try
            {
                var productItem = await _userCartProductItemLookupService.GetStateAsync(productId);
                if (productItem.PayType == payType)
                    return;

                var product = await _userProductViewStateLookupService.GetStateAsync(productId);

                //If PurchaseOptions is And then we cannot set PayType other than Mixed.
                if (product.PurchaseOptions == PurchaseOptionType.And)
                {
                    if (productItem.PayType != OrderLinePayType.Mixed)
                    {
                        productItem.PayType = OrderLinePayType.Mixed;
                    }

                    await UpdateUserCartProductsAsync();
                    productItem.RaiseChanged();

                    return;
                }

                if ((payType == OrderLinePayType.Points || productItem.PayType == OrderLinePayType.Mixed) && product.UnitPointsPrice > 0)
                {
                    var userBalanceViewState = ServiceProvider.GetRequiredService<UserBalanceViewState>();

                    if (ViewState.PointsTotal + (product.UnitPointsPrice * productItem.Quantity) > userBalanceViewState.PointsBalance)
                    {
                        await UpdateUserCartProductsAsync();
                        productItem.RaiseChanged();

                        await _dialogService.ShowAlertDialogAsync(_localizationService.GetString("GIZ_GEN_ERROR"), _localizationService.GetString("GIZ_INSUFFICIENT_POINTS"), AlertDialogButtons.OK, AlertTypes.Danger);

                        return;
                    }
                }

                productItem.PayType = payType;

                await UpdateUserCartProductsAsync();
                productItem.RaiseChanged();
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Failed to change user cart product pay type.");
            }
        }

        public async Task SubmitAsync()
        {
            if (ViewState.Total == 0)
            {
                ViewState.ShowPaymentMethods = false;
            }
            else
            {
                ViewState.ShowPaymentMethods = true;
            }

            var s = await _dialogService.ShowCheckoutDialogAsync();
            if (s.Result == AddComponentResultCode.Opened)
                _ = await s.WaitForResultAsync();
        }

        public async Task CheckoutAsync()
        {
            Validate();

            if (ViewState.IsValid != true)
                return;

            ViewState.IsLoading = true;
            ViewState.RaiseChanged();

            try
            {
                var productItems = await _userCartProductItemLookupService.GetStatesAsync();
                var products = productItems.Where(x => x.Quantity > 0).ToList();

                var userOrderModelCreate = new UserOrderModelCreate()
                {
                    UserNote = ViewState.Notes,
                    PreferredPaymentMethodId = ViewState.PaymentMethodId,
                    OrderLines = products.Select(a => new UserOrderLineModelCreate()
                    {
                        Guid = Guid.NewGuid(),
                        ProductId = a.ProductId,
                        Quantity = a.Quantity,
                        PayType = a.PayType,
                        Total = (a.PayType == OrderLinePayType.Cash || a.PayType == OrderLinePayType.Mixed) ? a.TotalPrice : 0,
                        PointsTotal = (a.PayType == OrderLinePayType.Points || a.PayType == OrderLinePayType.Mixed) ? a.TotalPointsPrice.GetValueOrDefault() : 0,
                        PointsAwardTotal = a.PayType != OrderLinePayType.Points ? a.TotalPointsAward.GetValueOrDefault() : 0
                    }).ToList()
                };

                var result = await _gizmoClient.UserOrderCreateAsync(userOrderModelCreate);

                if (result.Result != OrderResult.Failed)
                {
                    //Clear
                    await ResetAsync();
                }
                else
                {
                    ViewState.HasError = true;
                    ViewState.ErrorMessage = result.Result.ToString();

                    if (result.OrderLines != null)
                    {
                        foreach (var orderLine in result.OrderLines)
                        {
                            var requestOrderLine = userOrderModelCreate.OrderLines.Where(a => a.Guid == orderLine.Guid).FirstOrDefault();
                            if (requestOrderLine != null)
                            {
                                var product = await _userProductViewStateLookupService.GetStateAsync(requestOrderLine.ProductId);
                                ViewState.ErrorMessage += $"<br>{product.Name}: {orderLine.Result}";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "User order create error.");

                ViewState.HasError = true;
                ViewState.ErrorMessage = ex.ToString();
            }
            finally
            {
                ViewState.IsComplete = true;
                ViewState.IsLoading = false;
                ViewState.RaiseChanged();
            }
        }

        public async Task ResetAsync()
        {
            try
            {
                ViewState.Notes = null;
                ViewState.PaymentMethodId = null;

                await ClearProductsAsync();

                ViewState.IsComplete = false;
                ViewState.HasError = false;
                ViewState.ErrorMessage = string.Empty;

                ViewState.RaiseChanged();
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Failed to reset user cart products.");
            }
        }

        #endregion

        public override async Task ExecuteCommandAsync<TCommand>(TCommand command, CancellationToken cToken = default)
        {
            if (command.Params?.Any() != true)
                return;

            var paramProductId = command.Params.GetValueOrDefault("productId")?.ToString();

            if (paramProductId is null)
                return;

            var productId = int.Parse(paramProductId, NumberStyles.Number);

            var paramSize = command.Params.GetValueOrDefault("size")?.ToString();

            var size = 1;
            if (paramSize is not null)
                size = int.Parse(paramSize, NumberStyles.Number);

            switch (command.Type)
            {
                case ViewServiceCommandType.Add:
                    await AddUserCartProductAsync(productId, size);
                    break;
                case ViewServiceCommandType.Delete:
                    await RemoveUserCartProductAsync(productId, size);
                    break;
            }

            NavigationService.NavigateTo(ClientRoutes.ShopRoute);
        }

        protected override async Task OnNavigatedIn(NavigationParameters navigationParameters, CancellationToken cancellationToken = default)
        {
            await UpdateUserCartProductsAsync(cancellationToken);

            _userProductViewStateLookupService.Changed += OnUpdateUserCartProductsAsync;
        }

        protected override Task OnNavigatedOut(NavigationParameters navigationParameters, CancellationToken cancellationToken = default)
        {
            _userProductViewStateLookupService.Changed -= OnUpdateUserCartProductsAsync;

            return base.OnNavigatedOut(navigationParameters, cancellationToken);
        }

        private async void OnUpdateUserCartProductsAsync(object? _, EventArgs __) =>
            await UpdateUserCartProductsAsync();

        protected override void OnValidate(FieldIdentifier fieldIdentifier, ValidationTrigger validationTrigger)
        {
            if (fieldIdentifier.FieldEquals(() => ViewState.PaymentMethodId) && !ViewState.PaymentMethodId.HasValue && ViewState.Total > 0)
            {
                AddError(() => ViewState.PaymentMethodId, _localizationService.GetString("GIZ_GEN_VE_REQUIRED_FIELD", nameof(ViewState.PaymentMethodId)));
            }
        }
    }
}
