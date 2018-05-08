using System.ComponentModel.DataAnnotations;
using FluentValidation.Attributes;
using Nop.Web.Areas.Merchant.Validators.Messages;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Messages
{
    [Validator(typeof(EmailAccountValidator))]
    public partial class EmailAccountModel : BaseNopEntityModel
    {
        [DataType(DataType.EmailAddress)]
        [NopResourceDisplayName("Merchant.Configuration.EmailAccounts.Fields.Email")]
        public string Email { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.EmailAccounts.Fields.DisplayName")]
        public string DisplayName { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.EmailAccounts.Fields.Host")]
        public string Host { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.EmailAccounts.Fields.Port")]
        public int Port { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.EmailAccounts.Fields.Username")]
        public string Username { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.EmailAccounts.Fields.Password")]
        [DataType(DataType.Password)]
        [NoTrim]
        public string Password { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.EmailAccounts.Fields.EnableSsl")]
        public bool EnableSsl { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.EmailAccounts.Fields.UseDefaultCredentials")]
        public bool UseDefaultCredentials { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.EmailAccounts.Fields.IsDefaultEmailAccount")]
        public bool IsDefaultEmailAccount { get; set; }

        [NopResourceDisplayName("Merchant.Configuration.EmailAccounts.Fields.SendTestEmailTo")]
        public string SendTestEmailTo { get; set; }
    }
}