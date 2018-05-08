using FluentValidation;
using Nop.Web.Areas.Merchant.Models.News;
using Nop.Core.Domain.News;
using Nop.Data;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Merchant.Validators.News
{
    public partial class NewsItemValidator : BaseNopValidator<NewsItemModel>
    {
        public NewsItemValidator(ILocalizationService localizationService, IDbContext dbContext)
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage(localizationService.GetResource("Merchant.ContentManagement.News.NewsItems.Fields.Title.Required"));

            RuleFor(x => x.Short).NotEmpty().WithMessage(localizationService.GetResource("Merchant.ContentManagement.News.NewsItems.Fields.Short.Required"));

            RuleFor(x => x.Full).NotEmpty().WithMessage(localizationService.GetResource("Merchant.ContentManagement.News.NewsItems.Fields.Full.Required"));

            SetDatabaseValidationRules<NewsItem>(dbContext);
        }
    }
}