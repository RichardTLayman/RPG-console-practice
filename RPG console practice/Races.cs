using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_console_practice
{
    class Races
    {
        public void HumanLevel(Player player)
        {
            player.Strength += 1;
            player.Stamina += 1;
            player.Intelligence += 1;
            player.Speed += 1;
            player.Luck += 1;
        }

        public void ElfLevel(Player player)
        {
            player.Strength += 0;
            player.Stamina += 1;
            player.Intelligence += 2;
            player.Speed += 1;
            player.Luck += 1;
        }
    }
}
