using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TödesZerstörungsKampf3000
{
    internal class Room
    {
        enum RoomChar
        {
            Wall = 'W',
            Floor = ' ',
            Enemy = 'E',
            Player = 'P',
            Pillar = 'O',
            Door = 'D',
            Bag = 'B',
            Boss = 'K'
        }

        public char[][] room;
        public int width;
        public int height;

        public Room()
        {
            room[height][width] = BuildRoom();
        }
        private char[][] BuildRoom()
        {

            return;
        }
    }
}