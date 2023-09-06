using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportyConnectCore.Models.Tournament
{
    public class CourtModel
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string Location { get; set; } = string.Empty;
        [Column(TypeName = "money")]
        public decimal RentalFee { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string CourtName { get; set; } = string.Empty;
        [Column(TypeName = "int")]
        public CourtType CourtType { get; set; }
    }
}
