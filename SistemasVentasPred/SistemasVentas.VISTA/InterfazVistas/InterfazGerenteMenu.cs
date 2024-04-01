using SistemasVentas.VISTA.ClienteVistas;
using SistemasVentas.VISTA.PersonaVistas;
using SistemasVentas.VISTA.ProductoVIstas;
using SistemasVentas.VISTA.ProveedorVistas;
using SistemasVentas.VISTA.RolVistas;
using SistemasVentas.VISTA.UsuarioVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.InterfazGerenteVista
{
    public partial class InterfazGerenteMenu : Form
    {

        public InterfazGerenteMenu()
        {
            InitializeComponent();
        }
        private Form formactivo = null;
        private void abrirform(Form formhijo)
        {
            if (formactivo != null)
                formactivo.Close();
            formactivo = formhijo;
            formhijo.TopLevel = false;
            formhijo.FormBorderStyle = FormBorderStyle.None;
            formhijo.Dock = DockStyle.Fill;
            panelcargarform.Controls.Add(formhijo);
            panelcargarform.Tag = formhijo;
            formhijo.BringToFront();
            formhijo.Show();

           /* if (this.panelcargarform.Controls.Count > 0)
                this.panelcargarform.Controls.RemoveAt(0);
            Form fh = formCharge as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcargarform.Controls.Add(fh);
            this.panelcargarform.Tag = fh;
            fh.Show();*/


        }

        #region SUBMENU
        public void ocultarsubmenu()
        {
            if (submenuingresos.Visible == true)
                submenuingresos.Visible = false;
            if (submenupersona.Visible == true)
                submenupersona.Visible = false;
            if (submenuproductos.Visible == true)
                submenuproductos.Visible = false;
            if (submenuventas.Visible == true)
                submenuventas.Visible = false;
        }
        private void mostrarsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                ocultarsubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        #endregion


        #region PERSONA
        private void buttonpersona_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(submenupersona);

        }
        private void buttonproveedores_Click(object sender, EventArgs e)
        {
            abrirform(new ProveedorListarVista());

        }

        private void buttonclientes_Click(object sender, EventArgs e)
        {
            abrirform(new ClienteListarVistas());

        }

        private void buttonusuarios_Click(object sender, EventArgs e)
        {
            abrirform(new UsuarioListarVistas());

        }

        private void buttontodos_Click(object sender, EventArgs e)
        {
            abrirform(new PersonaListarVista());
        }
        #endregion


        #region PRODUCTOS
        private void buttonprod_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(submenuproductos);
        }

        private void buttonproductos_Click(object sender, EventArgs e)
        {

        }

        private void buttonmarcas_Click(object sender, EventArgs e)
        {

        }

        private void buttoncategorias_Click(object sender, EventArgs e)
        {

        }
        #endregion


        #region INGRESOS

        private void buttoning_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(submenuingresos);
        }

        private void buttoningresos_Click(object sender, EventArgs e)
        {

        }

        private void buttondetalleing_Click(object sender, EventArgs e)
        {

        }

        private void buttonprovee_Click(object sender, EventArgs e)
        {

        }
        #endregion


        #region VENTAS
        private void buttonventa_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(submenuventas);
        }

        private void buttonvent_Click(object sender, EventArgs e)
        {

        }

        private void buttondetallevent_Click(object sender, EventArgs e)
        {

        }
        #endregion


        #region ROL
        private void buttonrol_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
            abrirform(new RolListarVistas());
        }
        #endregion


        private void buttonsalir(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
