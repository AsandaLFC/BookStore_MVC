﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Category
    {
        [Key] 
        public int ID { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("DisplayOrder")]
        [Range(1, 100, ErrorMessage ="display Order must be between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
