
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoJuegos.DALC;

namespace VideoJuegos.Negocio
{
    public class CommonBC
    {
        private static BroGamesEntities _bro_games;

        public static BroGamesEntities BroGames
        {
            get
            {
                if (_bro_games == null)
                {
                    _bro_games = new BroGamesEntities();
                }
                return _bro_games;
            }
        }
        public CommonBC() { }
    }
}
