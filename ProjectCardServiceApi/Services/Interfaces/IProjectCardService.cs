using Domain.Entities;

namespace Services.Interfaces
{
    public interface IProjectCardService
    {
        Task<IEnumerable<ProjectCard>> GetAllCardsAsync();
        Task<Guid> CreateProjectCardAsync(ProjectCard projectCard);
        Task<bool> UpdateProjectCardAsync(ProjectCard projectCard);
        Task<bool> DeleteProjectCardAsync(Guid id);
    }
}
