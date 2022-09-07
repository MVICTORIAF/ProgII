using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CarrerasS_P.Dominio;

namespace CarrerasS_P.AccesoDatos
{
    class DBHelper
    {
        private SqlConnection cnn;

        public DBHelper()
        {
            cnn = new SqlConnection(Properties.Resources.cnnString); 
        }

        public DataTable ConsultarDB(string strSql)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = strSql;
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }

        public int EjecutarSQL(string strSql, CommandType type)
        {
            int afectadas = 0;
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = strSql;
            afectadas = cmd.ExecuteNonQuery();
            cnn.Close();

            return afectadas;
        }

        public bool ConfirmarPresupuesto(Carrera oCarrera)
        {
            bool ok = true;

            SqlCommand cmd = new SqlCommand();
            SqlTransaction trs = null;

            try
            { 
                cnn.Open();
                trs = cnn.BeginTransaction();
                cmd.Transaction = trs;
                cmd.Connection = cnn;
                cmd.CommandText = "SP_insertar_carrera ";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@titulo", oCarrera.Nombre_Titulo);


                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id_carrera";
                param.Direction = ParameterDirection.Output;
                param.DbType = DbType.Int32;
                cmd.Parameters.Add(param);



                SqlCommand cmdDetalle;
         
                foreach (DetalleCarrera item in oCarrera.DetallesCarrera) //recorrar los detaless presupuesto 
                {
                    cmdDetalle = new SqlCommand();
                    cmd.Transaction = trs;
                    cmdDetalle.Connection = cnn;
                    cmdDetalle.CommandText = "SP_insertar_detalleCarreras";
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@cuatrimestre", item.Cuatrimestre);
                    cmdDetalle.Parameters.AddWithValue("@anioCarrera", item.AnioCursado);
                    cmd.ExecuteNonQuery();
                    
                }
                trs.Commit();
            }
            catch (Exception)
            {

                trs.Rollback();
                ok = false;

            }
            finally
            {
                if (cnn.State == ConnectionState.Open) 
                    cnn.Close(); 
            }
            return ok;

        }

        private void BorrarCarrera()
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@id_carrera";
            param.Direction = ParameterDirection.Output;
            param.DbType = DbType.Int32;
            cmd.Parameters.Add(param);
        }

    }

        }
