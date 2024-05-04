using System;
using System.Collections.Generic;

namespace DCI_TSP_API.UserModels;

public partial class ClaimsDetailsComment
{
    public long Id { get; set; }

    public int? ServerId { get; set; }

    public string? ProviderId { get; set; }

    public string? Claimno { get; set; }

    public string? Comment { get; set; }

    public string? InsCompany { get; set; }

    public DateTime? DateUpdated { get; set; }

    public string? SyncBatchNo { get; set; }

    public string? SyncBatchNoUpdate { get; set; }

    public string? SyncBatchDelete { get; set; }

    public bool? SyncInsert { get; set; }

    public bool? SyncUpdate { get; set; }

    public bool? SyncDelete { get; set; }

    public string? IdInscompany { get; set; }

    public string? User { get; set; }

    public int? SyncInsertCounts { get; set; }

    public int? SyncUpdateCounts { get; set; }
}
