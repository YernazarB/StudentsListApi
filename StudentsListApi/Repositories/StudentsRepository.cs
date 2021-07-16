using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentsListApi.Data;
using StudentsListApi.Data.Entities;
using StudentsListApi.Dtos;
using StudentsListApi.Interfaces;

namespace StudentsListApi.Services
{
    public class StudentsRepository : IStudentsRepository
    {
        private readonly StudentsListDbContext _dbContext;
        public StudentsRepository(StudentsListDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<StudentDto>> Get()
        {
            return await _dbContext.Students.Select(x => new StudentDto
            {
                AcademicPerformance = x.AcademicPerformance,
                Date = x.Date,
                FullName = x.FullName,
                Id = x.Id
            }).ToListAsync();
        }

        public async Task<StudentDto> Create(StudentDto dto)
        {
            var entity = new Student
            {
                Date = dto.Date,
                FullName = dto.FullName,
                AcademicPerformance = dto.AcademicPerformance
            };
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            dto.Id = entity.Id;
            return dto;
        }

        public async Task Update(StudentDto dto)
        {
            var entity = await _dbContext.Students.FirstOrDefaultAsync(x => x.Id == dto.Id);
            if (entity == null)
            {
                return;
            }

            entity.AcademicPerformance = dto.AcademicPerformance;
            entity.Date = dto.Date;
            entity.FullName = dto.FullName;
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await _dbContext.Students.FirstOrDefaultAsync(x => x.Id == id);
            if (entity == null)
            {
                return;
            }

            _dbContext.Students.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}