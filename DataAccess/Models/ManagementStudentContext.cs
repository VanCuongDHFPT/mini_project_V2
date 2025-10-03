using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Models;

public partial class ManagementStudentContext : DbContext
{
    public ManagementStudentContext()
    {
    }

    public ManagementStudentContext(DbContextOptions<ManagementStudentContext> options)
        : base(options)
    {
    }

    public virtual DbSet<LopHoc> LopHocs { get; set; }

    public virtual DbSet<SinhVien> SinhViens { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Seed dữ liệu cho bảng LopHoc
        modelBuilder.Entity<LopHoc>().HasData(
            new LopHoc { Id = 1, TenLop = "CNTT 1" },
            new LopHoc { Id = 2, TenLop = "CNTT 2" }
        );

        modelBuilder.Entity<SinhVien>().HasData(
             new SinhVien { Id = 1, HoTen = "Nguyen Van A", LopHocId = 1 },
                new SinhVien { Id = 2, HoTen = "Tran Thi B", LopHocId = 2 }
            );
    }


}
