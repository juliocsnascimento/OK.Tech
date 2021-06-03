using System;

namespace OK.Tech.Domain.Entities
{
  public class Customer : Entity
  {
    public string Name { get; set; }

    public DateTime Birthdate { get; set; }
    
    public string Phone { get; set; }
    
    public string Email { get; set; }

    public bool  Active { get; set; }
  }
}
