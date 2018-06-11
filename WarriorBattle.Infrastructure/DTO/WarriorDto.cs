using System;
using System.Collections.Generic;
using System.Text;

namespace WarriorBattle.Infrastructure.DTO
{
    public class WarriorDto
    {
        public int WarriorId { get; set; }
        public string Name { get; set; }
        public double Health { get; set; }
        public double AttMax { get; set; }
        public double BlockMax { get; set; }
    }
}
