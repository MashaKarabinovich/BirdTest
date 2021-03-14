using System;
using System.Collections.Generic;
using System.Text;

namespace birdTest
{
    class World
    {
        /*Hello World*/

        //variables and their getters/setters
        public int windSpeed { get; set; }
        public int temperature { get; set; }

        public World() //default
        {

        }

        public World(int windSpeed, int temperature) //constructor
        {
            this.windSpeed = windSpeed;
            this.temperature = temperature;
        }
    }
}
