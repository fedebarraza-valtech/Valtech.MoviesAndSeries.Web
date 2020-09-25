using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using Valtech.MoviesAndSeries.Web.Website.Models.Blocks;
using Valtech.MoviesAndSeries.Web.Website.Models.Pages.Interfaces;

namespace Valtech.MoviesAndSeries.Web.Website.Models.Pages
{
    [ContentType(
        DisplayName = "News Page",
        GUID = "BB7803E3-0300-4DC7-A39B-F4D06BF479D5")]
    public class NewsPageType : DefaultPageType, IHasCardRendering
    {
        [Display(
            Name = "Image",
            Order = 5)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [Display(
            Name = "Title",
            Order = 10)]
        public virtual string Title { get; set; }

        [Display(
            Name = "Author",
            Order = 20)]
        public virtual string Author { get; set; }

        [Display(
            Name = "Body",
            Order = 25)]
        public virtual XhtmlString Body { get; set; }

        [Display(
            Name = "Content Body",
            Order = 30)]
        [AllowedTypes(typeof(LatestNewsBlockType))]
        public virtual ContentArea ContentBody { get; set; }
    }
}