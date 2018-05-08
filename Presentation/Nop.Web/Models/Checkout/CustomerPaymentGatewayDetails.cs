using Nop.Web.Framework.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nop.Web.Models.Checkout
{
    public class CustomerPaymentGatewayDetails : BaseNopModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PaymentDescription { get; set; }
        public string Amount { get; set; }

    }
}
