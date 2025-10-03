using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DTO;
using DataAccess.Models;

namespace DataAccess.Repository
{
    public interface IStudentRepository
    {
        Task<List<SinhVien>> GetSinhViens();
        Task<SinhVien> SinhVien(int id);
        Task<SinhVien> InsertSinhVien(SinhVienRequest sinhVien);
        Task DeleteSinhVien(int id);
        Task<SinhVien> UpdateSinhVien(SinhVienRequest sinhVien, int id);

    }
}
