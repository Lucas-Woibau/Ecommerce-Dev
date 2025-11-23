using EcommerceDev.Application.Common;
using EcommerceDev.Core.Entities;

namespace EcommerceDev.Application.Commands.Categories.CreateCategory
{
    public class CreateCategoryCommandHandler : IHandler<CreateCategoryCommand, ResultViewModel<Guid>>
    {
        public Task<ResultViewModel<Guid>> HandleAsync(CreateCategoryCommand request)
        {
            throw new NotImplementedException();
        }
    }
}
