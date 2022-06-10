using BackWhoIsIt.Config;
using BackWhoIsIt.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BackWhoIsIt.Services
{
    public class QuestionReponseService: IQuestionReponseService
    {
        private readonly IMongoCollection<QuestionReponse> _questionReponseCollection;

        public QuestionReponseService(IOptions<WhoIsItDatabaseSettings> whoIsItDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                whoIsItDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                whoIsItDatabaseSettings.Value.DatabaseName);

            _questionReponseCollection = mongoDatabase.GetCollection<QuestionReponse>(
                whoIsItDatabaseSettings.Value.QuestionReponseCollectionName);
        }
        public async Task CreateAsync(QuestionReponse newQuestionReponse) => 
            await _questionReponseCollection.InsertOneAsync(newQuestionReponse);

        public async Task<List<QuestionReponse>> GetAsync() =>
            await _questionReponseCollection.Find(x => true).ToListAsync();


        public async Task<QuestionReponse> GetAsync(string id) =>
            await _questionReponseCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task RemoveAsync(string id) =>
            await _questionReponseCollection.DeleteOneAsync(x => x.Id == id);

        public async Task UpdateAsync(string id, QuestionReponse updatedQuestionReponse) =>
            await _questionReponseCollection.ReplaceOneAsync(x => x.Id == id, updatedQuestionReponse);
    }
}
