using System;

namespace Jokenpo.Business
{

    public class Player
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        
        public Player(string name, string symbol){
            Name = name;
            Symbol = symbol;
        }
    }
}
