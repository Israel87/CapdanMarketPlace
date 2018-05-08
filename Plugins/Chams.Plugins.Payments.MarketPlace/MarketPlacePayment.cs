using Chams.Plugin.Payments.MarketPlace;
using Microsoft.AspNetCore.Http;
using Nop.Core;
using Nop.Core.Domain.Orders;
using Nop.Core.Plugins;
using Nop.Services.Configuration;
using Nop.Services.Customers;
using Nop.Services.Localization;
using Nop.Services.Orders;
using Nop.Services.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chams.Plugins.Payments.MarketPlace
{
    public class MarketPlacePayment : BasePlugin, IPaymentMethod
    {

        #region Fields

        private readonly MarketPlaceChamsSwitchSettings _marketPlaceChamsSwitchSettings;
        private readonly ILocalizationService _localizationService;
        private readonly IOrderTotalCalculationService _orderTotalCalculationService;
        private readonly ISettingService _settingService;
        private readonly IWebHelper _webHelper;
        private readonly IWorkContext _workContext;
        private readonly IStoreContext _storeContext;
        private readonly ICustomerService _customerService;

        #endregion

        #region Ctor

        public MarketPlacePayment(MarketPlaceChamsSwitchSettings marketPlaceChamsSwitchSettings,
            ILocalizationService localizationService,
            IOrderTotalCalculationService orderTotalCalculationService,
            ISettingService settingService,
            IWebHelper webHelper,
            IWorkContext workContext,
            IStoreContext storeContext,
            ICustomerService customerService)
        {
            this._marketPlaceChamsSwitchSettings = marketPlaceChamsSwitchSettings;
            this._localizationService = localizationService;
            this._orderTotalCalculationService = orderTotalCalculationService;
            this._settingService = settingService;
            this._webHelper = webHelper;
            this._workContext = workContext;
            this._storeContext = storeContext;
            this._customerService = customerService;
        }

        #endregion

        public bool SupportCapture => throw new NotImplementedException();

        public bool SupportPartiallyRefund => throw new NotImplementedException();

        public bool SupportRefund => throw new NotImplementedException();

        public bool SupportVoid => throw new NotImplementedException();

        public RecurringPaymentType RecurringPaymentType => throw new NotImplementedException();

        //    public PaymentMethodType PaymentMethodType => throw new NotImplementedException();

        public bool SkipPaymentInfo => throw new NotImplementedException();

        public string PaymentMethodDescription => throw new NotImplementedException();

        public CancelRecurringPaymentResult CancelRecurringPayment(CancelRecurringPaymentRequest cancelPaymentRequest)
        {
            throw new NotImplementedException();
        }

        public bool CanRePostProcessPayment(Order order)
        {
            if (order == null)
                throw new ArgumentNullException(nameof(order));

            //it's not a redirection payment method. So we always return false
            return false;
        }

        public CapturePaymentResult Capture(CapturePaymentRequest capturePaymentRequest)
        {
            throw new NotImplementedException();
        }

        public decimal GetAdditionalHandlingFee(IList<ShoppingCartItem> cart)
        {
            throw new NotImplementedException();
        }

        public ProcessPaymentRequest GetPaymentInfo(IFormCollection form)
        {
            return new ProcessPaymentRequest();
        }

        //public override string GetConfigurationPageUrl()
        //{
        //    return $"{_webHelper.GetStoreLocation()}Admin/PaymentCheckMoneyOrder/Configure";
        //}

        public string GetPublicViewComponentName()
        {
            return "ChamsSwitchGateway";
        }

        public bool HidePaymentMethod(IList<ShoppingCartItem> cart)
        {
            throw new NotImplementedException();
        }

        public void PostProcessPayment(PostProcessPaymentRequest postProcessPaymentRequest)
        {
            postProcessPaymentRequest = new PostProcessPaymentRequest();
           
        }

        public ProcessPaymentResult ProcessPayment(ProcessPaymentRequest processPaymentRequest)
        {
            return new ProcessPaymentResult();
        }

        public ProcessPaymentResult ProcessRecurringPayment(ProcessPaymentRequest processPaymentRequest)
        {
            throw new NotImplementedException();
        }

        public RefundPaymentResult Refund(RefundPaymentRequest refundPaymentRequest)
        {
            throw new NotImplementedException();
        }

        public IList<string> ValidatePaymentForm(IFormCollection form)
        {
            throw new NotImplementedException();
        }

        public VoidPaymentResult Void(VoidPaymentRequest voidPaymentRequest)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a payment method type
        /// </summary>
        public PaymentMethodType PaymentMethodType
        {
            get { return PaymentMethodType.Standard; }
        }


        /// <summary>
        /// Gets a payment method description that will be displayed on checkout pages in the public store
        /// </summary>
        //public string PaymentMethodDescription
        //{
        //    //return description of this payment method to be display on "payment method" checkout step. good practice is to make it localizable
        //    //for example, for a redirection payment method, description may be like this: "You will be redirected to PayPal site to complete the payment"
        //    get { return _localizationService.GetResource("Plugins.Payment.CheckMoneyOrder.PaymentMethodDescription"); }


        //}
    }

}