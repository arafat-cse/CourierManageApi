using System;
using System.Collections.Generic;

namespace CourierManageApi.Models;

public partial class CompanyLocation
{
    public int LocationId { get; set; }

    public string? LocationName { get; set; }

    public int CompanyId { get; set; }

    public virtual Company Company { get; set; } = null!;
}
