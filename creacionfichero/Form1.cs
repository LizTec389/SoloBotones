using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace creacionfichero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //Stream writer es la clase que respresenta a un fichero de texto
            //en el que podemos escribir informacion
            //El fichero de texto lo creamos con el metodo (estatico) CreateText
            //que pertenece ala clase File
            //Para escribir en el fichero empleamos Write y WriteLine
            //Close para cerrar el archivo o podria quedar algun dato sin guardar

            StreamWriter fichero;
            fichero = File.CreateText("fichero1.txt");
            fichero.WriteLine("Hola este es mi primer fichero");
            fichero.Write("Siguiente linea");
            fichero.Write("\r\n");
            fichero.WriteLine("Parte de la linea anterior");
            fichero.Close();


        }

        private void btnForma_Click(object sender, EventArgs e)
        {
            using (StreamWriter fichero = new StreamWriter("fichero1. txt"))
            {
                fichero.WriteLine("Este codigo es mas compacto");

            }
        }
    } 
}
