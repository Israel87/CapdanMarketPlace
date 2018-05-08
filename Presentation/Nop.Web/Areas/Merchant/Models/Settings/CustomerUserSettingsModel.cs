using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Settings
{
    public partial class CustomerUserSettingsModel : BaseNopModel
    {
        public CustomerUserSettingsModel()
        {
            CustomerSettings = new CustomerSettingsModel();
            AddressSettings = new AddressSettingsModel();
            DateTimeSettings = new DateTimeSettingsModel();
            ExternalAuthenticationSettings = new ExternalAuthenticationSettingsModel();
        }

        public CustomerSettingsModel CustomerSettings { get; set; }
        public AddressSettingsModel AddressSettings { get; set; }
        public DateTimeSettingsModel DateTimeSettings { get; set; }
        public ExternalAuthenticationSettingsModel ExternalAuthenticationSettings { get; set; }

        #region Nested classes

        public partial class CustomerSettingsModel : BaseNopModel
        {
            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.UsernamesEnabled")]
            public bool UsernamesEnabled { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.AllowUsersToChangeUsernames")]
            public bool AllowUsersToChangeUsernames { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.CheckUsernameAvailabilityEnabled")]
            public bool CheckUsernameAvailabilityEnabled { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.UsernameValidationEnabled")]
            public bool UsernameValidationEnabled { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.UsernameValidationUseRegex")]
            public bool UsernameValidationUseRegex { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.UsernameValidationRule")]
            public string UsernameValidationRule { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.UserRegistrationType")]
            public int UserRegistrationType { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.AllowCustomersToUploadAvatars")]
            public bool AllowCustomersToUploadAvatars { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.DefaultAvatarEnabled")]
            public bool DefaultAvatarEnabled { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.ShowCustomersLocation")]
            public bool ShowCustomersLocation { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.ShowCustomersJoinDate")]
            public bool ShowCustomersJoinDate { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.AllowViewingProfiles")]
            public bool AllowViewingProfiles { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.NotifyNewCustomerRegistration")]
            public bool NotifyNewCustomerRegistration { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.RequireRegistrationForDownloadableProducts")]
            public bool RequireRegistrationForDownloadableProducts { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.HideDownloadableProductsTab")]
            public bool HideDownloadableProductsTab { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.HideBackInStockSubscriptionsTab")]
            public bool HideBackInStockSubscriptionsTab { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.CustomerNameFormat")]
            public int CustomerNameFormat { get; set; }
            
            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.PasswordMinLength")]
            public int PasswordMinLength { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.UnduplicatedPasswordsNumber")]
            public int UnduplicatedPasswordsNumber { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.PasswordRecoveryLinkDaysValid")]
            public int PasswordRecoveryLinkDaysValid { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.DefaultPasswordFormat")]
            public int DefaultPasswordFormat { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.PasswordLifetime")]
            public int PasswordLifetime { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.FailedPasswordAllowedAttempts")]
            public int FailedPasswordAllowedAttempts { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.FailedPasswordLockoutMinutes")]
            public int FailedPasswordLockoutMinutes { get; set; }
            
            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.NewsletterEnabled")]
            public bool NewsletterEnabled { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.NewsletterTickedByDefault")]
            public bool NewsletterTickedByDefault { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.HideNewsletterBlock")]
            public bool HideNewsletterBlock { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.NewsletterBlockAllowToUnsubscribe")]
            public bool NewsletterBlockAllowToUnsubscribe { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.StoreLastVisitedPage")]
            public bool StoreLastVisitedPage { get; set; }
            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.StoreIpAddresses")]
            public bool StoreIpAddresses { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.EnteringEmailTwice")]
            public bool EnteringEmailTwice { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.GenderEnabled")]
            public bool GenderEnabled { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.DateOfBirthEnabled")]
            public bool DateOfBirthEnabled { get; set; }
            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.DateOfBirthRequired")]
            public bool DateOfBirthRequired { get; set; }
            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.DateOfBirthMinimumAge")]
            [UIHint("Int32Nullable")]
            public int? DateOfBirthMinimumAge { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.CompanyEnabled")]
            public bool CompanyEnabled { get; set; }
            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.CompanyRequired")]
            public bool CompanyRequired { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.StreetAddressEnabled")]
            public bool StreetAddressEnabled { get; set; }
            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.StreetAddressRequired")]
            public bool StreetAddressRequired { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.StreetAddress2Enabled")]
            public bool StreetAddress2Enabled { get; set; }
            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.StreetAddress2Required")]
            public bool StreetAddress2Required { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.ZipPostalCodeEnabled")]
            public bool ZipPostalCodeEnabled { get; set; }
            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.ZipPostalCodeRequired")]
            public bool ZipPostalCodeRequired { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.CityEnabled")]
            public bool CityEnabled { get; set; }
            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.CityRequired")]
            public bool CityRequired { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.CountyEnabled")]
            public bool CountyEnabled { get; set; }
            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.CountyRequired")]
            public bool CountyRequired { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.CountryEnabled")]
            public bool CountryEnabled { get; set; }
            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.CountryRequired")]
            public bool CountryRequired { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.StateProvinceEnabled")]
            public bool StateProvinceEnabled { get; set; }
            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.StateProvinceRequired")]
            public bool StateProvinceRequired { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.PhoneEnabled")]
            public bool PhoneEnabled { get; set; }
            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.PhoneRequired")]
            public bool PhoneRequired { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.FaxEnabled")]
            public bool FaxEnabled { get; set; }
            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.FaxRequired")]
            public bool FaxRequired { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.AcceptPrivacyPolicyEnabled")]
            public bool AcceptPrivacyPolicyEnabled { get; set; }
        }

        public partial class AddressSettingsModel : BaseNopModel
        {
            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.AddressFormFields.CompanyEnabled")]
            public bool CompanyEnabled { get; set; }
            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.AddressFormFields.CompanyRequired")]
            public bool CompanyRequired { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.AddressFormFields.StreetAddressEnabled")]
            public bool StreetAddressEnabled { get; set; }
            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.AddressFormFields.StreetAddressRequired")]
            public bool StreetAddressRequired { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.AddressFormFields.StreetAddress2Enabled")]
            public bool StreetAddress2Enabled { get; set; }
            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.AddressFormFields.StreetAddress2Required")]
            public bool StreetAddress2Required { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.AddressFormFields.ZipPostalCodeEnabled")]
            public bool ZipPostalCodeEnabled { get; set; }
            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.AddressFormFields.ZipPostalCodeRequired")]
            public bool ZipPostalCodeRequired { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.AddressFormFields.CityEnabled")]
            public bool CityEnabled { get; set; }
            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.AddressFormFields.CityRequired")]
            public bool CityRequired { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.AddressFormFields.CountyEnabled")]
            public bool CountyEnabled { get; set; }
            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.AddressFormFields.CountyRequired")]
            public bool CountyRequired { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.AddressFormFields.CountryEnabled")]
            public bool CountryEnabled { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.AddressFormFields.StateProvinceEnabled")]
            public bool StateProvinceEnabled { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.AddressFormFields.PhoneEnabled")]
            public bool PhoneEnabled { get; set; }
            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.AddressFormFields.PhoneRequired")]
            public bool PhoneRequired { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.AddressFormFields.FaxEnabled")]
            public bool FaxEnabled { get; set; }
            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.AddressFormFields.FaxRequired")]
            public bool FaxRequired { get; set; }
        }

        public partial class DateTimeSettingsModel : BaseNopModel
        {
            public DateTimeSettingsModel()
            {
                AvailableTimeZones = new List<SelectListItem>();
            }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.AllowCustomersToSetTimeZone")]
            public bool AllowCustomersToSetTimeZone { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.DefaultStoreTimeZone")]
            public string DefaultStoreTimeZoneId { get; set; }

            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.DefaultStoreTimeZone")]
            public IList<SelectListItem> AvailableTimeZones { get; set; }
        }

        public partial class ExternalAuthenticationSettingsModel : BaseNopModel
        {
            [NopResourceDisplayName("Merchant.Configuration.Settings.CustomerUser.AllowCustomersToRemoveAssociations")]
            public bool AllowCustomersToRemoveAssociations { get; set; }
        }

        #endregion
    }
}