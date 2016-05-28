using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppNomina
{
    public partial class Eliminar : System.Web.UI.Page
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
            LayerBussines.LayerBussinesEmpleado oLb = new LayerBussines.LayerBussinesEmpleado();
            GridView1.DataSource = oLb.MostrarEmpleados();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            LayerBussines.LayerBussinesEmpleado oLb = new LayerBussines.LayerBussinesEmpleado();

            Int64 ID = Convert.ToInt64(GridView1.DataKeys[e.RowIndex].Value.ToString());

            try
            {
                oLb.EliminarEmpleado(ID);
                LblMsg.Text = "Empleado Eliminado";
                LlenarDatos();
            }
            catch(Exception exc)
            {
                LblMsg.Text = exc.Message.ToString();
            }
            finally
            {
                oLb = null;
            }
        }
    }
}