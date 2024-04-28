using System;
using System.Diagnostics;
using Domain.Entities;
using Domain.Interfaces;
using Infastracted;
using Medo;
using Microsoft.EntityFrameworkCore;

namespace Infastracted.Data
{
    public class ProjectCardRepository : IStoreProjectCard
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ProjectCardRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<Guid> AddAsync(ProjectCard projectCard)
        {
            var projectCardId = new Uuid7().ToGuid();
            projectCard.Id = projectCardId;
            await _applicationDbContext.Set<ProjectCard>().AddAsync(projectCard);
            await _applicationDbContext.SaveChangesAsync();

            return projectCardId;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            _applicationDbContext.Set<ProjectCard>().Remove(await GetByIdAsync(id));
            var isSuccess = await _applicationDbContext.SaveChangesAsync() > 0;

            return isSuccess;
        }

        public async Task<IEnumerable<ProjectCard>> GetAllAsync()
        {
            var res = await _applicationDbContext.Set<ProjectCard>().ToListAsync();

            return res;
        }

        public async Task<ProjectCard> GetByIdAsync(Guid id)
        {
            var res = await _applicationDbContext.Set<ProjectCard>().FindAsync(id);

            if (res is null)
            {
                throw new Exception("Data not found");
            }

            return res;
        }

        public async Task<bool> UpdateAsync(ProjectCard projectCard)
        {
            _applicationDbContext.Set<ProjectCard>().Update(projectCard);
            var isSuccess = await _applicationDbContext.SaveChangesAsync() > 0;

            return isSuccess;
        }
    }
}
