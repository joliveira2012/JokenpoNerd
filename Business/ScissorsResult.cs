using System;

namespace Jokenpo.Business
{
    public class ScissorsResult : Game
    {
        public Game NextStep { get; set; }
        public string ValidateWinner (Player p1, Player p2) {
            if(Symbol.Scissors.Equals(p1.Symbol) && ("paper".Equals(p2.Symbol) || "lizard".Equals(p2.Symbol))){
                return p1.Symbol + " won! Congratulations player "+ p1.Name + "!";
            }
            return NextStep.ValidateWinner(p1, p2);
        }
    }
}
