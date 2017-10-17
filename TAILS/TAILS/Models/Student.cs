﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TAILS.Models
{
    public class Student
    {
        private ICollection<Course> courses;

        public Student()
        {
            this.courses = new HashSet<Course>();
        }

        [Range(1, 1000)]
        public int Id { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 5, ErrorMessage = "The FirstName's length should be between 5 and 40 symbols long.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 5, ErrorMessage = "The LastName's length should be between 5 and 40 symbols long.")]
        public string LastName { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 5, ErrorMessage = "The Username's length should be between 5 and 40 symbols long.")]
        public string Username { get; set; }

        public virtual ICollection<Course> Courses
        {
            get
            {
                return this.courses;
            }
            set
            {
                this.courses = value;
            }
        }
    }
}