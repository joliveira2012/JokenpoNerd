using System;

namespace Jokenpo.Business
{
    public class LizardResult : Game
    {
        public Game NextStep { get; set; }
        public string ValidateWinner (Player p1, Player p2) {
            if(Symbol.Lizard.Equals(p1.Symbol) && ("paper".Equals(p2.Symbol) || "spock".Equals(p2.Symbol))){
                return p1.Symbol + " won! Congratulations player "+ p1.Name + "!";
            }
            return NextStep.ValidateWinner(p1, p2);
        }
    }
}
