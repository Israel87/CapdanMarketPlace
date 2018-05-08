using Nop.Web.Framework.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chams.Plugin.Payments.MarketPlace.Model
{
    public class PaymentInfoModel : BaseNopModel
    {
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string Email { get; set; }
        //public string Phonenumber { get; set; }
        //public int Amount { get; set; }
        //public string ReferenceNumber { get; set; }

        public string DescriptionText { get; set; }
        public string PBFPubKey { get; set; }
        public string LogoUrl { get; set; }
        //public string Country { get; set; }
        //public string Currency { get; set; }



    }
}
