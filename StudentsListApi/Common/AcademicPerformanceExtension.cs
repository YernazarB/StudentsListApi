using System;
using StudentsListApi.Enums;

namespace StudentsListApi.Common
{
    public static class AcademicPerformanceExtension
    {
        public static string DisplayString(this AcademicPerformance academicPerformance)
        {
            string displayString;
            switch (academicPerformance)
            {
                case AcademicPerformance.Unsatisfactory:
                    displayString = "Неудовлетворительно";
                    break;
                case AcademicPerformance.Satisfactorily:
                    displayString = "Удовлетворительно";
                    break;
                case AcademicPerformance.Good:
                    displayString = "Хорошо";
                    break;
                case AcademicPerformance.Excellent:
                    displayString = "Отлично";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(academicPerformance), academicPerformance, null);
            }

            return displayString;
        }
    }
}