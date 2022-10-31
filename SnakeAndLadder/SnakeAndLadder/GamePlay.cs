using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class GamePlay
    {
        const int NO_PLAY = 0, LADDER = 1, SNAKE =2, WINNING_POSITION =100;
        int PlayerPosition = 0,count =0;
        Random random = new Random();
        public int DieRoll()
        {
            int die = random.Next(1, 7);
            count++;
            return die;
        }
        public void Play()
        {
            
            int option = random.Next (0, 3);
            for (int i = 0; i < WINNING_POSITION; i++)
            {
                switch (option)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        int dieRole = DieRoll();
                        if(this.PlayerPosition + dieRole < WINNING_POSITION)
                            this.PlayerPosition += dieRole;
                        break;
                    case SNAKE:
                        this.PlayerPosition -= DieRoll();
                        if (this.PlayerPosition < 0)
                            this.PlayerPosition = 0;
                        break;
                }
            }
            Console.WriteLine("Player Position -" + " " + PlayerPosition);
            if (this.PlayerPosition == WINNING_POSITION)
            {
                Console.WriteLine ("Total Die Role count"+" "+count);
                return;
            }
        }
    }
}
