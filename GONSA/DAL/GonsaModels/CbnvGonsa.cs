using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class CbnvGonsa
{
    public string MaNhanVien { get; set; } = null!;

    public string? TenNhanVien { get; set; }

    public string? PhongBan { get; set; }

    public string? ChucVu { get; set; }

    public string? Email { get; set; }

    public string? SoDt { get; set; }

    public virtual ICollection<UserMiddleware> UserMiddlewares { get; set; } = new List<UserMiddleware>();
}
