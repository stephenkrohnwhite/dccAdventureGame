using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            void SelectorOne(int input, List<string> area)
            {
                switch(input)
                {
                    case 0:
                        Console.Clear();
                        RoadRunner();
                        break;
                    case 1:
                        Console.WriteLine(area[0]);
                        break;
                    case 2:
                        Console.WriteLine(area[1]);
                        break;
                    case 3:
                        Console.Clear();
                        RoadRunner();
                        break;
                    default:
                        break;
                }
            }
           
           void EnvironmentSelector(int input)
            {
                switch (input)
                {
                    case 0:
                        Console.Clear();
                        RoadRunner();
                        break;
                    default:
                        break;
                }
            }
            
            void RoadRunner()
            {
                Road rd = new Road();
                string environment = rd.DescribeEnvironment();
                Console.WriteLine(environment);
                string roadOneInput = rd.getFirstInput();
                string roadOneLower = rd.LowerInput(roadOneInput);
                int rdOneReturn = rd.UserStringSelector(roadOneLower, rd.roadOptionOne);
                SelectorOne(rdOneReturn, rd.areaTwo);
                string roadTwoInput = rd.FaceBeast();
                string roadTwoLower = rd.LowerInput(roadTwoInput);
                int rdTwoReturn = rd.UserStringSelector(roadTwoLower, rd.beastsAlive);
                EnvironmentSelector(rdTwoReturn);
            }
            RoadRunner();
            Console.ReadLine();
        }
    }
}
