using System.ComponentModel.DataAnnotations;

namespace MediatR.Api.Models;

public class CreateCustomerModel
{
    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }
    
    public DateTime? Birthday { get; set; }
    
    public int? Age { get; set; }
    
    public string Phone { get; set; }
}
