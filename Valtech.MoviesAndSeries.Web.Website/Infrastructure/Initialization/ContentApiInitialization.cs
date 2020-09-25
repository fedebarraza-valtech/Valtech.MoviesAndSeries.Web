using EPiServer.ContentApi.Cms;
using EPiServer.ContentApi.Core.Configuration;
using EPiServer.ContentApi.Routing;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using Valtech.MoviesAndSeries.Web.Website.Infrastructure.Routing;

namespace Valtech.MoviesAndSeries.Web.Website.Infrastructure.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(ServiceContainerInitialization), typeof(ContentApiCmsInitialization))]
    public class ContentApiInitialization : IConfigurableModule
    {
        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            context.Services.AddTransient<RoutingEventHandler, CustomContentApiRoutingEventHandler>();

            // set minimumRoles to empty to allow anonymous calls (for visitors to view site in view mode)
            context.Services.Configure<ContentApiConfiguration>(config =>
            {
                config.Default()
                    .SetMinimumRoles(string.Empty)
                    .SetSiteDefinitionApiEnabled(true);
                config.EnablePreviewFeatures = true;
            });
        }

        public void Initialize(InitializationEngine context)
        {
        }

        public void Uninitialize(InitializationEngine context)
        {
        }
    }
}