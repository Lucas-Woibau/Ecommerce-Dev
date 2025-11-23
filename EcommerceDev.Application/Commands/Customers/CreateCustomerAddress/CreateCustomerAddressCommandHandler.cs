using EcommerceDev.Application.Common;
using EcommerceDev.Core.Entities;

namespace EcommerceDev.Application.Commands.Customers.CreateCustomerAddress
{
    public class CreateCustomerAddressCommandHandler : IHandler<CreateCustomerAddressCommand, ResultViewModel<Guid>>
    {
        public Task<ResultViewModel<Guid>> HandleAsync(CreateCustomerAddressCommand request)
        {
            throw new NotImplementedException();
        }
    }
}
