using System;
using StudentsListApi.Enums;

namespace StudentsListApi.Data.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string FullName { get; set; }
        public AcademicPerformance AcademicPerformance { get; set; }
    }
}