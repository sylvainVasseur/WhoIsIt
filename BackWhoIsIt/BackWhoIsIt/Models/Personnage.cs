namespace BackWhoIsIt.Models
{
    public class Personnage
    {
        public string Id { get; set; }
        public string Genre { get; set; }
        public string Espece { get; set; }
        public string CouleurYeux { get; set; }
        public string CouleurCheveux { get; set; }
        public bool hasLunette { get; set; }
        public bool hasChapeau { get; set; }
        public bool isWizard { get; set; }
        public string urlPhoto { get; set; }

    }
}
