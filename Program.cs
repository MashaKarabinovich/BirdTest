using System;
using System.Collections.Generic;
using System.Text;

namespace birdTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bird List
            List<Bird> birds = new List<Bird>();


            //create your birds
            Bird Penguin = new Bird("Penguin", 2, 0, 0, 0, true, true);
            Bird Hawk = new Bird("Hawk", 0, 100, 0, 40, true, false);
            Bird Robin = new Bird("Robin", 1, 20, 0, 20, false, false);
            Bird Crow = new Bird("Crow", 1, 30, 0, 25, false, false);


            //Add your birds to list
            birds.Add(Penguin);
            birds.Add(Hawk);
            birds.Add(Robin);
            birds.Add(Crow);

            //Create your worlds

            World one = new World(0, 0); //default with no changes
            World two = new World(0, 0); //new world with changes

            //Let the birds hop and fly in world one:

            foreach (Bird bird in birds) //foreach loop for hop/fly world one
            {
                bird.hop(one);
                bird.fly(one);
            }

            //Let the birds hop and fly in world two:

            foreach (Bird bird in birds) //foreach loop for hop/fly world two
            {
                bird.hop(two);
                bird.fly(two);
            }

            //Total distance output to the console and the bird names: 

            Console.WriteLine("Total Distance hopped after the new world for each bird:\n");
            foreach (Bird bird in birds) //foreach loop for printing
            {
                Console.WriteLine("Name:" + bird.name + " \nTotal Distance:" + bird.totalDistance + "ft" + "\nDistance per action: Flying:" + bird.flyDistance + "ft " + "Hopping:" + + bird.hopDistance  +"ft\n");
               
            }


        }
    }
}
