﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RavnChallenge.Shared.Dtos
{
    public class PlanetDto : Entity
    {
        public string Name { get; set; }
        public string Diameter { get; set; }
        public string Rotation_period { get; set; }
        public string Orbital_period { get; set; }
        public string Gravity { get; set; }
        public string Population { get; set; }
        public string Climate { get; set; }
        public string Terrain { get; set; }
        public string Surface_water { get; set; }
        public List<string> Residents { get; set; }
        public List<string> Films { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string Url { get; set; }
    }
}
