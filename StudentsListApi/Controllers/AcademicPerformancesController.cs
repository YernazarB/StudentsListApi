using Microsoft.AspNetCore.Mvc;
using StudentsListApi.Interfaces;

namespace StudentsListApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcademicPerformancesController : ControllerBase
    {
        private readonly IAcademicPerformanceRepository _service;
        public AcademicPerformancesController(IAcademicPerformanceRepository service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult GetAcademicPerformances()
        {
            return Ok(_service.GetAcademicPerformances());
        }
    }
}
