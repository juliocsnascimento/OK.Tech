using Microsoft.AspNetCore.Mvc;
using OK.Tech.Api.Models;
using System;
using System.Collections.Generic;

namespace OK.Tech.Api.Controllers
{
  
  [Route("products")]
  public class ProductsController : MainController
  {
    [HttpGet]
    public ActionResult<IEnumerable<ProductViewModel>> GetProducts()
    {
      return CustomResponse(new List<ProductViewModel>());
    }

    [HttpGet("{id:Guid}")]
    public ActionResult<ProductViewModel> GetProductById(Guid id)
    {
      return CustomResponse(new List<ProductViewModel>());
    }
    [HttpPost]
   
    public ActionResult<ProductViewModel> CreateProduct(ProductViewModel productViewModel)
    {
      if (!ModelState.IsValid)
      {
        return CustomResponse(ModelState, productViewModel);
      }

      //Cria produto

      return CustomResponse(ModelState, productViewModel);
    }

    [HttpPut("{id:Guid}")]
    public ActionResult<ProductViewModel> UpdateProduct(Guid id, ProductViewModel productViewModel)
    {
      return CustomResponse(new ProductViewModel());
    }

    [HttpDelete("{id:Guid}")]
    public ActionResult<ProductViewModel> DeleteProduct(Guid id)
    {
      return CustomResponse(new ProductViewModel());
    }

  }
}
