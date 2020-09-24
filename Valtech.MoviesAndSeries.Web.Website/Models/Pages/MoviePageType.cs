using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace Valtech.MoviesAndSeries.Web.Website.Models.Pages
{
    [ContentType(
        DisplayName = "Movie Page",
        GUID = "C5E26DCE-6998-44D6-AB1D-8B011679E79A")]
    public class MoviePageType : DefaultPageType
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
            Name = "Release Date",
            Order = 20)]
        public virtual DateTime ReleaseDate { get; set; }

        [Display(
            Name = "Directors",
            Order = 30)]
        public virtual string Directors { get; set; }

        [Display(
            Name = "Cast",
            Order = 40)]
        public virtual string Cast { get; set; }
    }
}