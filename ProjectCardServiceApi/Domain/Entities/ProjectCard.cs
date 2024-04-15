using Core.Dal;
using Domain.Interfaces;

namespace Domain.Entities
{
    public record ProjectCard : BaseEntityDal<Guid>
    {
        public required Guid OwnerId { get; init; }
        public required string Title { get; init; }
        public string Description { get; init; }
        public async Task<Guid> SaveAsync(ICheckUser checkUser, IStoreProjectCard storeProjectCard)
        {
            await checkUser.CheckUserExistAsync(OwnerId);

            return await storeProjectCard.AddAsync(this);
        }
    }
}
