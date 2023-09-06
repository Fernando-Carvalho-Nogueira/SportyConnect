﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportyConnectCore.Models.Tournament
{
    public class TournamentModel
    {
        public int Id { get; set; }
        public string TournamentName { get; set; } = "";
        public string Description { get; set; } = "";
        public decimal EntryFee { get; set; }
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
        public SportModel Sport { get; set; } = new SportModel();

    }
}
