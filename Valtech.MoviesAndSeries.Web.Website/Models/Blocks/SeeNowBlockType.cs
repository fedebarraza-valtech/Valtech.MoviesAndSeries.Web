using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace Valtech.MoviesAndSeries.Web.Website.Models.Blocks
{
    [ContentType(
        DisplayName = "See Now Block",
        GUID = "84C4B78A-DE45-4335-B2CB-3DFA64C0801B")]
    public class SeeNowBlockType : BlockData
    {
        [Display(
            Name = "Image",
            Order = 5)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [Display(
            Name = "Movie Title",
            Order = 10)]
        public virtual string MovieTitle { get; set; }

        [Display(
            Name = "Brand",
            Order = 15)]
        public virtual string Brand { get; set; }

        [Display(
            Name = "Description",
            Order = 20)]
        [UIHint(UIHint.Textarea)]
        public virtual string Description { get; set; }

        [Display(
            Name = "Cta Label",
            Order = 25)]
        public virtual string CtaLabel { get; set; }
    }
}