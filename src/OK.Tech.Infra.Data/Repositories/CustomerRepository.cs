using OK.Tech.Domain.Entities;
using OK.Tech.Domain.Repositories;
using OK.Tech.Infra.Data.Contexts;

namespace OK.Tech.Infra.Data.Repositories
{
  public class CustomerRepository : Repository<Customer>, ICustomerRepository
  {
    public CustomerRepository(ApiDbContext context) : base(context)
    {
    }
  }
}
