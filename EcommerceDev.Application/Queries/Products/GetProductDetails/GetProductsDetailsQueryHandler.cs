using EcommerceDev.Application.Common;
using EcommerceDev.Core.Entities;

namespace EcommerceDev.Application.Queries.Products.GetProductDetails
{
    public class GetProductsDetailsQueryHandler : IHandler<GetProductsDetailsQuery, ResultViewModel<ProductDetailsViewModel>>
    {
        public Task<ResultViewModel<ProductDetailsViewModel>> HandleAsync(GetProductsDetailsQuery request)
        {
            throw new NotImplementedException();
        }
    }
}
