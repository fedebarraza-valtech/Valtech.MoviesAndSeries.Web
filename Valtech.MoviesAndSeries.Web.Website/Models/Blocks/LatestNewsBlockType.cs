using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using Valtech.MoviesAndSeries.Web.Website.Models.Pages;

namespace Valtech.MoviesAndSeries.Web.Website.Models.Blocks
{
    [ContentType(
        DisplayName = "Latest News Block",
        GUID = "6CF80517-44C3-412F-8081-C9CEB1DDD1E4")]
    public class LatestNewsBlockType : BlockData
    {
        [Display(
            Name = "Heading",
            Order = 10)]
        public virtual string Heading { get; set; }

        [Display(
            Name = "News",
            Order = 20)]
        [AllowedTypes(typeof(NewsPageType))]
        public virtual ContentArea News { get; set; }
    }
}