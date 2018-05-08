using Nop.Core.Domain.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nop.Web.Models.Order
{
    public class PaymentGatewayDetailsModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public Decimal Amount { get; set; }
        public int CustomerID { get; set; }
        public string OrderGUID { get; set; }
        public PaymentStatus Status { get; set; }
        public string PhoneNumber { get; set; }

    }
}
