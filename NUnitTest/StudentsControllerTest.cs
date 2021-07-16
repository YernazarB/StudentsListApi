using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using StudentsListApi.Controllers;
using StudentsListApi.Dtos;
using StudentsListApi.Enums;
using StudentsListApi.Interfaces;

namespace NUnitTest
{
    [TestFixture]
    public class StudentsControllerTest
    {
        private StudentsController _controller;

        [SetUp]
        public void SetUp()
        {
            var mock = new Mock<IStudentsRepository>();
            mock.Setup(r => r.Get()).Returns(GetTestStudents());
            _controller = new StudentsController(mock.Object);
        }

        [Test]
        public async Task GetMethodTest()
        {
            var students = await _controller.GetStudents();
            Assert.AreEqual(students.Count, (await GetTestStudents()).Count);
        }

        private Task<List<StudentDto>> GetTestStudents()
        {
            return Task.FromResult(new List<StudentDto>
            {
                new()
                {
                    AcademicPerformance = AcademicPerformance.Satisfactorily,
                    Date = new DateTime(2000, 3, 15),
                    FullName = "Test Student 1",
                    Id = 1
                },
                new()
                {
                    AcademicPerformance = AcademicPerformance.Excellent,
                    Date = new DateTime(1995, 1, 22),
                    FullName = "Test Student 2",
                    Id = 2
                }
            });
        }
    }
}