using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using StudentsListApi.Dtos;
using StudentsListApi.Interfaces;

namespace StudentsListApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentsRepository _service;
        public StudentsController(IStudentsRepository service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<List<StudentDto>> GetStudents()
        {
            return await _service.Get();
        }

        [HttpPost]
        public async Task<StudentDto> Create(StudentDto dto)
        {
            if (dto == null)
            {
                return null;
            }

            return await _service.Create(dto);
        }

        [HttpPut]
        public async Task Update(StudentDto dto)
        {
            if (dto == null)
            {
                return;
            }

            await _service.Update(dto);
        }

        [HttpDelete]
        public async Task Delete(int id)
        {
            await _service.Delete(id);
        }
    }
}
