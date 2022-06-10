using BackWhoIsIt.Models;

namespace BackWhoIsIt.Services
{
    public interface IQuestionReponseService
    {
        public Task<List<QuestionReponse>> GetAsync();

        public Task<QuestionReponse> GetAsync(string id);

        public Task CreateAsync(QuestionReponse newQuestionReponse);

        public Task UpdateAsync(string id, QuestionReponse updatedQuestionReponse);

        public Task RemoveAsync(string id);
    }
}
