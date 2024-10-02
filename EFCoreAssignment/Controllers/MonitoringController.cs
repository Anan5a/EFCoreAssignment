using EFCoreAssignment.DataAccess;
using EFCoreAssignment.Models;
using EFCoreAssignment.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]

    public class MonitoringController : ControllerBase
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IConfiguration _configuration;
        public MonitoringController(ApplicationDbContext applicationDbContext, IConfiguration configuration)
        {
            _applicationDbContext = applicationDbContext;
            _configuration = configuration;
        }


        [HttpGet]
        [Route("getMonitoringList")]
        public async Task<ActionResult<ResponseModel<IEnumerable<Monitoring>>>> Index()
        {
            var allMonitoring = await _applicationDbContext.Monitorings.ToListAsync();

            return Ok(CustomResponseMessage.OkCustom("Query successful.", allMonitoring));

        }
    }
}
