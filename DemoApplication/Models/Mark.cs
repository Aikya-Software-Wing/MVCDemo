using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoApplication.Models
{
    public class Mark
    {
        public Mark()
        {

        }

        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Subject Name")]
        public string SubjectName { get; set; }

        [Required]
        [Display(Name = "Marks Obtained")]
        [Range(0, 100)]
        public int MarksObtained { get; set; }

        [Required]
        public Guid StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}