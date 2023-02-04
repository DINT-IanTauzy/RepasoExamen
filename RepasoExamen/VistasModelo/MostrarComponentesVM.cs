using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using RepasoExamen.Mensajeria;
using RepasoExamen.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamen.VistasModelo
{
    class MostrarComponentesVM : ObservableRecipient
    {
        private Componente componente;

        public Componente Componente
        {
            get { return componente; }
            set { SetProperty(ref componente, value); }
        }

        public MostrarComponentesVM()
        {
            WeakReferenceMessenger.Default.Register<MuestraComponenteMessage>(this, (r, m) =>
            {
                Componente = m.Value;
            });
        }
    }
}
