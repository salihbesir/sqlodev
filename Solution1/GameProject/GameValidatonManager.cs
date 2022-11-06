using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class GameValidatonManager : IGameValidationService
    {
        public bool Validate(Game game)
        {
            if (game.GameName=="Wow")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
