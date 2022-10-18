using System.ComponentModel.DataAnnotations;

namespace ModelLayer;
public class Employee
{    
    
    [Required (ErrorMessage ="Select your title")]
    public string Title { get; set; }


    [Required(ErrorMessage = "Firstname field is mandatory")]
    public string FirstName { get; set; }


    [Required(ErrorMessage = "LastName field is mandatory")]
    public string LastName { get; set; }


    [Required(ErrorMessage = "Select your gender")]
    public string Gender { get; set; }

    [Key]
    [Required(ErrorMessage = "Username is required")]
    public string UserName { get; set; }


    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; }
    public string EmailId { get; set; }
    public string Mobile { get; set; }


    [Required]
    public string Address { get; set; }

    [Required]
    public string Country { get; set; }


    [Required]
    public string Salary { get; set; }


    [Required]
    public string Designation { get; set; }
   

}