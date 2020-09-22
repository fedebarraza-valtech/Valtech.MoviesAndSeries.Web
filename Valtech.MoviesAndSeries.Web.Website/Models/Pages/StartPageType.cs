using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace Valtech.MoviesAndSeries.Web.Website.Models.Pages
{
    [ContentType(
        DisplayName = "Start Page",
        GUID = "55C499F5-7825-43B7-A428-6C601B8A2300")]
    public class StartPageType : DefaultPageType
    {
        [Display(
            Name = "Title",
            Order = 10)]
        public virtual string Title { get; set; }

        [Display(
            Name = "Sub Title",
            Order = 20)]
        public virtual string SubTitle { get; set; }

        [Display(
            Name = "Content",
            Order = 30)]
        public virtual ContentArea Content { get; set; }
    }
}