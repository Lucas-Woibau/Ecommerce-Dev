using EcommerceDev.Application.Common;
using EcommerceDev.Core.Entities;

namespace EcommerceDev.Application.Commands.Products.CreateProduct
{
    public class CreateProjectCommandHandler : IHandler<CreateProductCommand, ResultViewModel<Guid>>
    {
        public Task<ResultViewModel<Guid>> HandleAsync(CreateProductCommand request)
        {
            throw new NotImplementedException();
        }
    }
}
