namespace ProjetNews.Models
{
    public class News
    {
        public int Id { get; set; } 
        public String  Title { get; set; }
        public String Image { get; set;}
        public String Topic { get; set;}
        public DateTime Date { get; set;} 
       

        public int CategorieId { get; set;}
        public Categorie Categorie { get; set;} 
        
        

    }
}
