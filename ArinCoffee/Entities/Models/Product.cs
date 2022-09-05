using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entites;


namespace Entities.Models
{
    [Table("Product", Schema = "dbo")]
public partial class Product : IEntity
    {
        public Product()
        {
            Cards = new HashSet<Card>();
        }
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; } 
        public int? Weight { get; set; }
        public bool? Status { get; set; }
        public string? Image1 { get; set; } 
        public string? Image2 { get; set; } 
        public string? Image3 { get; set; } 
        public string? Image4 { get; set; }  
        public string? Image5 { get; set; } 
        public int Price { get; set; } 
        public int Category { get; set; }
        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }
        [DataType(DataType.MultilineText)]
        public string? MiniDescription { get; set; }
        public string? MiniImage { get; set; }
        public int ListArea { get; set; }
        //public virtual Category CategoryNavigation { get; set; } = null!;
        public virtual ICollection<Card> Cards { get; set; }

    }
}
