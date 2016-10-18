using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoJuegos.Negocio
{
    public class VideoJuegoCollection
    {
        public List<EmpresaVideoJuego> ReadAll()
        {
            var videosJuegos = CommonBC.BroGames.juego;

            return GenerarListado(videosJuegos.ToList());
        }

        private List<EmpresaVideoJuego> GenerarListado(List<VideoJuegos.DALC.juego> juegoDALC) {

            List<VideoJuegos.Negocio.EmpresaVideoJuego> videoJuegoLista = new List<EmpresaVideoJuego>();

            foreach (VideoJuegos.DALC.juego temp in juegoDALC)
            {
                VideoJuegos.Negocio.EmpresaVideoJuego empresaVideoJuego = new EmpresaVideoJuego();

                empresaVideoJuego.idJuego = temp.idJuego;
                empresaVideoJuego.NombreJuego = temp.nombreJuego;
                empresaVideoJuego.TipoJuego = temp.tipoJuego;
                empresaVideoJuego.FechaJuego = temp.fechaPublicacion;
                empresaVideoJuego.PlataformaJuego = temp.plataforma;
                empresaVideoJuego.PrecioJuego = temp.precio;

                videoJuegoLista.Add(empresaVideoJuego);
            }
            return videoJuegoLista;
        }
        
    }
}
