using Nop.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chams.Plugin.Payments.MarketPlace
{
    public class MarketPlaceChamsSwitchSettings : ISettings
    {


        /// <summary>
        /// Gets or sets a description text
        /// </summary>
        public string DescriptionText { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to "additional fee" is specified as percentage. true - percentage, false - fixed value.
        /// </summary>
        public bool AdditionalFeePercentage { get; set; }

        /// <summary>
        /// Gets or sets an additional fee
        /// </summary>
        public decimal AdditionalFee { get; set; }

        // PBFPubKey
        public string PBFPubKey { get; set; }

        // Logo Url 
        public string LogoUrl { get; set; }

        // Country  
        public string Country { get; set; }

        // Currency
        public string Currency { get; set; }

        // Email
        public string Email { get; set; }



        /// <summary>
        /// Gets or sets a value indicating whether shippable products are required in order to display this payment method during checkout
        /// </summary>
        public bool ShippableProductRequired { get; set; }
    }
}
