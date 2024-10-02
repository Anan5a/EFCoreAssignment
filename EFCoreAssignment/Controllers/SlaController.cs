using EFCoreAssignment.DataAccess;
using EFCoreAssignment.Models;
using EFCoreAssignment.Models.DTOs;
using EFCoreAssignment.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]

    public class SlaController : ControllerBase
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IConfiguration _configuration;
        public SlaController(ApplicationDbContext applicationDbContext, IConfiguration configuration)
        {
            _applicationDbContext = applicationDbContext;
            _configuration = configuration;
        }

        [HttpGet]
        [Route("getSlaList")]
        public async Task<ActionResult<ResponseModel<IEnumerable<Sla>>>> Index()
        {
            var allSlas = await _applicationDbContext.Slas.ToListAsync();

            return Ok(CustomResponseMessage.OkCustom("Query successful.", allSlas));

        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<ResponseModel<Sla>>> UpsertSla([FromBody] SlaRequestDto slaRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(CustomResponseMessage.ErrorCustom("Bad Request", "Invalid request parameters?"));

            }
            Sla? sla;



            try
            {
                if (slaRequestDto.SlaId.HasValue && slaRequestDto.SlaId > 0)
                {
                    sla = await _applicationDbContext.Slas.FindAsync(slaRequestDto.SlaId.Value);
                    if (sla == null)
                    {
                        return NotFound(CustomResponseMessage.ErrorCustom("Error", "SLA not found."));
                    }
                    sla.SlaAnniversary = slaRequestDto.FrequencyType;
                    sla.SlaEscalationDays = slaRequestDto.EscalationDays;
                    sla.SlaExcludeWeekends = true;
                    sla.SlaFrequencyPosition = slaRequestDto.FrequencyPosition;
                    sla.SlaFrequencyTransaction = slaRequestDto.FrequencyTransaction;
                    sla.SlaName = slaRequestDto.SlaName;
                    sla.SlaReminderDays = slaRequestDto.ReminderDays; _applicationDbContext.Slas.Update(sla);
                }
                else
                {
                    sla = new Sla
                    {
                        SlaAnniversary = slaRequestDto.FrequencyType,
                        SlaEscalationDays = slaRequestDto.EscalationDays,
                        SlaExcludeWeekends = true,
                        SlaFrequencyPosition = slaRequestDto.FrequencyPosition,
                        SlaFrequencyTransaction = slaRequestDto.FrequencyTransaction,
                        SlaName = slaRequestDto.SlaName,
                        SlaReminderDays = slaRequestDto.ReminderDays,
                    };
                    await _applicationDbContext.Slas.AddAsync(sla);
                }

                await _applicationDbContext.SaveChangesAsync();
                return Ok(CustomResponseMessage.OkCustom("Action successful.", sla));
            }
            catch (Exception ex)
            {
                return StatusCode(500, CustomResponseMessage.ErrorCustom("Error", "An error occurred while saving the SLA. Please try again later."));
            }

        }

        [HttpDelete]
        [Route("{slaId}")]
        public async Task<ActionResult<ResponseModel<string>>> DeleteSla(int slaId)
        {
            if (slaId < 1)
            {
                return BadRequest(CustomResponseMessage.ErrorCustom("Bad Request", "Invalid request parameters?"));

            }
            try
            {
                var sla = await _applicationDbContext.Slas.FindAsync(slaId);
                if (sla == null)
                {
                    return NotFound(CustomResponseMessage.ErrorCustom("Error", "SLA not found."));
                }
                //try to find a node
                var node = await _applicationDbContext.Nodes.Where(node => node.SlaId == slaId).FirstOrDefaultAsync();

                if (node != null)
                {
                    return StatusCode(StatusCodes.Status403Forbidden, CustomResponseMessage.ErrorCustom("Error", "SLA has active node."));
                }
                //delete sla

                _applicationDbContext.Slas.Remove(sla);


                await _applicationDbContext.SaveChangesAsync();
                return Ok(CustomResponseMessage.OkCustom("Action successful.", "SLA deleted"));
            }
            catch (Exception ex)
            {
                return StatusCode(500, CustomResponseMessage.ErrorCustom("Error", "An error occurred while saving the SLA. Please try again later."));
            }

        }


    }
}
