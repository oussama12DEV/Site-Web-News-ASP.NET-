namespace ProjetNews.Models
{
    public class Categorie
    {
        public int Id { get; set; } 
        public String Name { get; set; }
        public String  Description { get; set; }
        public List<News> News { get; set; }

       
    }
    
}
