using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class D_Autobus
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conector"].ConnectionString);

        public List<E_Autobus> Listar_Chofer (string buscar)
        {
            SqlDataReader leer;
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_CHOFER", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            leer = cmd.ExecuteReader();

            List<E_Autobus> Listar = new List<E_Autobus>();
            while (leer.Read())
            {
                Listar.Add(new E_Autobus
                {
                    ID_CHOFER = leer.GetInt32(0),
                    NOMBRE = leer.GetString(1),
                    APELLIDO = leer.GetString(2),
                    NACIMIENTO = leer.GetDateTime(3),
                    CEDULA = leer.GetString(4),
                    DISPON = leer.GetString(5)
                });
            }

            conn.Close();
            leer.Close();
            return Listar;
        }

        public void InsertarChofer(E_Autobus e_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_CHOFER", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", e_Autobus.NOMBRE);
            cmd.Parameters.AddWithValue("@APELLIDO", e_Autobus.APELLIDO);
            cmd.Parameters.AddWithValue("@NACIMIENTO", e_Autobus.NACIMIENTO);
            cmd.Parameters.AddWithValue("@CEDULA", e_Autobus.CEDULA);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void EditarChofer(E_Autobus e_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAR_CHOFER", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@ID_CHOFER", e_Autobus.ID_CHOFER);
            cmd.Parameters.AddWithValue("@NOMBRE", e_Autobus.NOMBRE);
            cmd.Parameters.AddWithValue("@APELLIDO", e_Autobus.APELLIDO);
            cmd.Parameters.AddWithValue("@NACIMIENTO", e_Autobus.NACIMIENTO);
            cmd.Parameters.AddWithValue("@CEDULA", e_Autobus.CEDULA);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void EliminarChofer(E_Autobus e_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_CHOFER", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@ID_CHOFER", e_Autobus.ID_CHOFER);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable cbxChofer()
        {
            SqlDataAdapter leer = new SqlDataAdapter("SP_CARGAR_CHOFER", conn);
            DataTable table = new DataTable();
            leer.Fill(table);
            return table;
        }

        public void DisponChofer(E_Autobus e_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_DISPON_CHOFER", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", e_Autobus.CHOFER);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void DisponChoferV(E_Autobus e_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_DISPONIBLE_C", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", e_Autobus.CHOFER);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<E_Autobus> Listar_Autobus (string buscar)
        {
            SqlDataReader leer;
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_AUTOBUS", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            leer = cmd.ExecuteReader();

            List<E_Autobus> Listar = new List<E_Autobus>();
            while (leer.Read())
            {
                Listar.Add(new E_Autobus
                {
                    ID_AUTOBUS = leer.GetInt32(0),
                    MARCA = leer.GetString(1),
                    MODELO = leer.GetString(2),
                    PLACA = leer.GetString(3),
                    COLOR = leer.GetString(4),
                    ANO = leer.GetString(5)
                });
            }

            conn.Close();
            leer.Close();
            return Listar;
        }

        public void InsertarAutobus(E_Autobus e_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_AUTOBUS", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@MARCA", e_Autobus.MARCA);
            cmd.Parameters.AddWithValue("@MODELO", e_Autobus.MODELO);
            cmd.Parameters.AddWithValue("@PLACA", e_Autobus.PLACA);
            cmd.Parameters.AddWithValue("@COLOR", e_Autobus.COLOR);
            cmd.Parameters.AddWithValue("@ANO", e_Autobus.ANO);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void EditarAutobus(E_Autobus e_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAR_AUTOBUS", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@ID_AUTOBUS", e_Autobus.ID_AUTOBUS);
            cmd.Parameters.AddWithValue("@MARCA", e_Autobus.MARCA);
            cmd.Parameters.AddWithValue("@MODELO", e_Autobus.MODELO);
            cmd.Parameters.AddWithValue("@PLACA", e_Autobus.PLACA);
            cmd.Parameters.AddWithValue("@COLOR", e_Autobus.COLOR);
            cmd.Parameters.AddWithValue("@ANO", e_Autobus.ANO);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void EliminarAutobus(E_Autobus e_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_AUTOBUS", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@ID_AUTOBUS", e_Autobus.ID_AUTOBUS);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable cbxAutobus()
        {
            SqlDataAdapter leer = new SqlDataAdapter("SP_CARGAR_AUTOBUS", conn);
            DataTable table = new DataTable();
            leer.Fill(table);
            return table;
        }

        public void DisponAutobus(E_Autobus e_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_DISPON_AUTOBUS", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@PLACA", e_Autobus.AUTOBUS);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void DisponAutobusV(E_Autobus e_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_DISPONIBLE_A", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@PLACA", e_Autobus.AUTOBUS);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<E_Autobus> Listar_Rutas (string buscar)
        {
            SqlDataReader leer;
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_RUTA", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            leer = cmd.ExecuteReader();

            List<E_Autobus> Listar = new List<E_Autobus>();
            while (leer.Read())
            {
                Listar.Add(new E_Autobus
                {
                    ID_RUTA = leer.GetInt32(0),
                    NOMBRE_RUTA = leer.GetString(1)
                });
            }

            conn.Close();
            leer.Close();
            return Listar;
        }

        public void InsertarRuta(E_Autobus e_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_RUTA", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", e_Autobus.NOMBRE_RUTA);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void EditarRuta(E_Autobus e_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAR_RUTA", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@ID_RUTA", e_Autobus.ID_RUTA);
            cmd.Parameters.AddWithValue("@NOMBRE", e_Autobus.NOMBRE_RUTA);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void EliminarRuta(E_Autobus e_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_RUTA", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@ID_RUTA", e_Autobus.ID_RUTA);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable cbxRuta()
        {
            SqlDataAdapter leer = new SqlDataAdapter("SP_CARGAR_RUTA", conn);
            DataTable table = new DataTable();
            leer.Fill(table);
            return table;
        }

        public void DisponRuta(E_Autobus e_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_DISPON_RUTA", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@RUTA", e_Autobus.RUTA);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void DisponRutaV(E_Autobus e_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_DISPONIBLE_R", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", e_Autobus.RUTA);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<E_Autobus> ListarViajes (string buscar)
        {
            SqlDataReader leer;
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_VIAJE", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            leer = cmd.ExecuteReader();

            List<E_Autobus> Listar = new List<E_Autobus>();
            while (leer.Read())
            {
                Listar.Add(new E_Autobus
                {
                    ID_VIAJE = leer.GetInt32(0),
                    CHOFER = leer.GetString(1),
                    AUTOBUS = leer.GetString(2),
                    RUTA = leer.GetString(3)
                });
            }

            conn.Close();
            leer.Close();
            return Listar;
        }

        public void InsertarViaje(E_Autobus e_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_VIAJE", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@CHOFER", e_Autobus.CHOFER);
            cmd.Parameters.AddWithValue("@AUTOBUS", e_Autobus.AUTOBUS);
            cmd.Parameters.AddWithValue("@RUTA", e_Autobus.RUTA);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void EliminarViaje(E_Autobus e_Autobus)
        {
            SqlCommand cmd = new SqlCommand("SP_FIN_VIAJE", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@ID_VIAJE", e_Autobus.ID_VIAJE);

            cmd.ExecuteNonQuery();
            conn.Close();



        }

        
    }
}
