using System;
using System.Collections.Generic;

namespace DAL.TestModels;

public partial class SinhVien
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int Idlop { get; set; }

    public virtual Lop IdlopNavigation { get; set; } = null!;
}
