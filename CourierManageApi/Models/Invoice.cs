using System;
using System.Collections.Generic;

namespace CourierManageApi.Models;

public partial class Invoice
{
    public int InvoiceId { get; set; }

    public DateTime PaymentTime { get; set; }

    public decimal Amount { get; set; }

    public string? Particular { get; set; }

    public string CreateBy { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public string? UpdateDate { get; set; }

    public bool IsActive { get; set; }

    public int CustomerId { get; set; }

    public int PaymentMethodId { get; set; }

    public int ParcelsId { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Parcel Parcels { get; set; } = null!;

    public virtual PaymentMethod PaymentMethod { get; set; } = null!;
}
