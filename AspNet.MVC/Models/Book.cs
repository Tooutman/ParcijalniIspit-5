namespace AspNet.MVC.Models
{
    public class Book
    {
        public  string Name { get; set; }
        public int Pages { get; set; }

        public Author Author { get; set; }
    }
}
