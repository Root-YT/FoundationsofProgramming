using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSDemoV1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to RPS");
            int rounds = 5;
            int usercount = 0;
            int aicount = 0;
            int drawcount = 0;

            int stopcriteria = (rounds + 1) / 2;
           // int enhancedstopcriteria = (int)Math.Ceiling((rounds - drawcount) / 2.0); 

            for (int i = 1; i <= rounds; i++)
            {
                Console.WriteLine("Welcome to Round : "+ i);
                Choice user = GetUserChoice();
                Choice ai = GetAIChoice();
                WinningState s = DetermineWinner(user, ai);
                DisplayRoundResult(user, ai, s);

                //update score
                if (s == WinningState.AIWin)
                {
                    aicount++;
                }
                else if (s == WinningState.UserWin)
                {
                    usercount++;
                }
                else
                {
                    drawcount++;
                }
                Console.WriteLine("After Round: "+ i);
                Console.WriteLine("User Count: "+ usercount + "\t. AI Count: "+ aicount+ "\t. Draw Count: "+ drawcount);

                if (usercount >= stopcriteria || aicount >= stopcriteria)
                {
                    Console.WriteLine("Winner is determined. No need to play further rounds");
                    break;
                }
            }
            //game winner determination

            if (usercount > aicount)
            {
                Console.WriteLine("User wins the game");
            }
            else if (aicount > usercount)
            {
                Console.WriteLine("AI wins the game");
            }
            else
            {
                Console.WriteLine("Game is Draw");
            }

        }

        //get user choice
        public static Choice GetUserChoice()
        {
            Console.WriteLine("Enter your choice: 1. Rock, 2. Paper, 3. Scissor. ");
            int temp= int.Parse(Console.ReadLine());
            return (Choice)temp;
        }

        //get AI choice
        public static Choice GetAIChoice()
        {
            Random r = new Random();
            int temp = r.Next(1, 4);
            return (Choice)temp;
        }

        //Determine Winner

        public static WinningState DetermineWinner(Choice user, Choice ai)
        {
            WinningState state = WinningState.Draw;
            if (user == ai)
            {
                return state;
            }
            else if (user == Choice.Rock)
            {
                if (ai == Choice.Paper)
                {
                    state = WinningState.AIWin;
                }
                else
                {
                    state = WinningState.UserWin;
                }

            }
            else if (user == Choice.Paper)
            {
                if (ai == Choice.Scissor)
                {
                    state = WinningState.AIWin;
                }
                else
                {
                    state = WinningState.UserWin;
                }
            }
            else if (user == Choice.Scissor)
            {
                if (ai == Choice.Rock)
                {
                    state = WinningState.AIWin;
                }
                else
                {
                    state = WinningState.UserWin;
                }
            }
            return state;
        }

        //Display round result

        public static void DisplayRoundResult(Choice user, Choice ai, WinningState s)
        {
           
            Console.WriteLine("User Choice: "+ user);
            Console.WriteLine("AI Choice: "+ ai);
            Console.WriteLine("Result: "+ s);

        }
    }

    public enum WinningState
    {
        Draw,
        UserWin,
        AIWin,
    }


    public enum Choice
    {
        Rock=1,
        Paper=2,
        Scissor=3,
    }


}
