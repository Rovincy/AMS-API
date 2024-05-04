﻿using System;
using System.Collections.Generic;

namespace DCI_TSP_API.UserModels;

public partial class ClaimComment
{
    public int Id { get; set; }

    public int? ServerId { get; set; }

    public string? InsCompany { get; set; }

    public string? ProviderId { get; set; }

    public string ProcessClaimNo { get; set; } = null!;

    public string Comment { get; set; } = null!;

    public DateTime? DateTime { get; set; }

    public string? Username { get; set; }

    public string? Type { get; set; }

    public int? UserId { get; set; }

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
