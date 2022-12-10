using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Web.Controllers
{
    public class SearchController : Controller
    {

        private readonly BookServise bookServise;

        public SearchController(BookServise bookServise)
        {
            this.bookServise = bookServise;
        }
        public IActionResult Index(string query)
        {
            var books = bookServise.GetAllByQuery(query);

            return View(books);
        }
    }
}
