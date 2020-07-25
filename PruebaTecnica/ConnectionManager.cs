using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PruebaTecnica
{
        public class ConnectionManager 
        {

        private string strconexion = Properties.Settings.Default.Conexion;
        private SqlConnection objconexion;

        public IDbConnection GetConnection()
        {
                return new SqlConnection(strconexion);
        }

        public ConnectionManager()
        {
            try
            {
                objconexion = new SqlConnection(strconexion);
                ABRIRCONEXION();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CERRARCONEXION();
            }
        }


        private void ABRIRCONEXION()
        {
            if (objconexion.State == System.Data.ConnectionState.Closed)
            {
                objconexion.Open();
            }
                
        }

        private void CERRARCONEXION()
        {
            if (objconexion.State == System.Data.ConnectionState.Open)
            {
                objconexion.Close();
            }
                
        }

    }


    }

