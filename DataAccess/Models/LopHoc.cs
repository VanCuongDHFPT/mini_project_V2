using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class LopHoc
{
    public int Id { get; set; }

    public string TenLop { get; set; } = null!;

    public virtual ICollection<SinhVien> SinhViens { get; set; } = new List<SinhVien>();
}
