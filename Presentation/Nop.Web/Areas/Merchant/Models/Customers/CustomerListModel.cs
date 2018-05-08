using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Customers
{
    public partial class CustomerListModel : BaseNopModel
    {
        public CustomerListModel()
        {
            SearchCustomerRoleIds = new List<int>();
            AvailableCustomerRoles = new List<SelectListItem>();
        }

        [NopResourceDisplayName("Merchant.Customers.Customers.List.CustomerRoles")]
        public IList<int> SearchCustomerRoleIds { get; set; }
        public IList<SelectListItem> AvailableCustomerRoles { get; set; }

        [NopResourceDisplayName("Merchant.Customers.Customers.List.SearchEmail")]
        public string SearchEmail { get; set; }

        [NopResourceDisplayName("Merchant.Customers.Customers.List.SearchUsername")]
        public string SearchUsername { get; set; }
        public bool UsernamesEnabled { get; set; }

        [NopResourceDisplayName("Merchant.Customers.Customers.List.SearchFirstName")]
        public string SearchFirstName { get; set; }
        [NopResourceDisplayName("Merchant.Customers.Customers.List.SearchLastName")]
        public string SearchLastName { get; set; }

        [NopResourceDisplayName("Merchant.Customers.Customers.List.SearchDateOfBirth")]
        public string SearchDayOfBirth { get; set; }
        [NopResourceDisplayName("Merchant.Customers.Customers.List.SearchDateOfBirth")]
        public string SearchMonthOfBirth { get; set; }
        public bool DateOfBirthEnabled { get; set; }

        [NopResourceDisplayName("Merchant.Customers.Customers.List.SearchCompany")]
        public string SearchCompany { get; set; }
        public bool CompanyEnabled { get; set; }

        [NopResourceDisplayName("Merchant.Customers.Customers.List.SearchPhone")]
        public string SearchPhone { get; set; }
        public bool PhoneEnabled { get; set; }

        [NopResourceDisplayName("Merchant.Customers.Customers.List.SearchZipCode")]
        public string SearchZipPostalCode { get; set; }
        public bool ZipPostalCodeEnabled { get; set; }

        [NopResourceDisplayName("Merchant.Customers.Customers.List.SearchIpAddress")]
        public string SearchIpAddress { get; set; }

        public bool AvatarEnabled { get; internal set; }

    }
}