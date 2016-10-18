using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VideoJuegos.Negocio;

namespace VideoJuegos.Web
{
    public partial class Mantenedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public EmpresaVideoJuego cargarBCDesdeUI() {

            EmpresaVideoJuego games = new EmpresaVideoJuego()
            {
                idJuego = int.Parse(txtIdJuego.Text),
                NombreJuego = txtNombreJuego.Text,
                TipoJuego = txtTipoVideoJuego.Text,
                FechaJuego = DateTime.Parse(txtFechaJuego.Text),
                PlataformaJuego = txtPlataforma.Text,
                PrecioJuego = int.Parse(txtPrecio.Text)
            };

            return games;
        }

        private void cargarUidesdeBC(EmpresaVideoJuego games)
        {
            txtIdJuego.Text = games.idJuego.ToString();
            txtNombreJuego.Text = games.NombreJuego.ToString();
            txtFechaJuego.Text = games.FechaJuego.ToString();
            txtPlataforma.Text = games.PlataformaJuego.ToString();
            txtPrecio.Text = games.PrecioJuego.ToString();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                EmpresaVideoJuego games = cargarBCDesdeUI();

                if (games.Create())
                {
                    lblResultado.Text = "El video Juego fue Creado";
                }
                else
                {
                    lblResultado.Text = "El video no pudo ser Creado";
                }
            }
            catch (Exception)
            {

                lblResultado.Text = "Error en el proceso de creacion";
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                EmpresaVideoJuego games = cargarBCDesdeUI();

                if (games.Read())
                {
                    cargarUidesdeBC(games);
                    lblResultado.Text = "El video Juego fue Leido";
                }
                else
                {
                    lblResultado.Text = "El video no pudo ser Leido";
                }
            }
            catch (Exception)
            {

                lblResultado.Text = "Error en el proceso de Leido";
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                EmpresaVideoJuego games = cargarBCDesdeUI();

                if (games.Update())
                {
                    cargarUidesdeBC(games);
                    lblResultado.Text = "El video Juego fue Actualizado";
                }
                else
                {
                    lblResultado.Text = "El video no pudo ser Actualizado";
                }
            }
            catch (Exception)
            {

                lblResultado.Text = "Error en el proceso de Actualizado";
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                EmpresaVideoJuego games = cargarBCDesdeUI();

                if (games.Delete())
                {                    
                    lblResultado.Text = "El video Juego fue Eliminado";
                }
                else
                {
                    lblResultado.Text = "El video no pudo ser Eliminado";
                }
            }
            catch (Exception)
            {

                lblResultado.Text = "Error en el proceso de Eliminado";
            }
        }
    }
}