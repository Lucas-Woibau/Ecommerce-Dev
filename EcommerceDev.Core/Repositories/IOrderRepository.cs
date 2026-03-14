using EcommerceDev.Core.Entities;

namespace EcommerceDev.Core.Repositories
{
    public interface IOrderRepository
    {
        Task<Guid> CreateAsync(Order order);
        Task<Order?> GetByIdAsync(Guid id);
        Task UpdateAsync(Order order);
    }
}
