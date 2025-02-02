﻿using System;
using System.Collections.Generic;

namespace CourierManageApi.Models;

public partial class Staff
{
    public int StaffId { get; set; }

    public string? StaffName { get; set; }

    public string? Email { get; set; }

    public string CreateBy { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public bool IsActive { get; set; }

    public int DesignationId { get; set; }

    public virtual ICollection<BranchesStaff> BranchesStaffs { get; set; } = new List<BranchesStaff>();

    public virtual Designation Designation { get; set; } = null!;
}
