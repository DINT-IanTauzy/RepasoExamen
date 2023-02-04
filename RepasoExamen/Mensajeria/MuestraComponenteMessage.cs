using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using RepasoExamen.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamen.Mensajeria
{
    class MuestraComponenteMessage : ValueChangedMessage<Componente>
    {
        public MuestraComponenteMessage(Componente componente) : base(componente) { }
    }
}
