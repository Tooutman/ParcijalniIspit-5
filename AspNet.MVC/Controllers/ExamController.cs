using AspNet.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNet.MVC.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            //Autors
            var autors = new List<Author>()
            {
                new Author() { Name ="F. Scott Fitzgerald", BirthYear = 1896, Residence= "Los Angeles" },
                new Author() { Name = "George Orwell", BirthYear = 1903, Residence = "London" },
                new Author() { Name = "Harper Lee", BirthYear = 1926, Residence = "Monroeville" },
                new Author() { Name = "Aldous Huxley", BirthYear = 1894, Residence = "Los Angeles" },
                new Author() { Name = "Herman Melville", BirthYear = 1819, Residence = "New York" }
            };
            //books
            var books = new List<Book>()
            {
                new Book() { Name = "The Great Gatsby", Author = autors.FirstOrDefault(), Pages = 180 },
                new Book() { Name = "1984", Author = autors.FirstOrDefault(a => a.Name == "George Orwell"), Pages = 328 },
                new Book() { Name = "To Kill a Mockingbird", Author = autors.FirstOrDefault(a => a.Name =="Harper Lee"), Pages = 281 },
                new Book() { Name = "Brave New World", Author = autors.FirstOrDefault(a => a.Name =="Aldous Huxley"), Pages = 311 },
                new Book() { Name = "Moby-Dick", Author = autors.FirstOrDefault(a => a.Name =="Herman Melville"), Pages = 635 }

            };

            return View(books);
        }
    }
}
