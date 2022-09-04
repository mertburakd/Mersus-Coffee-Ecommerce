using Core.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Category", Schema = "dbo")]
    public class Category : IEntity
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; }
        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
