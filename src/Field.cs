using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Field
    {
        public  int largitude;
        public  string longitude;
        public  string description ;

        public  Field(int largitude= 0, string longitude = "A")
        {
            this.largitude = largitude;
            this.longitude = longitude;
        }

        public  void FieldDescription()
        {
            description = "";

            if (largitude == 0)
            {

                switch (longitude)
                {
                    case "A":
                        description = "Forest around close";
                        break;
                    case "B":
                        description = "river ahead";
                        break;
                    case "C":
                        description = "dangerous animals";
                        break;
                }

                Console.WriteLine(description);
                              

            }
        }
    }
}
