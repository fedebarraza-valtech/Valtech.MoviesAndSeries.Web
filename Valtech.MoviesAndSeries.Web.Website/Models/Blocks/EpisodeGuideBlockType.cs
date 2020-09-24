using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace Valtech.MoviesAndSeries.Web.Website.Models.Blocks
{
    [ContentType(
        DisplayName = "Episode Guide Block",
        GUID = "188766BD-F19E-48BD-86E4-13FA38CBCAE4")]
    public class EpisodeGuideBlockType : BlockData
    {
        [Display(
            Name = "Heading",
            Order = 10)]
        public virtual string Heading { get; set; }

        [Display(
            Name = "Seasons",
            Order = 20)]
        public virtual ContentArea Seasons { get; set; }
    }
}