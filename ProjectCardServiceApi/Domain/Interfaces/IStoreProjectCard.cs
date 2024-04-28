using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IStoreProjectCard
    {
        Task<ProjectCard> GetByIdAsync(Guid id);
        Task<IEnumerable<ProjectCard>> GetAllAsync();
        Task<Guid> AddAsync(ProjectCard projectCard);
        Task<bool> UpdateAsync(ProjectCard projectCard);
        Task<bool> DeleteAsync(Guid id);
    }
}
