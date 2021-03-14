using System;
using System.Collections.Generic;
using System.Text;

namespace birdTest
{
    /*This is the Bird Class */


    class Bird
    {

        //variables needed and their getters/setters
        public string name { get; set; }
        public int hopDistance { get; set; }
        public int flyDistance { get; set; }
        public int minTemp { get; set; }
        public int maxSpeed { get; set; }

        public bool noMinTemp { get; set; }
        public bool noMaxWindSpeed{ get; set; }
        public int totalDistance { get; set; }


        public Bird() //default
        {
            
        }

          public Bird(string name, int hopDistance, int flyDistance, int minTemp, int maxSpeed, bool noMinTemp, bool noMaxWindSpeed, int totalDistance) //constructor 
        {
            this.name = name;
            this.hopDistance = hopDistance;
            this.flyDistance = flyDistance;
            this.minTemp = minTemp;
            this.maxSpeed = maxSpeed;
            this.noMinTemp = noMinTemp;
            this.noMaxWindSpeed = noMaxWindSpeed;
            this.totalDistance = totalDistance;
        }


        public Bird(string name, int hopDistance, int flyDistance, int minTemp,  int maxSpeed,  bool noMinTemp, bool noMaxWindSpeed) //constructor with new distance
        {
            this.name = name;
            this.hopDistance = hopDistance;
            this.flyDistance = flyDistance;
            this.minTemp = minTemp;
            this.maxSpeed = maxSpeed;
            this.noMinTemp = noMinTemp;
            this.noMaxWindSpeed = noMaxWindSpeed;
            this.totalDistance = 0;
        }

        
        public void hop(World world)
        {
            if (!(world.temperature < this.minTemp) || noMinTemp) //check for min temp and for max wind speed, if there is no MinTemp always add distance
                this.totalDistance += this.hopDistance; //add on to hop distance for each world.

        }

        public  void fly(World world)
        {
            if (!(world.windSpeed > this.maxSpeed) || noMaxWindSpeed) //check for min temp and for max wind speed, if there is no MaxWindspeed, always add distance.
                this.totalDistance += this.flyDistance; //add on to hop distance for each world.
        }


    }
}
