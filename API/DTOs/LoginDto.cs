using System.ComponentModel.DataAnnotations;
namespace API.DTOs
{
    public class LoginDto
    {
      [Required]
      public int PIN {get; set;}
    }
}