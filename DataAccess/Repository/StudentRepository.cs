using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DTO;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository
{
    public class StudentRepository : IStudentRepository

    {
        private readonly ManagementStudentContext managementStudentContext;

        public StudentRepository(ManagementStudentContext managementStudentContext)
        {
            this.managementStudentContext = managementStudentContext;
        }

        public async Task DeleteSinhVien(int id)
        {
            var existing = await managementStudentContext.SinhViens.FindAsync(id);
            managementStudentContext.Remove(existing);
            await managementStudentContext.SaveChangesAsync();
        }

        public async Task<List<SinhVien>> GetSinhViens() => managementStudentContext.SinhViens.ToList();

        public async Task<SinhVien> InsertSinhVien(SinhVienRequest sinhVien)
        {
            try
            {
                var entity = new SinhVien()
                {
                    HoTen = sinhVien.HoTen,
                    LopHocId = sinhVien.LopHocId

                };
                managementStudentContext.Add(entity);
                managementStudentContext.SaveChanges();

                return entity;
              

            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException?.Message ?? ex.Message);
            }
        }

        public async Task<SinhVien> SinhVien(int id)
        {
            return managementStudentContext.SinhViens.FirstOrDefault(x => x.Id == id);
            
        }

        public async Task<SinhVien?> UpdateSinhVien(SinhVienRequest sinhVien, int id)
        {
            // tìm sinh viên theo id
            var existing = await managementStudentContext.SinhViens.FindAsync(id);
            if (existing == null)
            {
                return null; // không tìm thấy
            }

            // cập nhật thông tin
            existing.HoTen = sinhVien.HoTen;
            existing.LopHocId = sinhVien.LopHocId;

            // lưu thay đổi
            await managementStudentContext.SaveChangesAsync();

            return existing;
        }

    }
}
