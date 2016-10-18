using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoJuegos.Negocio
{
    public class EmpresaVideoJuego : IPersistente
    {
        public int idJuego { get; set; }
        public string NombreJuego { get; set; }
        public string TipoJuego { get; set; }
        public DateTime FechaJuego { get; set; }
        public string PlataformaJuego { get; set; }
        public int PrecioJuego { get; set; }

        public EmpresaVideoJuego() {
            Init();
        }

        private void Init()
        {
            idJuego = 0;
            NombreJuego = string.Empty;
            TipoJuego = string.Empty;
            FechaJuego = DateTime.Now;
            PlataformaJuego = string.Empty;
            PrecioJuego = 0;
        }

        public bool Create()
        {
            VideoJuegos.DALC.juego juego = new DALC.juego();

            try
            {
                juego.idJuego = this.idJuego;
                juego.nombreJuego = this.NombreJuego;
                juego.tipoJuego = this.TipoJuego;
                juego.fechaPublicacion = this.FechaJuego;
                juego.plataforma = this.PlataformaJuego;
                juego.precio = this.PrecioJuego;

                CommonBC.BroGames.juego.Add(juego);
                CommonBC.BroGames.SaveChanges();

                return true;

            }
            catch (Exception ex)
            {
                CommonBC.BroGames.Detach(juego);
                return false;
            }


        }

        public bool Read()
        {
            try
            {
                VideoJuegos.DALC.juego juego = CommonBC.BroGames.juego.First
                    (
                        game => game.idJuego == this.idJuego
                    );

                this.NombreJuego = juego.nombreJuego;
                this.TipoJuego = juego.tipoJuego;
                this.FechaJuego = juego.fechaPublicacion;
                this.PlataformaJuego = juego.plataforma;
                this.PrecioJuego = juego.precio;

                return true;
            }
            catch (Exception ex)
            {                
                return false;
            }
        }

        public bool Update()
        {
            try
            {
                VideoJuegos.DALC.juego juegoActualizado = CommonBC.BroGames.juego.First
                    (
                        game => game.idJuego == this.idJuego
                    );

                juegoActualizado.nombreJuego = this.NombreJuego;
                juegoActualizado.tipoJuego = this.TipoJuego;
                juegoActualizado.fechaPublicacion = this.FechaJuego;
                juegoActualizado.plataforma = this.PlataformaJuego;
                juegoActualizado.precio = this.PrecioJuego;

                CommonBC.BroGames.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                VideoJuegos.DALC.juego juegoEliminado = CommonBC.BroGames.juego.First
                    (
                        game => game.idJuego == this.idJuego
                    );

                CommonBC.BroGames.juego.Remove(juegoEliminado);

                CommonBC.BroGames.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
