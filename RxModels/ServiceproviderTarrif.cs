using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class ServiceproviderTarrif
    {
        public int Id { get; set; }
        public string ServiceProvider { get; set; }
        public string TarrifType { get; set; }
        public string TariffName { get; set; }
        public double? UnitCost { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string TariffId { get; set; }
        public string ServiceProviderId { get; set; }
        public string ServiceName { get; set; }
        public string InsCompany { get; set; }
        public string RxProviderId { get; set; }
        public string InsItemCode { get; set; }
        public string Status { get; set; }
        public string IdInscompany { get; set; }
        public string SyncBatchNo { get; set; }
        public string SyncBatchNoUpdate { get; set; }
        public string SyncBatchDelete { get; set; }
        public bool? SyncInsert { get; set; }
        public bool? SyncUpdate { get; set; }
        public bool? SyncDelete { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public int? SyncInsertCounts { get; set; }
        public int? SyncUpdateCounts { get; set; }
    }
}
