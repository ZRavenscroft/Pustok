﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Pustok.Models
{
    public class Books
    {
        public int Id { get; set; }
        public int GenreId { get; set; }
        public Genres Genres { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public Authors Authors { get; set; }
        public bool StockStatus { get; set; }
        [Column(TypeName ="decimal(18,2)")]
        public decimal SalePrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal DiscountPercent { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal CostPrice { get; set; }
    }
}
