namespace Api.Controllers.ProjectCard.Requests
{
    public record CreateProjectCardRequest
    {
        public required Guid OwnerId { get; init; }

        public required string Title { get; init; }

        public required string Description { get; init; }
    }
}
