using BackWhoIsIt.Models;

namespace BackWhoIsIt.Services
{
    public interface IPersonnageService
    {
        public Task<List<Personnage>> GetAsync();

        public Task<Personnage> GetAsync(string id);

        public Task CreateAsync(Personnage newPersonnage);

        public Task UpdateAsync(string id, Personnage updatedPersonnage);

        public Task RemoveAsync(string id);
    }
}
