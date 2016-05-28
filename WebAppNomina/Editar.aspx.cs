using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppNomina
{
    public partial class Editar : System.Web.UI.Page
    {
        LayerBussines.LayerBussinesEmpleado olB = new LayerBussines.LayerBussinesEmpleado();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarDatos();
            }
        }
        public void LlenarDatos()
        {
            GridView1.DataSource = olB.MostrarEmpleados();
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            LlenarDatos();

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            LlenarDatos();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            LayerBussines.LayerBussinesEmpleado olB = new LayerBussines.LayerBussinesEmpleado();
           Int64 ID = Convert.ToInt64(GridView1.DataKeys[e.RowIndex].Value.ToString());
            int result = 0;

            GridViewRow row = GridView1.Rows[e.RowIndex];
            TextBox TA = (TextBox)row.FindControl("TxtApellidos");
            TextBox TN = (TextBox)row.FindControl("TxtNombres");
            TextBox TH = (TextBox)row.FindControl("TxtHoras");
            TextBox TS = (TextBox)row.FindControl("TxtSueldo");

            try
            {
                result = olB.EditarEmpleado(ID, TA.Text, TN.Text, Convert.ToDouble(TH.Text), Convert.ToDouble(TS.Text));
                if(result >0)
                {
                    LblMsg.Text = "Empleado Editado";
                }
                else
                {
                    LblMsg.Text = "Empleado NO editado";

                }
            }
            catch (Exception exc)
            {
                LblMsg.Text = exc.Message.ToString();
            }
            finally
            {
                olB = null;
            }
            GridView1.EditIndex = -1;
            LlenarDatos();
        }
    }
}