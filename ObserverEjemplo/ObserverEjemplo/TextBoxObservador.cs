using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ObserverEjemplo
{
    class TextBoxObservador : TextBox , ObservadorMontoTotal
    {
        public void NotificarMontoTotal(decimal monto)
        {
            this.Text = monto.ToString();
        }
    }
}
