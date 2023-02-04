using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamen.Modelo
{
    class Componente : ObservableObject
    {
        private string nombre;
        private string tipo;
        private string foto;
        private int precio;

        public string Nombre { get => nombre; set { SetProperty(ref nombre, value); } }

        public string Tipo { get => tipo; set { SetProperty(ref tipo, value); } }

        public string Foto { get => foto; set { SetProperty(ref foto, value); } }

        public int Precio { get => precio; set { SetProperty(ref precio, value); } }

        public Componente(string nombre, string tipo, string foto, int precio)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.foto = foto;
            this.precio = precio;
        }

        public static ObservableCollection<Componente> GetSamples()
        {
            var lista = new ObservableCollection<Componente>();
            lista.Add(new Componente("AMD Ryzen 7 5800X", "Procesador", "../Assets/AMD_Ryzen_7_5800X.jpg", 452));
            lista.Add(new Componente("Intel Core i7-11700K", "Procesador", "../Assets/Intel_Core_i7_11700K.jpg", 365));
            lista.Add(new Componente("Gainward 471056224", "Tarjeta", "../Assets/Gainward_471056224.jpg", 1719));
            lista.Add(new Componente("ASUS ROG Maximus XIII Extreme", "Placa base", "../Assets/ASUS_ROG_Maximus_XIII_Extreme.jpg", 976));
            lista.Add(new Componente("ASRock X570 Creator", "Placa base", "../Assets/ASRock_X570_Creator.jpg", 512));
            return lista;
        }
    }
}
