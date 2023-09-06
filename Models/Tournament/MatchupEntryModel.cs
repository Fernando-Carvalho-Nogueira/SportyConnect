using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportyConnectCore.Models.Tournament
{
    public class MatchupEntryModel
    {
        public TeamModel TeamCompeting { get; set; } = new TeamModel();
        public double Score { get; set; }
        public MatchupModel ParentMatchup { get; set; } = new MatchupModel();

    }
}
