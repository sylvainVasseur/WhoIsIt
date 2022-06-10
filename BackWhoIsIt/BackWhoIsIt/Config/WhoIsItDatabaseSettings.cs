namespace BackWhoIsIt.Config
{
    public class WhoIsItDatabaseSettings
    {
        public string? PersonnageCollectionName { get; set; }
        public string? QuestionReponseCollectionName { get; set; }
        public string? ConnectionString { get; set; }
        public string? DatabaseName { get; set; }
    }

    public interface IWhoIsItDatabaseSettings
    {
        public string? PersonnageCollectionName { get; set; }
        public string? QuestionReponseCollectionName { get; set; }
        public string? ConnectionString { get; set; }
        public string? DatabaseName { get; set; }

    }
}
