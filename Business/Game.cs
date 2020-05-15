using System;

namespace Jokenpo.Business
{
    public interface Game
    {
        string ValidateWinner (Player p1, Player p2);
        Game NextStep { get; set; }
    }
}
