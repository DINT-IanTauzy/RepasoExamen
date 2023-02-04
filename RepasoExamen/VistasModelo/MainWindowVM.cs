using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using RepasoExamen.Mensajeria;
using RepasoExamen.Modelo;
using RepasoExamen.Servicio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace RepasoExamen.VistasModelo
{
    class MainWindowVM : ObservableObject
    {
        private ObservableCollection<Componente> componentes;

        public ObservableCollection<Componente> Componentes
        {
            get { return componentes; }
            set { SetProperty(ref componentes, value); }
        }

        private Componente componenteSeleccionado;

        public Componente ComponenteSeleccionado
        {
            get { return componenteSeleccionado; }
            set { SetProperty(ref componenteSeleccionado, value); }
        }



        private ServicioNavegacion servico;
        public RelayCommand DialogoInfoCommand { get; }
        public RelayCommand MostrarComponenteCommand { get; }

        private UserControl ventanaMostrar;

        public UserControl VentanaMostrar
        {
            get { return ventanaMostrar; }
            set { SetProperty(ref ventanaMostrar, value); }
        }

        public MainWindowVM()
        {
            servico = new ServicioNavegacion();
            componentes = new ObservableCollection<Componente>();
            VentanaMostrar = new UserControl();
            componentes = Componente.GetSamples();
            DialogoInfoCommand = new RelayCommand(CargarDialogo);
            MostrarComponenteCommand = new RelayCommand(CargarUCMostrarComponentes);
        }

        public void CargarUCMostrarComponentes()
        {
            VentanaMostrar = servico.CargarMostrarComponentes();
            WeakReferenceMessenger.Default.Send(new MuestraComponenteMessage(ComponenteSeleccionado));
        }

        public void CargarDialogo()
        {
            bool? resultado = servico.AbrirDialogoInfo();
        }


    }
}
