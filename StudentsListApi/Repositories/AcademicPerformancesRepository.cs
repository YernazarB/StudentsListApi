using System;
using System.Collections.Generic;
using System.Linq;
using StudentsListApi.Common;
using StudentsListApi.Dtos;
using StudentsListApi.Enums;
using StudentsListApi.Interfaces;

namespace StudentsListApi.Repositories
{
    public class AcademicPerformancesRepository : IAcademicPerformanceRepository
    {
        public List<AcademicPerformanceDto> GetAcademicPerformances()
        {
            return Enum.GetValues<AcademicPerformance>()
                .Select(academicPerformance => new AcademicPerformanceDto
                {
                    Id = (int) academicPerformance, 
                    Name = academicPerformance.DisplayString()
                }).ToList();
        }
    }
}