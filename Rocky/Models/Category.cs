﻿using System.ComponentModel.DataAnnotations;

namespace Rocky.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name ="Display Order")]
        [Required]
        [Range(1,int.MaxValue, ErrorMessage = "Display Order for category must be greater than zero.")]
        public int DisplayOrder { get; set; }

    }
}
