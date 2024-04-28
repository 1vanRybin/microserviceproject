using Domain.Entities;
using Domain.Interfaces;
using Services.Interfaces;

namespace Services.Services
{
    public class ProjectCardService : IProjectCardService
    {
        private readonly ICheckUser _checkUser;
        private readonly IStoreProjectCard _storeProjectCard;

        public ProjectCardService(ICheckUser checkUser, IStoreProjectCard storeProjectCard)
        {
            _checkUser = checkUser;
            _storeProjectCard = storeProjectCard;
        }
        public async Task<Guid> CreateProjectCardAsync(ProjectCard projectCard)
        {
            var id = await projectCard.SaveAsync(_checkUser, _storeProjectCard);
            return id;
        }

        public async Task<bool> DeleteProjectCardAsync(Guid id)
        {
            var response = await _storeProjectCard.DeleteAsync(id);
            return response;
        }

        public async Task<IEnumerable<ProjectCard>> GetAllCardsAsync()
        {
            var cards = await _storeProjectCard.GetAllAsync();
            return cards;
        }

        public async Task<bool> UpdateProjectCardAsync(ProjectCard projectCard)
        {
            var respose = await _storeProjectCard.UpdateAsync(projectCard);
            return respose;
        }
    }
}
