using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    
    class PlayGame
    {

        
        static void Main(string[] args)
        {
            
            Field field = new Field(0, "A");          
            field.FieldDescription();
            int numberofplays = 3;

            while (numberofplays > 0 )
            {


                Console.WriteLine("Please enter North, South, East, West");
                string playerinput = Console.ReadLine();

                Position position = new Position();
                // Console.WriteLine(playerinput);
                position.Position1(playerinput);
                //Console.WriteLine(position.playermove);
                position.playermove = playerinput;
                //Console.WriteLine(position.playerpositionlarg);
                //Console.WriteLine(position.positionlarg);

                position.distancefromtreasure(0, 0);

                if (position.distance == 0) Console.WriteLine("You have reached the treasure");
                else Console.WriteLine("Keep trying buddy");
                numberofplays--;
                Console.WriteLine("-----------------------------");

            }

            Console.WriteLine("3 attempts completed. Game OVER!");
          

        }
    }
}
