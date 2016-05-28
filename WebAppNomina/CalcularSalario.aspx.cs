using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppNomina
{
    public partial class CalcularSalario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                LlenarDatos();
            }
        }
        public void LlenarDatos()
        {
            LayerBussines.LayerBussinesEmpleado oLB = new LayerBussines.LayerBussinesEmpleado();
            GridView1.DataSource = oLB.CalcularSalario();
            GridView1.DataBind();
        }
    }
}