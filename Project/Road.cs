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
            "You trip over a corpse. You are eaten alive by wild beasts. \nPress ENTER to restart game",
            "You see a castle on the horizon. \nPress ENTER to run toward the castle",
            "You find a blunt, two sided axe. \nPress ENTER to swing the axe at the wild beasts"
        };
        public void ContinueGame()
        {
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
        }
       public List<string> environmentTwo = new List<string>()
        {
            "You are eaten alive by wild beasts",
            "You "
        };
      
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
                    Console.WriteLine(roadOption[0]);
                    ContinueGame();
                    return 0;
                case "forward":
                    Console.WriteLine(roadOption[1]);
                    ContinueGame();
                    return 1;
                case "right":
                    ContinueGame();
                    Console.WriteLine(roadOption[2]);
                    return 2;
                default:
                    Console.WriteLine("Not a valid entry");
                    return 3;
            }
        }
    
    

    }
}
