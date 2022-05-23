﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_L.Models
{
    public class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private Team Team { get; set; }
        public PlayerCategory Category { get; set; }
        public string GetTeam() => Team.Name;
        public virtual void AssignTeam(Team team) => Team = team;
        public virtual void SetCategory(PlayerCategory category) => Category = category;
    }
}
