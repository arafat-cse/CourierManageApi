using System;
using System.Collections.Generic;

namespace CourierManageApi.Models;

public partial class Company
{
    public int CompanyId { get; set; }

    public string CompanyName { get; set; } = null!;

    public virtual ICollection<Bank> Banks { get; set; } = new List<Bank>();

    public virtual ICollection<CompanyLocation> CompanyLocations { get; set; } = new List<CompanyLocation>();
}
