using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoApplication.Models
{
    public class Student
    {
        public Student()
        {

        }

        public Guid Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Range(1000000000, 9999999999)]
        [Display(Name = "Phone Number")]
        public long PhoneNumber { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }
    }
}