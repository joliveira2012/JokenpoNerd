using System;

namespace Jokenpo.Business
{
    public class Result : Game
    {
        public Game NextStep { get; set; }
        public string ValidateWinner(Player p1, Player p2)
        {
            return p2.Symbol + " won! Congratulations player "+ p2.Name + "!";
        }
    }
}