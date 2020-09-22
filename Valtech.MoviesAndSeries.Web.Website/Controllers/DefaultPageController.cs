using System.Web.Mvc;
using EPiServer.Web.Mvc;
using Valtech.MoviesAndSeries.Web.Website.Models.Pages;

namespace Valtech.MoviesAndSeries.Web.Website.Controllers
{
    public class DefaultPageController : PageController<DefaultPageType>
    {
        public ViewResult Index(DefaultPageType currentPage)
        {
            return View(currentPage);
        }
    }
}