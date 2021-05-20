using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snake.Obiekty
{
    public class Block : IBlock
    {
        protected int _x;
        protected int _y;
        public Block(int x, int y)
        {
            _x = x;
            _y = y;
        }


        public Block()
        {
            _x = 0;
            _y = 0;
        }
        public int X { get => _x; }

        public int Y { get => _y; }

        public bool Equals(IBlock block)  =>(X == block.X && Y == block.Y);

     //   { return (X == block.X && Y == block.Y);}
           
        
    }
}
