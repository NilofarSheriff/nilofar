using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19Augustex
{
    internal class Exercise16
    {
        static void Main(string[] args)
        {
            int points = 100;
            string shoot;
            int action;
            
            for(action=1;action<=4; action++) {
                Console.WriteLine("Enter Hit or Fail");
                shoot = Console.ReadLine();

                if (shoot == "Hit")

                {
                    points += 10;
                }
                else if (shoot == "Fail")
                {
                    points -= 20;
                }
            }
            Console.WriteLine("Total Points after 4 action is = {0}",points);
            Console.ReadLine(); 
           

        }
    }
}
