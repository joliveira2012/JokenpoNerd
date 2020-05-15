using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jokenpo.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Jokenpo.Business;

namespace Jokenpo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JokenpoController : ControllerBase
    {
        // POST: api/Jokenpo
        [HttpPost]
        public string Post([FromBody] List<Jokenpo> jokenpo)
        {
            var jkp1 = jokenpo[0];
            var jkp2 = jokenpo[1];

            if (jokenpo.Count().Equals(2))
            {
                if (Symbol.IsValid(jkp1.Symbol) && Symbol.IsValid(jkp2.Symbol))
                {
                    Play play = new Play();

                    Player p1 = new Player(jkp1.Name, jkp1.Symbol.ToLower().Trim());
                    Player p2 = new Player(jkp2.Name, jkp2.Symbol.ToLower().Trim());

                    return play.GetResult(p1, p2);
                }
                return "Invalid Symbols";
            }            
            return "Just allowed 2 players!";
        }
    }
}
