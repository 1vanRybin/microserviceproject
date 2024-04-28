using Api.Controllers.ProjectCard.Requests;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace Api.Controllers
{
    [Route("api/projectcard")]
    [ApiController]
    public class ProjectCardController : ControllerBase
    {
        private readonly IProjectCardService _projectCardService;

        public ProjectCardController(IProjectCardService projectCardService)
        {
            _projectCardService = projectCardService;
        }

        [HttpPost("create")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> CreateVacancyAsync([FromBody] CreateProjectCardRequest createVacancy)
        {
            var res = await _projectCardService.CreateProjectCardAsync(new Domain.Entities.ProjectCard()
            {
                OwnerId = createVacancy.OwnerId,
                Description = createVacancy.Description,
                Title = createVacancy.Title
            });
            return Ok(res);
        }

        [HttpPut("update")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> UpdateVacancyAsync([FromBody] UpdateProjectCardRequest updateVacancy)
        {
            await _projectCardService.UpdateProjectCardAsync(new Domain.Entities.ProjectCard()
            {
                OwnerId=updateVacancy.OwnerId,
                Description = updateVacancy.Description,
                Title = updateVacancy.Title,
                Id = updateVacancy.ProjectCardId
            });
            return Ok();
        }

        [HttpDelete("delete")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> DeleteVacancyAsync([FromBody] Guid deleteVacancyId)
        {
            var res = await _projectCardService.DeleteProjectCardAsync(deleteVacancyId);
            return Ok(res);
        }

        [HttpGet]
        [ProducesResponseType<List<Domain.Entities.ProjectCard>>(200)]
        public async Task<IActionResult> GetVacancyListAsync()
        {
            var res = await _projectCardService.GetAllCardsAsync();
            return Ok(res);
        }
    }
}
