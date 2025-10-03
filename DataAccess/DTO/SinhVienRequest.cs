using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public partial class SinhVienRequest
    {
        public int Id { get; set; }

        public string HoTen { get; set; } = null!;

        public int LopHocId { get; set; }
    }
}
