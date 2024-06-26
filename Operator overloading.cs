/* Перегрузка оператора 
Вы и ваш друг играете в игру в одной команде. Каждый игрок должен пройти 2 раунда и получает очки за каждый пройденный раунд.
Вам данная программа создает два объекта Score, где хранятся очки за каждый раунд (они передаются конструктору).
Перегрузите оператор + для класса Score, чтобы рассчитать командный счет за каждый раунд.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {

        static void Main(string[] args)
        {
            Score tm1 = new Score(2, 3);
            Score tm2 = new Score(4, 2);

            Score finalScores = tm1 + tm2;


            Console.WriteLine("Round 1: " + finalScores.round1Score);
            Console.WriteLine("Round 2: " + finalScores.round2Score);
        }
    }
    class Score
    {
        public int round1Score { get; set; }
        public int round2Score { get; set; }
        public Score(int r1, int r2)
        {
            round1Score = r1;
            round2Score = r2;
        }
        
        //your code goes here
        public static Score operator+(Score x, Score y)
        {
          int a = x.round1Score + y.round1Score;
          int b = x.round2Score + y.round2Score;
          Score res = new Score(a,b);
          return res;
        }
    }
}