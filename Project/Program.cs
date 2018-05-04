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
            void Selector(int input, List<string> environment)
            {
                switch(input)
                {
                    case 0:
                        Console.Clear();
                        RoadRunner();
                        break;
                    case 1:
                        Console.WriteLine(environment[0]);
                        break;
                    case 2:
                        Console.WriteLine(environment[1]);
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
                Selector(rdOneReturn, );
            }
            RoadRunner();
            Console.ReadLine();
        }
    }
}
