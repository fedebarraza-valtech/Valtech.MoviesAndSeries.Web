using EPiServer.ContentApi.Core.Serialization;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using Valtech.MoviesAndSeries.Web.Website.Models.Blocks;

namespace Valtech.MoviesAndSeries.Web.Website.Infrastructure.Serialization.Content.Blocks
{
    [ServiceConfiguration(typeof(IContentConverterProvider), Lifecycle = ServiceInstanceScope.Singleton)]
    internal class LatestNewsBlockContentConverterProvider : IContentConverterProvider
    {
        private readonly LatestNewsBlockModelMapper _modelMapper;

        public int SortOrder => 200;

        public LatestNewsBlockContentConverterProvider(LatestNewsBlockModelMapper modelMapper)
        {
            _modelMapper = modelMapper;
        }

        public IContentConverter Resolve(IContent content)
        {
            return content is LatestNewsBlockType ? _modelMapper : null;
        }
	}
}