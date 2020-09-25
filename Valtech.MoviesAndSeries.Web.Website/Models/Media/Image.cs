using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace Valtech.MoviesAndSeries.Web.Website.Models.Media
{
    [ContentType(
        DisplayName = "Image File", 
        GUID = "DC2AEA80-731E-4FFA-94C5-273E5D2A9DC7", 
        AvailableInEditMode = false)]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,ico,gif,bmp,png")]
    public class Image : ImageData
    {
    }
}