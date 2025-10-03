using DataAccess.DTO;
using DataAccess.Models;
using DataAccess.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SinhVienController : ControllerBase
    {
        private readonly IStudentRepository studentRepository;

        public SinhVienController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetStudent()
        {
            var list = studentRepository.GetSinhViens();
            return Ok(list);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var list = studentRepository.SinhVien(id);
            return Ok(list);
        }

        [HttpPost("InsertStudents")]
        public async Task<IActionResult> InsertStudents([FromBody] SinhVienRequest sinhVien)
        {
            var entity = await studentRepository.InsertSinhVien(sinhVien); // ✅ dùng await

            return CreatedAtAction(
                nameof(GetStudentById), // Action GET theo id
                new { id = entity.Id }, // route values
                entity                  // body response
            );
        }

        [HttpPut("{id}")]

        public async Task<IActionResult> Update(int id, SinhVienRequest sv)
        {
            await studentRepository.UpdateSinhVien(sv, id);
            return NoContent();

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
          await studentRepository.DeleteSinhVien(id);
            return NoContent();
        }



    }
}
