using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Final
{
    class Win_loss_class
    {

        static public void WinLose()
        {
            int ScoreWins = 0;
            int ScoreLoss = 0;
            int playerCards = 0;
            int pcCards = 0;
            int War;

            if (pcCards < playerCards)
            {
                ScoreLoss++;
            }
            else if (playerCards < pcCards)
            {
                ScoreWins++;
            }   
            
            else if (playerCards == pcCards)
            {
               
            }
           

            
        }

    }
}
