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
        private readonly IStudentsRepository _repository;
        public StudentsController(IStudentsRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<List<StudentDto>> GetStudents()
        {
            return await _repository.Get();
        }

        [HttpPost]
        public async Task<StudentDto> Create(StudentDto dto)
        {
            if (dto == null)
            {
                return null;
            }

            return await _repository.Create(dto);
        }

        [HttpPut]
        public async Task Update(StudentDto dto)
        {
            if (dto == null)
            {
                return;
            }

            await _repository.Update(dto);
        }

        [HttpDelete]
        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }
    }
}
