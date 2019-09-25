using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Position : TreasurePosition
    {
        public string playermove = "";
        public double distance = 0;
        public double positionlarg = 0;
        public double Positionlong = 0;
        public double playerpositionlarg = 0;
        public double playerpositionlong = 0 ;

        public string Position1(string playermove)
        {
            this.playermove = playermove;
            return playermove;
        }

        public double distancefromtreasure(double playerlarg, double playerlong)

        {
            

            switch (playermove)
            {
                case "North":
                    playerpositionlarg += 2;                   
                     break;

                case "South":
                    playerpositionlarg -= 2; 
                  
                    break;

                case "East":
                    playerpositionlong += 2 ;      
                   
                    break;

                case "West":
                    playerpositionlong -=2;               
                    break;
                default:
                    Console.WriteLine("Please enter correct coordinate");
                    break;

            }
            positionlarg = treasurelargposition - playerpositionlarg;
            Positionlong = treasurelongposition - playerpositionlong;
            distance = Math.Sqrt(positionlarg * Positionlong);
            
            Console.WriteLine("Your distance from treasure is {0}", distance);
            return distance;
        }
        

    }
}
