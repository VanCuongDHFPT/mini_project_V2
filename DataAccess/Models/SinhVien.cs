using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class SinhVien
{
    public int Id { get; set; }

    public string HoTen { get; set; } = null!;

    public int LopHocId { get; set; }

    public virtual LopHoc LopHoc { get; set; } = null!;
}
