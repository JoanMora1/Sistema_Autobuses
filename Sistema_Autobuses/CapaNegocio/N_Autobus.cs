using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class N_Autobus
    {
        D_Autobus d_Autobus = new D_Autobus();

        //chofer
        public List<E_Autobus> ListarChofer(string buscar)
        {
            return d_Autobus.Listar_Chofer(buscar);
        }

        public void InsertandoChofer(E_Autobus e_Autobus)
        {
            d_Autobus.InsertarChofer(e_Autobus);
        }

        public void EditandoChofer(E_Autobus e_Autobus)
        {
            d_Autobus.EditarChofer(e_Autobus);
        }

        public void EliminandoChofer(E_Autobus e_Autobus)
        {
            d_Autobus.EliminarChofer(e_Autobus);
        }

        public DataTable cbxChofer()
        {
            return d_Autobus.cbxChofer();
        }

        public void DisponibilidadChofer(E_Autobus e_Autobus)
        {
            d_Autobus.DisponChofer(e_Autobus);
        }

        public void DisponibilidadChoferV(E_Autobus e_Autobus)
        {
            d_Autobus.DisponChoferV(e_Autobus);
        }

        //autobus

        public List<E_Autobus> ListarAutobus(string buscar)
        {
            return d_Autobus.Listar_Autobus(buscar);
        }

        public void InsertandoAutobus(E_Autobus e_Autobus)
        {
            d_Autobus.InsertarAutobus(e_Autobus);
        }

        public void EditandoAutobus(E_Autobus e_Autobus)
        {
            d_Autobus.EditarAutobus(e_Autobus);
        }

        public void EliminandoAutobus(E_Autobus e_Autobus)
        {
            d_Autobus.EliminarAutobus(e_Autobus);
        }

        public DataTable cbxAutobus()
        {
            return d_Autobus.cbxAutobus();
        }

        public void DisponibilidadAutobus(E_Autobus e_Autobus)
        {
            d_Autobus.DisponAutobus(e_Autobus);
        }

        public void DisponibilidadAutobusV(E_Autobus e_Autobus)
        {
            d_Autobus.DisponAutobusV(e_Autobus);
        }

        //Ruta

        public List<E_Autobus> ListarRutas (string buscar)
        {
            return d_Autobus.Listar_Rutas(buscar);
        }

        public void InsertandoRuta(E_Autobus e_Autobus)
        {
            d_Autobus.InsertarRuta(e_Autobus);
        }

        public void EditandoRuta(E_Autobus e_Autobus)
        {
            d_Autobus.EditarRuta(e_Autobus);
        }

        public void EliminandoRuta(E_Autobus e_Autobus)
        {
            d_Autobus.EliminarRuta(e_Autobus);
        }

        public DataTable cbxRuta()
        {
            return d_Autobus.cbxRuta();
        }

        public void DisponibilidadRuta (E_Autobus e_Autobus)
        {
            d_Autobus.DisponRuta(e_Autobus);
        }

        public void DisponibilidadRutaV(E_Autobus e_Autobus)
        {
            d_Autobus.DisponRutaV(e_Autobus);
        }

        //Viajes

        public List<E_Autobus> ListarViaje(string buscar)
        {
            return d_Autobus.ListarViajes(buscar);
        }

        public void InsertandoViaje(E_Autobus e_Autobus)
        {
            d_Autobus.InsertarViaje(e_Autobus);
        }

        public void FinViaje (E_Autobus e_Autobus)
        {
            d_Autobus.EliminarViaje(e_Autobus);
        }
    }
}
