using System;
using System.Collections.Generic;

namespace CourierManageApi.Models;

public partial class UserDetail
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? PassWord { get; set; }
}
