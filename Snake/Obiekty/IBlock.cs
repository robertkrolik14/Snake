using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snake.Obiekty
{
    public interface IBlock : IEquatable<IBlock>
    {
        public int X { get; }
        public int Y { get; }

        public bool Equals(IBlock block);
    }
}
