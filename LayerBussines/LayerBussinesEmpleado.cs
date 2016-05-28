using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LayerBussines
{
    public class LayerBussinesEmpleado
    {
        LayerData.LayerDataEmpleado DALe = new LayerData.LayerDataEmpleado();

        public int InsertarEmpleado(Int64 Id, string Apellidos, string Nombres, double Horas, double Sueldo)
        {
            try
            {
                return DALe.InsertarEmpleado(Id, Apellidos, Nombres, Horas, Sueldo);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                DALe = null;
            }
        }
        public DataTable MostrarEmpleados()
        {
            try
            {
                return DALe.MostrarEmpleados();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                DALe = null;
            }
        }
        public int EditarEmpleado(Int64 Id,string Apellidos,string Nombres,double Horas,double Sueldo)
        {
            try
            {
                return DALe.EditarEmpleado(Id, Apellidos, Nombres, Horas, Sueldo);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                DALe = null;
            }
        }
            
        public int EliminarEmpleado(Int64 Id)
        {
            try
            {
                return DALe.EliminarEmpleado(Id);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                DALe = null;
            }
        }
        public DataTable CalcularSalario()
        {
            try
            {
                return DALe.CalcularSalario();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                DALe = null;
            }
        }
    }
}