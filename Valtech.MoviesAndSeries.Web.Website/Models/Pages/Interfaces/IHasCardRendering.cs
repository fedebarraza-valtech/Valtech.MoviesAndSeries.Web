using EPiServer.Core;

namespace Valtech.MoviesAndSeries.Web.Website.Models.Pages.Interfaces
{
    public interface IHasCardRendering : IContent
    {
        ContentReference Image { get; }

        string Title { get; }

        string Author { get; }
    }
}
