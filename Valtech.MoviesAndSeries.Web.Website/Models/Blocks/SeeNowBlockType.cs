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
            Name = "Heading",
            Order = 10)]
        public virtual string Heading { get; set; }

        [Display(
            Name = "Description",
            Order = 15)]
        [UIHint(UIHint.Textarea)]
        public virtual string Description { get; set; }
    }
}