using Core.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("Orders", Schema = "dbo")]

    public class Orders : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int UsersId { get; set; }
        public int CardId { get; set; }
        public DateTime? OrderTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int AdressId { get; set; }
        public virtual Card Card { get; set; } 
    }
}
