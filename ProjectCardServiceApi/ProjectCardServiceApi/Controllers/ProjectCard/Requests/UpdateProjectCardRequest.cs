namespace Api.Controllers.ProjectCard.Requests
{
    public record UpdateProjectCardRequest : CreateProjectCardRequest
    {
        public required Guid ProjectCardId { get; set; }
    }
}
