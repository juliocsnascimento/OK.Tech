using OK.Tech.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OK.Tech.Domain.Apps
{
  public interface IProductApp 
  {
    Task<IEnumerable<Product>> GetAll();

    Task<Product> GetById(Guid id);

    void Create(Product entity);

    void Update(Product entity);

    void Delete(Guid id);
  }
}
