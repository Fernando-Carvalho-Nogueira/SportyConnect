using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportyConnectCore.Models.Tournament
{
    public class TeamModel
    {
        [Key]
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        public string TeamName { get; set; } = string.Empty;
        public string TeamDescription { get; set; } = string.Empty;
        public string CreationDate { get; set; } = string.Empty;
        public SportModel Sport { get; set; } = new SportModel();
    }
}
