using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snake.Obiekty
{
    public class FoodBlock :Block
    {
        public FoodBlock(int x, int y) : base(x, y)
        {
                
        }

        public FoodBlock(int blocksInLine, IEnumerable<IBlock> busyBlocks)
        {
            //zwykle bloki na zajete  miejsca na planszy

            var elements = new List<Block>();
            for (var x=0;x<blocksInLine;x++)
            {
                for(var y=0;y<blocksInLine;y++)
                {
                    elements.Add(new Block(x, y));
                }
            }
            // usuwamy zajęte elementy
            elements.RemoveAll(e => busyBlocks.Contains(e));
            //wybieramy 1 z dostępnych blokow

            var random = new Random();
            var chosen = elements[random.Next(elements.Count)];

            // ustawiamy nowe wspólrzedne jedzeniu

            _x = chosen.X;
            _y = chosen.Y;
        }


    }
}
