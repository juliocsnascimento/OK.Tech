using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OK.Tech.Api.Models;
using OK.Tech.Domain.Apps;
using OK.Tech.Domain.Entities;
using OK.Tech.Domain.Notifications;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OK.Tech.Api.Controllers
{
  [Route("customer")]
  public class CustomerController : MainController
  {

    private readonly ICustomerApp _customerApp;
    private readonly IMapper _mapper;

    public CustomerController(ICustomerApp customerApp, IMapper mapper, INotifier notifier) : base(notifier)
    {
      _customerApp = customerApp;
      _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CustomerViewModel>>> GetCustomer()
    {
      return CustomResponse(_mapper.Map<IEnumerable<CustomerViewModel>>(await _customerApp.GetAll()));
    }

    [HttpGet("{id:Guid}")]
    public async Task<ActionResult<CustomerViewModel>> GetCustomerById(Guid id)
    {
      return CustomResponse(_mapper.Map<CustomerViewModel>(await _customerApp.GetById(id)));
    }

    [HttpPost]
    public async Task<ActionResult> CreatCustomer(CustomerViewModel customerViewModel)
    {
      if(!IsModelValid())
      {
          return CustomResponse(customerViewModel);
      }

      await _customerApp.Create(_mapper.Map<Customer>(customerViewModel));

      return CustomResponse();
    }

    [HttpPut("{id:Guid}")]
    public async Task<ActionResult> UpdateCustomer(Guid id, CustomerViewModel customerViewModel)
    {
      if (!IsModelValid())
      {
        return CustomResponse(customerViewModel);
      }

      await _customerApp.Update(id, _mapper.Map<Customer>(customerViewModel));

      return CustomResponse();
    }

    [HttpDelete("{id:Guid}")]
    public async Task<ActionResult> DeleteCustomer(Guid id)
    {
      await _customerApp.Delete(id);

      return CustomResponse();
    }
  }
}
