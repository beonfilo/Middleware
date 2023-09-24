﻿using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class ProtocolApprove : BaseModel
{
    public string Status { get; set; } = string.Empty;
    public string ProtocolApproveType { get; set; } = string.Empty;
    public Customer? Customer { get; set; }
    public CustomerContact? CustomerContact { get; set; }
    public DateTime CreatedOn { get; set; } = default;
    public DateTime ProtocolOn { get; set; } = default;
    public ApplicationUser? Owner { get; set; }
    public FileData? DevirProtocolDocument { get; set; }
    public ReasonForRejectionProtocolApprove? ReasonForRejection { get; set; }
    public DateTime RejectionOn { get; set; } = default;
    public ApplicationUser? RejectionBy { get; set; }
    public DateTime ProtocolApproveOn { get; set; } = default;
    public string DevirContractType { get; set; } = string.Empty;
    public Contract? DevirContract { get; set; }
    public Contract? NewContract { get; set; }

}
