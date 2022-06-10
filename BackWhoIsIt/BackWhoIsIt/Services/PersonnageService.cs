using BackWhoIsIt.Config;
using BackWhoIsIt.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BackWhoIsIt.Services
{
    public class PersonnageService: IPersonnageService
    {
        private readonly IMongoCollection<Personnage> _personnageCollection;

        public PersonnageService(IOptions<WhoIsItDatabaseSettings> whoIsItDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                whoIsItDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                whoIsItDatabaseSettings.Value.DatabaseName);

            _personnageCollection = mongoDatabase.GetCollection<Personnage>(
                whoIsItDatabaseSettings.Value.PersonnageCollectionName);
        }

        public async Task<List<Personnage>> GetAsync() =>
          await _personnageCollection.Find(_ => true).ToListAsync();

        public async Task<Personnage> GetAsync(string id) =>
            await _personnageCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Personnage newPersonnage) =>
            await _personnageCollection.InsertOneAsync(newPersonnage);

        public async Task UpdateAsync(string id, Personnage updatedPersonnage) =>
            await _personnageCollection.ReplaceOneAsync(x => x.Id == id, updatedPersonnage);

        public async Task RemoveAsync(string id) =>
            await _personnageCollection.DeleteOneAsync(x => x.Id == id);
    }
}
