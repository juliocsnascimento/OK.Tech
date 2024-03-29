﻿using AutoMapper;
using OK.Tech.Api.Models;
using OK.Tech.Domain.Entities;

namespace OK.Tech.Api.Configurations
{
  public class AutoMapperConfig : Profile
  {
    public AutoMapperConfig()
    {
      CreateMap<Customer, CustomerViewModel>().ReverseMap();

      CreateMap<Product, ProductViewModel>().ReverseMap();

      CreateMap<PriceList, PriceListViewModel>().ReverseMap();
    }
  }
}
