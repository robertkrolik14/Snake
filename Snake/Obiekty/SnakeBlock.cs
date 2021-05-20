using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snake.Obiekty
{
    public class SnakeBlock : Block, IComparable<SnakeBlock>
    {
        private int _number;

        public SnakeBlock(int x,int y,int number) :base(x,y)
        {
            _number = number; 
        }
        public SnakeBlock(int x, int y) :base(x,y)
        {
            _number = 0;
        }

        public int Number
        {
            get => _number;
        }

        public int CompareTo(SnakeBlock block)
        {
            return Number.CompareTo(block.Number);
        }

        public void Move() => _number++;
        
    }
}
