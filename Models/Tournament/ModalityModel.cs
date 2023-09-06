using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportyConnectCore.Models.Tournament
{
    public class ModalityModel
    {
        public TeamType TeamType { get; set; } = new TeamType();
        public string Modality { get; set; } = string.Empty;
        public CourtType GameCourt  { get; set; } = new CourtType();
        public SportModel Sport { get; set; } = new SportModel();
    }
}
