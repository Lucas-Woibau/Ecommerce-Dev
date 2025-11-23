using EcommerceDev.Application.Common;
using EcommerceDev.Core.Entities;

namespace EcommerceDev.Application.Commands.Customers.CreateCustomer
{
    public class CreateCustomerCommandHandler : IHandler<CreateCustomerCommand, ResultViewModel<Guid>>
    {
        public Task<ResultViewModel<Guid>> HandleAsync(CreateCustomerCommand request)
        {
            throw new NotImplementedException();
        }
    }
}
