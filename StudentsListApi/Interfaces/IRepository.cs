using System.Collections.Generic;
using System.Threading.Tasks;
using StudentsListApi.Dtos;

namespace StudentsListApi.Interfaces
{
    public interface IRepository
    {
        Task<List<StudentDto>> Get();
        Task<StudentDto> Create(StudentDto dto);
        Task Update(StudentDto dto);
        Task Delete(int id);
    }
}