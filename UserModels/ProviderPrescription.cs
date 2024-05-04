using System;
using System.Collections.Generic;

namespace DCI_TSP_API.UserModels;

public partial class ProviderPrescription
{
    public int Id { get; set; }

    public string? InsCompany { get; set; }

    public string ProcessClaimNo { get; set; } = null!;

    public string PrescriptionDocument { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string ProviderId { get; set; } = null!;

    public string ProviderUserId { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? SyncBatchNo { get; set; }
}
