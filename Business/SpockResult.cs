using System;

namespace Jokenpo.Business
{
    public class SpockResult : Game
    {
        public Game NextStep { get; set; }
        public string ValidateWinner (Player p1, Player p2) {
            if(Symbol.Spock.Equals(p1.Symbol) && ("scissors".Equals(p2.Symbol) || "rock".Equals(p2.Symbol))){
                return p1.Symbol + " won! Congratulations player " + p1.Name + "!";
            }
            return NextStep.ValidateWinner(p1, p2);
        }
    }
}
