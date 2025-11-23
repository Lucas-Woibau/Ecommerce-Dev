using EcommerceDev.Application.Common;
using EcommerceDev.Core.Entities;

namespace EcommerceDev.Application.Queries.Products.GetAllProducts
{
    public class GetAllProductsQueryHandler : IHandler<GetAllProductsQuery, ResultViewModel<List<GetAllProductsItemViewModel>>>
    {
        public Task<ResultViewModel<List<GetAllProductsItemViewModel>>> HandleAsync(GetAllProductsQuery request)
        {
            throw new NotImplementedException();
        }
    }
}
