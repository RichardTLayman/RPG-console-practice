using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_console_practice
{
    class Game
    {
        public void RunGame()
        {
            Player player = new Player();

            player.CharacterCreate(player);
            Console.ReadKey();
            

            player.CharacterSheet();
            Console.ReadKey();

            
        }
        
    }
}
