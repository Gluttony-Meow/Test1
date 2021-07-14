using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [StringLength(maximumLength: 150, MinimumLength = 2)]
        public string StudentName { get; set; }



        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StudentDOB { get; set; }

        [Required]
        public String Address { get; set; }

        [Required]
        public String Picture { get; set; }
    }
}