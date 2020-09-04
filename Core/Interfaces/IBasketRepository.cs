using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IBasketRepository
    {
         Task<CustomerBasket> getBasketAsync(string basketId);
         Task<CustomerBasket> updateBasketAsync(CustomerBasket basket);
         Task<bool> deleteBasketAsync(string basketId);
    }
}