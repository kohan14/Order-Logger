using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Order_Logger_API.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(100)")]
        public string ClientName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(8)")]
        public string Date { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string Note { get; set; }
    }
}
