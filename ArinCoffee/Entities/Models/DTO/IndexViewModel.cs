using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.DTO
{
    public class IndexViewModel
    {
       public List<Product> products { get; set; }
       public List<Orders> orders { get; set; }
       public List<Category> categories { get; set; }
       public List<Card> cards { get; set; }
    }
}
