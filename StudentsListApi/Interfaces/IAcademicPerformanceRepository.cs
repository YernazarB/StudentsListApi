using System.Collections.Generic;
using StudentsListApi.Dtos;

namespace StudentsListApi.Interfaces
{
    public interface IAcademicPerformanceRepository
    {
        List<AcademicPerformanceDto> GetAcademicPerformances();
    }
}