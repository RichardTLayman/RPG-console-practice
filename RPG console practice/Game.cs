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
            Races race = new Races();
            Classes classes = new Classes();

            Console.WriteLine("Please enter your name:");
            player.PlayerName = Console.ReadLine();

            Console.WriteLine("Please choose a race:");
            Console.WriteLine("Press H for Human and E for Elf:");
            char input = Convert.ToChar(Console.ReadKey());   // handle error
            input = char.ToUpper(input);

            while (input != 'H' || input != 'E')
            {
               Console.WriteLine("Please enter a valid choice!");
               input = Convert.ToChar(Console.ReadKey());
               input = char.ToUpper(input);
            }

            if (input == 'H')
            {
                race.HumanLevel();
            }
            else if (input == 'E')
            {
                race.ElfLevel();
            }

            Console.WriteLine(player.PlayerName);
            Console.WriteLine(player.PlayerRace);
            Console.ReadKey();

            
        }
        
    }
}
