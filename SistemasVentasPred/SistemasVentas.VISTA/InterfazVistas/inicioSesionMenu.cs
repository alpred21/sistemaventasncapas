using SistemasVentas.DAL;
using SistemasVentas.VISTA.InterfazGerenteVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.InterfazInicioSesionVista
{
    public partial class inicioSesionMenu : Form
    {
        public inicioSesionMenu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string nombreuser = textBox1.Text;
            string contraseña = textBox2.Text;

            if (conexion.VerificarUsuario(nombreuser, contraseña))
            {

                InterfazGerenteMenu abrir = new InterfazGerenteMenu();
                abrir.Show();
            }
            else if (conexion.VerificarUsuario2(nombreuser, contraseña))
            {
                MessageBox.Show("Usuario no tiene roles válidos");
            }
            else if (conexion.VerificarUsuario3(nombreuser, contraseña))
            {
                MessageBox.Show("Usuario no tiene roles válidos");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
