using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lee el mensaje de la clase Mensajes
            /*mensajes.Mensajes mmm = new mensajes.Mensajes();
            string msj = mmm.MensajeBienvenido;
            MessageBox.Show(msj);
            mmm.CambiarIdimona("ingles");*/

            //lee lo que escribe por teclado o avisa si es muy largo
            string msj = textBox1.Text;
            string[] palabras = msj.Split(' '); //arreglo
            msj = "";
            foreach (var p in palabras) {
                if (p.Length>10) {
                    msj += "-muylargo-";
                } else {
                    msj += p.ToUpper();
                }
            }
            MessageBox.Show(msj);
        }
    }
}
