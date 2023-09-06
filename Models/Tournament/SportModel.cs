using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportyConnectCore.Models.Tournament
{
    public class SportModel
    {
        public string SportName { get; set; } = string.Empty;
        public TeamType TeamType { get; set; } = new TeamType();
        public CourtType GameCourt { get; set; } = new CourtType();
        public ScoreType Score { get; set; } = new ScoreType();
        public SportType Sport { get; set; } = new SportType();
    }
}
