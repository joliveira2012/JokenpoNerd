using System;

namespace Jokenpo.Business
{
    public class DrawResult : Game
    {
        public Game NextStep { get; set; }
        public string ValidateWinner (Player p1, Player p2) {
            if(p1.Symbol.ToLower().Equals(p2.Symbol.ToLower())){
                return p1.Name + " and " + p2.Name + " draw, choosing " + p1.Symbol + "!";
            }
            return NextStep.ValidateWinner(p1, p2);
        }
    }
}