using Entities.Models;

namespace Repositories.Contracts
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
        Order? GetOneOrder(int id);
        void Copmlete(int id);
        void SaveOrder(Order order);
        int NumberOfInProcess { get; }
    }
}