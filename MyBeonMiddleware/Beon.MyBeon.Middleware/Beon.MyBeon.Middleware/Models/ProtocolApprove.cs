﻿using Beon.MyBeon.Middleware.Models.BaseModels;

namespace Beon.MyBeon.Middleware.Models;

public class ProtocolApprove : BaseModel
{
    public string? Status { get; set; }  
    public string? ProtocolApproveType { get; set; }
	public string ProtocolApproveTypeName
	{
		get
		{
			switch (ProtocolApproveType)
			{
				case "CustomerDevir":
					return "Müşteri Devir";
				default:
					return "Diğer";
			}
		}
	}
	public Customer? Customer { get; set; }
    public CustomerContact? CustomerContact { get; set; }
    public DateTime? CreatedOn { get; set; }
    public DateTime? ProtocolOn { get; set; }
    public ApplicationUser? Owner { get; set; }
    public Customer? DevirCustomer { get; set; }
    public CustomerContact? DevirCustomerContact { get; set; }
    public FileData? DevirProtocolDocument { get; set; }
    public ReasonForRejectionProtocolApprove? ReasonForRejection { get; set; }
    public DateTime? RejectionOn { get; set; }
    public ApplicationUser? RejectionBy { get; set; }
    public DateTime? ProtocolApproveOn { get; set; }
    public string? DevirContractType { get; set; }  
    public Contract? DevirContract { get; set; }
    public Contract? NewContract { get; set; }

}
