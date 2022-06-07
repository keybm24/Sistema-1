using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mensajes
{
    public class Mensajes
    {
        private string Idioma;
        public string MensajeBienvenido {
            get{
                return "Buenas noches";
            }
        }
        public void CambiarIdimona (string idioma) {
            this.Idioma = idioma;
        }
    }
}
