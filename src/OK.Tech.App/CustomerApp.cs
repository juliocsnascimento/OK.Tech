using OK.Tech.Domain.Apps;
using OK.Tech.Domain.Entities;
using OK.Tech.Domain.Entities.Validations;
using OK.Tech.Domain.Notifications;
using OK.Tech.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OK.Tech.App
{
  public class CustomerApp : AppBase, ICustomerApp
  {

    private readonly ICustomerRepository _customerRepository;

    public CustomerApp(ICustomerRepository customerRepository, IUnitOfWork unitOfWork, INotifier notifier) : base(unitOfWork, notifier)
    {
      _customerRepository = customerRepository;
    }

    public async Task<IEnumerable<Customer>> GetAll()
    {
      return await _customerRepository.GetAll();
    }

    public async Task<Customer> GetById(Guid id)
    {
      return await _customerRepository.GetById(id);
    }

    public async Task Create(Customer customer)
    {
      if (!Validate(new CustomerValidation(), customer))
      {
        return;
      }

      _customerRepository.Create(customer);
      await UnitOfWork.Save();
    }

    public async Task Update(Guid id, Customer customer)
    {
      if (id != customer.Id)
      {
        Notify($"The supplied ids {id} abd {customer.Id} are differents.");
        return;
      }

      if (!Validate(new CustomerValidation(), customer))
      {
        return;
      }
      
      var customerToUpdate = await GetById(id);
      
      if (customerToUpdate == null)
      {
        Notify($"Customer {id} not found.");
        return;
      }

      customerToUpdate.Name = customer.Name;
      customerToUpdate.Birthdate = customer.Birthdate;
      customerToUpdate.Phone = customer.Phone;
      customerToUpdate.Email = customer.Email;
      customerToUpdate.Active = customer.Active;

      _customerRepository.Update(customerToUpdate);
      await UnitOfWork.Save();
    }

    public async Task Delete(Guid id)
    {
      var customerToDelete = await GetById(id);

      if (customerToDelete == null)
      {
        Notify($"Produtct {id} not found.");
        return;
      }

      _customerRepository.Delete(customerToDelete);
      await UnitOfWork.Save();
    }

  }
}
