using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppNomina
{
    public partial class Consultar : System.Web.UI.Page
    {

        LayerBussines.LayerBussinesEmpleado obj = new LayerBussines.LayerBussinesEmpleado();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                LlenarDatos();
            }
        }

        public void LlenarDatos()
        {
            GridView1.DataSource = obj.MostrarEmpleados();
            GridView1.DataBind();
        }

    }
}