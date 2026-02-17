using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/// we have a issue here with the spelling of positions ---..> positiions etc. note this is a failure point 
/// 19min in tut ---- > 22 min 

namespace simpleSnakeGame
{
    public class GameState
    {
        public int Rows { get; }
        public int Cols { get; }
        public GridValue[,] Grid { get; }
        public Direction Dir { get; private set; }
        public int  Score{get; private set;}

        public bool GameOver { get; private set; }

        private readonly LinkedList<Position> snakePosition = new LinkedList<Position>();
        private readonly Random random = new Random();
    }
}