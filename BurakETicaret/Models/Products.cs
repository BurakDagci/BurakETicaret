﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BurakETicaret.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string? ProductName { get; set; } = string.Empty;
        public int? ProductCode { get; set; }
        public string? ProductDescription { get; set; } = string.Empty;
        public string? ProductPicture { get; set; } = string.Empty;
        public int? ProductPrice { get; set; }
        public int? CategoryId { get; set; }
        virtual public Category? Category { get; set; }
        [NotMapped]
        public IFormFile? ImageUpload { get; set; } 
    }
}
