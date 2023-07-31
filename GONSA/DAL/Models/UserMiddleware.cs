using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class UserMiddleware
{
    public string Username { get; set; } = null!;

    public string Passwd { get; set; } = null!;

    public string? MaNhanVien { get; set; }

    public string? UserPrivilege { get; set; }

    public string? Note { get; set; }

    public virtual CbnvGonsa? MaNhanVienNavigation { get; set; }
}
