using Microsoft.AspNetCore.Mvc;
using StudentsListApi.Interfaces;

namespace StudentsListApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcademicPerformancesController : ControllerBase
    {
        private readonly IAcademicPerformanceRepository _repository;
        public AcademicPerformancesController(IAcademicPerformanceRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult GetAcademicPerformances()
        {
            return Ok(_repository.GetAcademicPerformances());
        }
    }
}
