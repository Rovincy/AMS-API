using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class Activation
    {
        public int Id { get; set; }
        public int? ProviderId { get; set; }
        public string ProviderIdMaster { get; set; }
        public string ProviderIdDataEntry { get; set; }
        public string LastSerialNumber { get; set; }
        public string InsCompany { get; set; }
        public string ActivationIpaddress { get; set; }
        public string ActivationPassSalt { get; set; }
        public string ActivationKey { get; set; }
        public string FacilityStatus { get; set; }
        public string SyncBatchNo { get; set; }
        public string SyncBatchNoUpdate { get; set; }
        public string SyncBatchNoDelete { get; set; }
        public byte? SyncInsert { get; set; }
        public byte? SyncUpdate { get; set; }
        public byte? SyncDelete { get; set; }
        public string IdInscompany { get; set; }
    }
}
