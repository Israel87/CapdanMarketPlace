using System;
using System.ComponentModel.DataAnnotations;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Mvc.Models;

namespace Nop.Web.Areas.Merchant.Models.Common
{
    public partial class MaintenanceModel : BaseNopModel
    {
        public MaintenanceModel()
        {
            DeleteGuests = new DeleteGuestsModel();
            DeleteAbandonedCarts = new DeleteAbandonedCartsModel();
            DeleteExportedFiles = new DeleteExportedFilesModel();
        }

        public DeleteGuestsModel DeleteGuests { get; set; }
        public DeleteAbandonedCartsModel DeleteAbandonedCarts { get; set; }
        public DeleteExportedFilesModel DeleteExportedFiles { get; set; }
        
        #region Nested classes

        public partial class DeleteGuestsModel : BaseNopModel
        {
            [NopResourceDisplayName("Merchant.System.Maintenance.DeleteGuests.StartDate")]
            [UIHint("DateNullable")]
            public DateTime? StartDate { get; set; }

            [NopResourceDisplayName("Merchant.System.Maintenance.DeleteGuests.EndDate")]
            [UIHint("DateNullable")]
            public DateTime? EndDate { get; set; }

            [NopResourceDisplayName("Merchant.System.Maintenance.DeleteGuests.OnlyWithoutShoppingCart")]
            public bool OnlyWithoutShoppingCart { get; set; }

            public int? NumberOfDeletedCustomers { get; set; }
        }

        public partial class DeleteAbandonedCartsModel : BaseNopModel
        {
            [NopResourceDisplayName("Merchant.System.Maintenance.DeleteAbandonedCarts.OlderThan")]
            [UIHint("Date")]
            public DateTime OlderThan { get; set; }

            public int? NumberOfDeletedItems { get; set; }
        }

        public partial class DeleteExportedFilesModel : BaseNopModel
        {
            [NopResourceDisplayName("Merchant.System.Maintenance.DeleteExportedFiles.StartDate")]
            [UIHint("DateNullable")]
            public DateTime? StartDate { get; set; }

            [NopResourceDisplayName("Merchant.System.Maintenance.DeleteExportedFiles.EndDate")]
            [UIHint("DateNullable")]
            public DateTime? EndDate { get; set; }

            public int? NumberOfDeletedFiles { get; set; }
        }

        #endregion
    }
}
