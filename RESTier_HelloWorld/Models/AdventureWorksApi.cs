using System.Linq;
using Microsoft.Restier.Providers.EntityFramework;

namespace RESTier_HelloWorld.Models
{
    public class AdventureWorksApi : EntityFrameworkApi<AdventureWorksLT>
    {
        protected IQueryable<Product> OnFilterProduct(IQueryable<Product> entitySet)
        {
            return entitySet.Where(s => s.ProductID % 3 == 0).AsQueryable();
        }
    }
}