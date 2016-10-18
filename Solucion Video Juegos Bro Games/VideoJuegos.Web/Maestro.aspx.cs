using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VideoJuegos.Web
{
    public partial class Maestro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarVideoJuegos();
            }
        }

        private void CargarVideoJuegos()
        {
            gvVideoJuegos.DataSource = new Negocio.VideoJuegoCollection().ReadAll();
            gvVideoJuegos.DataBind();
        }
    }
}