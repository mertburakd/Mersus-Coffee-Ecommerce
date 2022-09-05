using Core.Entites;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("Adress", Schema = "dbo")]
    public class Adress : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? CompanyName { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public int PostCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string AdditionalInfo { get; set; }
        public int UserId { get; set; }

    }
}
