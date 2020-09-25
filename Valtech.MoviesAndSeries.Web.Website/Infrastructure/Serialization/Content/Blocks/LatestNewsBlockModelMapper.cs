using System.Collections.Generic;
using System.Linq;
using EPiServer;
using EPiServer.ContentApi.Core;
using EPiServer.ContentApi.Core.Configuration;
using EPiServer.ContentApi.Core.Serialization;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;
using Valtech.MoviesAndSeries.Web.Website.Infrastructure.Serialization.Content.Blocks.DTO;
using Valtech.MoviesAndSeries.Web.Website.Models.Blocks;
using Valtech.MoviesAndSeries.Web.Website.Models.Pages.Interfaces;

namespace Valtech.MoviesAndSeries.Web.Website.Infrastructure.Serialization.Content.Blocks
{
    [ServiceConfiguration(typeof(LatestNewsBlockModelMapper), Lifecycle = ServiceInstanceScope.Singleton)]
    internal class LatestNewsBlockModelMapper : ContentModelMapperBase
    {
        private readonly IUrlResolver _urlResolver;
        private readonly IContentLoader _contentLoader;

        public LatestNewsBlockModelMapper(IContentTypeRepository contentTypeRepository,
            ReflectionService reflectionService, IContentModelReferenceConverter contentModelService,
            IPropertyConverterResolver propertyConverterResolver, IContentVersionRepository contentVersionRepository,
            ContentLoaderService contentLoaderService, UrlResolverService urlResolverService,
            ContentApiConfiguration apiConfig, IUrlResolver urlResolver, IContentLoader contentLoader) : base(contentTypeRepository, reflectionService, contentModelService,
            contentVersionRepository, contentLoaderService, urlResolverService, apiConfig, propertyConverterResolver)
        {
            _urlResolver = urlResolver;
            _contentLoader = contentLoader;
        }

        public override bool CanHandle<T>(T content)
        {
            return content is LatestNewsBlockType;
        }

        public override int Order => 100;

        protected override IDictionary<string, object> ExtractCustomProperties(IContent content,
            ConverterContext contentMappingContext)
        {
            var properties = base.ExtractCustomProperties(content, contentMappingContext);

            var latestNewsBlock = content as LatestNewsBlockType;

            if (latestNewsBlock == null)
            {
                return properties;
            }

            if (latestNewsBlock.News == null || latestNewsBlock.News.IsEmpty)
            {
                return properties;
            }

            properties.Remove("news");
            properties.Add("news", latestNewsBlock.News.FilteredItems?.Select(Map).ToList());

            return properties;
        }

        private NewsCardDto Map(ContentAreaItem item)
        {
            if (!_contentLoader.TryGet(item.ContentLink, out IHasCardRendering cardRendering))
            {
                return null;
            }

            return new NewsCardDto
            {
                Title = cardRendering.Title,
                ImageUrl = _urlResolver.GetUrl(cardRendering.Image),
                Author = cardRendering.Author,
                LinkUrl = _urlResolver.GetUrl(cardRendering.ContentLink)
            };
        }
    }
}