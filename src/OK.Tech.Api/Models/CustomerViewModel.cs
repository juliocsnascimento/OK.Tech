using System;
using System.ComponentModel.DataAnnotations;

namespace OK.Tech.Api.Models
{
  public class CustomerViewModel
  {
    [Key]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "The {0} must be supplied")]
    [StringLength(200, ErrorMessage = "The {0} lenght must be between {2} and {1}", MinimumLength = 3)]
    public string Name { get; set; }

    [Required(ErrorMessage = "The {0} must be supplied")]
    public DateTime Birthdate { get; set; }

    [Required(ErrorMessage = "The {0} must be supplied")]
    [StringLength(15, ErrorMessage = "The {0} lenght must be between {2} and {1}", MinimumLength = 3)]
    public string Phone { get; set; }

    [Required(ErrorMessage = "The {0} must be supplied")]
    [StringLength(200, ErrorMessage ="The {0} lenght must be between {2} and {1}", MinimumLength = 3)]
    public string Email { get; set; }

    public bool Active { get; set; }
  }
}
