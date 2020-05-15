using System;

namespace Jokenpo.Business
{
    public class Play
    {
        public string GetResult(Player p1, Player p2){
            Game s1 = new DrawResult();
            Game s2 = new PaperResult();
            Game s3 = new RockResult();
            Game s4 = new ScissorsResult();
            Game s5 = new LizardResult();
            Game s6 = new SpockResult();
            Game s7 = new Result();

            s1.NextStep = s2;
            s2.NextStep = s3;
            s3.NextStep = s4;
            s4.NextStep = s5;
            s5.NextStep = s6;
            s6.NextStep = s7;

            return s1.ValidateWinner(p1, p2);
        }
    }
}
