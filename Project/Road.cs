using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Road
    {
        public string DescribeEnvironment()
        {
            string environment = "You  wake up on the side of the road \nThe sky is red \nYou hear a pack of wild beasts descending upon you";
            return environment;
        }
        public List<string> roadOptionOne = new List<string>()
        {
            "You trip over a corpse. You are eaten alive by wild beasts. \nPress <ENTER> to restart game",
            "You see a castle on the horizon. \nPress <ENTER> to run toward the castle",
            "You find a blunt, two sided axe. \nPress <ENTER> to swing the axe at the wild beasts"
        };
        public List<string> areaTwo = new List<string>()
        {
            "You run toward the castle, followed closely by the wild beasts",
            "The beasts have been slayed. In the distance you see a grand castle. \nTo your right you see a path veering into a dark, dense forest"
        };
        public string FaceBeast()
        {
            Console.WriteLine("You must face the beasts. \nChoose RUN, FIGHT or DODGE");
            string input = Console.ReadLine();
            return input;
        }
        public List<string> beastsAlive = new List<string>()
        {
            "The beast crushes your skull and rips you apart \nPress <ENTER> to restart game",
            "A beast knocks into the distant forest. \nThe beasts get distracted by a family of deer \nPress <ENTER> to continue into the forest",
            "The beast strikes another beasts, starting a brawl. \nYou run toward the castle. \nPress <ENTER> to enter the castle"
        };
        public string getDiffEnvironment()
        {
            Console.WriteLine("Choose FOREST or CASTLE");
            string input = Console.ReadLine();
            return input;
        }
        public int EnviroInt(string input)
        {
         if(input == "forest")
            {
                return 1;
            }
         else if(input == "castle")
            {
                return 2;
            }
         else
            {
                Console.WriteLine("Not a valid entry");
                return 3;
            }
        }
        public void ContinueGame()
        {
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
        }
       
        public string getFirstInput()
        {
            Console.WriteLine("Go RIGHT, LEFT, or FORWARD");
            string input = Console.ReadLine();
            return input;
        }
        public string LowerInput(string input)
        {
            string lowerInput = input.ToLower();
            return lowerInput;
        }
      public int UserStringSelector(string input, List<string> roadOption)
        {
            switch (input)
            {
                case "left":
                case "run":
                    Console.WriteLine(roadOption[0]);
                    ContinueGame();
                    return 0;
                case "forward":
                case "fight":
                    Console.WriteLine(roadOption[1]);
                    ContinueGame();
                    return 1;
                case "right":
                case "dodge":
                    Console.WriteLine(roadOption[2]);
                    ContinueGame();
                    return 2;
                default:
                    Console.WriteLine("Not a valid entry");
                    return 3;
            }
        }
    
    

    }
}
