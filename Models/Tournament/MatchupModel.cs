using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportyConnectCore.Models.Tournament
{
    public class MatchupModel
    {
        /// The match of a tournament
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        public TeamModel Winner { get; set; } = new TeamModel();
        public int MatchupRound { get; set; }
    }
}
