using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClinetWebApplication.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }

        [Required(ErrorMessage ="First Name is Mandatory")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
    }
}
