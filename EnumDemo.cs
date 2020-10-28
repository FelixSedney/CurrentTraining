using System;
using System.IO;

namespace EnumDemo
{

    enum Direction { NORTH=1,EAST,SOUTH,WEST};
    [Flags]//attribute
    enum Security { READ=1,WRITE=2,DELETE=4,CHANGE=8};//0001,0010,0100,1000


    class Program
    {
        static void Main(string[] args)
        {
            NavigateTo(100, Direction.NORTH);

            Security mySecurity = Security.CHANGE | Security.DELETE;
            Console.WriteLine(mySecurity);
        }


        static void NavigateTo(int distance, Direction direction)//0->North, 1->East
        {
            Console.WriteLine((int)direction);
            Console.WriteLine(direction);
        }
    }
}
