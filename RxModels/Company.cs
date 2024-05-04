using Newtonsoft.Json;
using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class Company
    {
        public int Id { get; set; }
        public string company { get; set; }

        public string CompanyID { get; set; }

        public string CompanyCode { get; set; }

        public DateTime? PolicyStartDate { get; set; }

        public DateTime? PolicyEndDate { get; set; }

        public DateTime? StatusUpdateTime { get; set; }

        public string InsCompany { get; set; }

        public string CompanyType { get; set; }

        public int? GroupType { get; set; }

        public string PrefixCode { get; set; }

        public string ContactPerson { get; set; }

        public string ContactEmail { get; set; }

        public string CompanyStatus { get; set; }

        public double? ExchangeRate { get; set; }

        public DateTime? ExchangeDateTime { get; set; }

        public string SyncBatchNo { get; set; }

        public string SyncBatchNoUpdate { get; set; }

        public string SyncBatchDelete { get; set; }

        public bool? SyncInsert { get; set; }

        public bool? SyncUpdate { get; set; }

        public bool? SyncDelete { get; set; }

        public string IdInsCompany { get; set; }

        public string UsePin { get; set; }

        public string ShowLimit { get; set; }

        public float? LimitPercentage { get; set; }

        public int? SyncInsertCounts { get; set; }

        public int? SyncUpdateCounts { get; set; }

        public float? InPatientNotifyAlert { get; set; }

        public float? OutPatientNotifyAlert { get; set; }

        public DateTime? PrintStartDate { get; set; }

        public DateTime? PrintEndDate { get; set; }

        public string ProRate { get; set; }

        public string TelephoneNo { get; set; }

        public double? OutPatient { get; set; }

        public double? InPatient { get; set; }

    }
}
