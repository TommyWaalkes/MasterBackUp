using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14_parking_structures
{
    class Level 
    {

        private List<Space> spaces = new List<Space>();

        public Level(int s)
        {
            for(int i = 0; i < s; i++)
            {
                spaces.Add(new Space(s,i)); 
            }
        }
        // when a user says new garage we will ask for how many levels
        // when the user provides number of levels we will instantiate a garage object
        // with l number of levels ( new Garage(10) ) will create a garage object with an array of length 10
        // then we will ask the user how many spaces each level should have 
        // when the user provides the number of spaces, we will iterate the array placing a new space in that index
        //while iterating and we are less than or equal to index[2] the first 5 spaces will be large 
        // else randomly assign space sizes
        // once garage and spaces are created we will ask the user what level they would like to park on
        // after aksing the user the level we will ask them what type of vehicle they have
        // we will then iterate the garge levels list to see if that level has the appropraite space available, if it does we will 
        // park the car and set the availability to false and return the id of the space
        // if a user enters leave, we will ask the user for the space id and upon entry we will set the availability marker to true
    }
    
}
