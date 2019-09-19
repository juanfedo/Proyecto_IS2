﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_IS2
{
    class BaseDatos
    {
        string cadenaConexion = "server=DESKTOP-EUMV4P4;database=datair;User Id=sa;Password=root";

        public bool EjecutarComando(string queryString)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(queryString, connection);
                comando.Connection.Open();
                return comando.ExecuteNonQuery() >= 0;
            }
        }

        public object EjecutarEscalar(string queryString)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(queryString, connection);
                comando.Connection.Open();
                return comando.ExecuteScalar();
            }
        }

        public DataTable RetornarTabla(string queryString)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(queryString, connection);
                comando.Connection.Open();
                DataTable tabla = new DataTable();
                tabla.Load(comando.ExecuteReader());
                return tabla;
            }
        }
    }
}
