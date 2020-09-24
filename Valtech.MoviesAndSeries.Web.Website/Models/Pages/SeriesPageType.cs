using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using Valtech.MoviesAndSeries.Web.Website.Models.Properties;

namespace Valtech.MoviesAndSeries.Web.Website.Models.Pages
{
    [ContentType(
        DisplayName = "Series Page",
        GUID = "199794B9-DA3C-4337-9794-DACB37C58979")]
    public class SeriesPageType : DefaultPageType
    {
        [Display(
            Name = "Title",
            Order = 10)]
        public virtual string Title { get; set; }

        [Display(
            Name = "Description",
            Order = 15)]
        [UIHint(UIHint.Textarea)]
        public virtual string Description { get; set; }

        [Display(
            Name = "Airs",
            Order = 20)]
        public virtual DateTime AirsDate { get; set; }

        [Display(
            Name = "Channel",
            Order = 30)]
        public virtual Channel Channel { get; set; }

        [Display(
            Name = "Creators",
            Order = 35)]
        public virtual string Creators { get; set; }

        [Display(
            Name = "Cast",
            Order = 40)]
        public virtual string Cast { get; set; }
    }
}