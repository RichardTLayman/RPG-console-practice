using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_console_practice
{
    public class Player
    {
        Races race = new Races();
        Classes classes = new Classes();

        string PlayerName = "";
        int PlayerLevel = 1;
        string PlayerRace = "";
        string PlayerClass = "";

        public int Strength = 10;
        public int Stamina = 10;
        public int Intelligence = 10;
        public int Speed = 10;
        public int Luck = 10;

        public void CharacterCreate(Player player)
        {
            Console.WriteLine("Please enter your name:");
            PlayerName = Console.ReadLine();

            Console.WriteLine("Please choose a race:");
            Console.WriteLine("Press H for Human and E for Elf:");
            string input = Console.ReadLine();   
            input = input.ToUpper();
            Console.WriteLine();
            
            while (input != "H" && input != "E")
            {
                Console.WriteLine("Please enter a valid choice!");
                input = Console.ReadLine();
                input = input.ToUpper();   
            }

            if (input == "H")
            {
                PlayerRace = "Human";
                race.HumanLevel(player);
            }
            else if (input == "E")
            {
                PlayerRace = "Elf";
                race.ElfLevel(player);
            }

            Console.WriteLine("Please choose a class:");
            Console.WriteLine("Press F for Fighter and M for Mage:");
            input = Console.ReadLine();
            input = input.ToUpper();
            Console.WriteLine();

            while (input != "F" && input != "M")
            {
                Console.WriteLine("Please enter a valid choice!");
                input = Console.ReadLine();
                input = input.ToUpper();
            }

            if (input == "F")
            {
                PlayerClass = "Fighter";
                classes.FighterLevel(player);
            }
            else if (input == "M")
            {
                PlayerClass = "Mage";
                classes.MageLevel(player);
            }
        }

        public void CharacterSheet()
        {
            Console.Clear();
            Console.WriteLine("      Player Data:");
            Console.WriteLine($"Player Name:  {PlayerName}");
            Console.WriteLine($"Player Level: {PlayerLevel}");
            Console.WriteLine($"Player Race:  {PlayerRace}");
            Console.WriteLine($"Player Class: {PlayerClass}");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"     Player Stats:");
            Console.WriteLine($"Strength:     {Strength}");
            Console.WriteLine($"Stamina:      {Stamina}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"Speed:        {Speed}");
            Console.WriteLine($"Luck:         {Luck}");
        }
    }
}
