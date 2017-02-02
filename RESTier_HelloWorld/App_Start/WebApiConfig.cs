using System.Web.Http;
using Microsoft.Restier.Providers.EntityFramework;
using Microsoft.Restier.Publishers.OData;
using Microsoft.Restier.Publishers.OData.Batch;
using RESTier_HelloWorld.Models;

namespace RESTier_HelloWorld
{
    public static class WebApiConfig
    {
        public static async void Register(HttpConfiguration config)
        {
            await config.MapRestierRoute<EntityFrameworkApi<AdventureWorksLT>>(
                "AdventureWorksLT",
                "api/AdventureWorksLT",
                new RestierBatchHandler(GlobalConfiguration.DefaultServer));

            //await config.MapRestierRoute<AdventureWorksApi>(
            //    "AdventureWorksLT",
            //    "api/AdventureWorksLT",
            //    new RestierBatchHandler(GlobalConfiguration.DefaultServer));
        }
    }
}
