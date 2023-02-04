using RepasoExamen.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace RepasoExamen.Servicio
{
    class ServicioNavegacion
    {
        public bool? AbrirDialogoInfo()
        {
            DialogoInfo dialogo = new DialogoInfo();
            return dialogo.ShowDialog();
        }

        public UserControl CargarMostrarComponentes()
        {
            return new MostrarComponentes();
        }
    }
}
