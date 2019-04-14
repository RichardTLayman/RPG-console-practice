using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_console_practice
{
    public class Classes
    {
        public void FighterLevel(Player player)
        {
            player.Strength += 2;
            player.Stamina += 2;
            player.Intelligence += 0;
            player.Speed += 0;
            player.Luck += 0;
        }

        public void MageLevel(Player player)
        {
            player.Strength += 0;
            player.Stamina += 2;
            player.Intelligence += 2;
            player.Speed += 0;
            player.Luck += 0;
        }
    }
}
