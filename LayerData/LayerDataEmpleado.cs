using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LayerData
{
    public class LayerDataEmpleado
    {
        public string strconn = @"Data Source=seric.database.windows.net;Initial Catalog=dbnomrev;User ID=adminric;Password=Sena2016.";

        public LayerDataEmpleado() { }

        public int InsertarEmpleado(Int64 Id, string Apellidos, string Nombres, double Horas, double Sueldo)
        {
            using (SqlConnection cnx = new SqlConnection(strconn))
            {
                cnx.Open();
                SqlCommand Ordensql = new SqlCommand("SpInsertarEmpleado", cnx);
                Ordensql.CommandType = CommandType.StoredProcedure;

                try
                {
                    Ordensql.Parameters.AddWithValue("@Id", Id);
                    Ordensql.Parameters.AddWithValue("@Apellidos", Apellidos);
                    Ordensql.Parameters.AddWithValue("@Nombres", Nombres);
                    Ordensql.Parameters.AddWithValue("@HorasTrabajadas", Horas);
                    Ordensql.Parameters.AddWithValue("@SueldoXHora", Sueldo);
                    return Ordensql.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    cnx.Close();
                    cnx.Dispose();
                    Ordensql.Dispose();
                }
            }
        }
        public DataTable MostrarEmpleados()
        {
            using (SqlConnection cnx = new SqlConnection(strconn))
            {
                cnx.Open();
                SqlDataAdapter dAd = new SqlDataAdapter("SpMostrarEmpleados",cnx);
                dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();

                try
                {
                    dAd.Fill(ds, "Table");
                    return ds.Tables["Table"];
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    cnx.Close();
                    cnx.Dispose();
                    dAd.Dispose();
                    ds.Dispose();
                }
            }
        }
public int EditarEmpleado(Int64 Id,string Apellidos,string Nombres,double Horas,double Sueldo)
        {
            using (SqlConnection cnx = new SqlConnection(strconn))
            {
                cnx.Open();
                SqlCommand OrdenSql = new SqlCommand("SpEditarEmpleado", cnx);
                OrdenSql.CommandType = CommandType.StoredProcedure;
                try
                {
                    OrdenSql.Parameters.AddWithValue("@Id", Id);
                    OrdenSql.Parameters.AddWithValue("@Apellidos", Apellidos);
                    OrdenSql.Parameters.AddWithValue("@Nombres", Nombres);
                    OrdenSql.Parameters.AddWithValue("@HorasTrabajadas", Horas);
                    OrdenSql.Parameters.AddWithValue("SueldoXHora", Sueldo);
                    return OrdenSql.ExecuteNonQuery();

                }
                catch(Exception)
                {
                    throw;

                }
                finally
                {
                    cnx.Close();
                    cnx.Dispose();
                    OrdenSql.Dispose();
                }
            }
        }
        public int EliminarEmpleado(Int64 Id)
        {
            using (SqlConnection cnx = new SqlConnection(strconn))
            {
                cnx.Open();
                SqlCommand OrdenSql = new SqlCommand("SpEliminarEmpleado", cnx);
                OrdenSql.CommandType = CommandType.StoredProcedure;
                try
                {
                    OrdenSql.Parameters.AddWithValue("@Id", Id);
                    return OrdenSql.ExecuteNonQuery();
                }
                catch(Exception)
                {
                    throw;
                }
                finally
                {
                    cnx.Close();
                    cnx.Dispose();
                    OrdenSql.Dispose();
                }
            }
        }
        public DataTable CalcularSalario()
        {
            using (SqlConnection cnx = new SqlConnection(strconn))
            {
                cnx.Open();
                SqlDataAdapter dAd = new SqlDataAdapter("SpCalcularSalario", cnx);
                dAd.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();

                try
                {
                    dAd.Fill(ds, "TableEmp");
                    return ds.Tables["TableEmp"];
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    cnx.Close();
                    cnx.Dispose();
                    dAd.Dispose();
                    ds.Dispose();
                }
            }
        }
    }
}
