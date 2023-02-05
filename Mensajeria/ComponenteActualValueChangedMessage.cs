using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using RepasoExamen.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamen.Mensajeria
{
    public class ComponenteActualValueChangedMessage : ValueChangedMessage<Componente>
    {
        public ComponenteActualValueChangedMessage(Componente c) : base(c) { }
    }
}
