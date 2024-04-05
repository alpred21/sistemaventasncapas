﻿using SistemasVentas.VISTA.ClienteVistas;
using SistemasVentas.VISTA.DetalleingVistas;
using SistemasVentas.VISTA.DetalleVentaVistas;
using SistemasVentas.VISTA.IngresoVistas;
using SistemasVentas.VISTA.InterfazInicioSesionVista;
using SistemasVentas.VISTA.MarcaVistas;
using SistemasVentas.VISTA.PersonaVistas;
using SistemasVentas.VISTA.ProductoVIstas;
using SistemasVentas.VISTA.ProveedorVistas;
using SistemasVentas.VISTA.ProveeVistas;
using SistemasVentas.VISTA.RolVistas;
using SistemasVentas.VISTA.TipoProdVistas;
using SistemasVentas.VISTA.UsuarioVistas;
using SistemasVentas.VISTA.VentaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.InterfazVistas
{
    public partial class InterfazSupervisorMenu : Form
    {
        public InterfazSupervisorMenu()
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

            if (submenuproductos.Visible == true)
                submenuproductos.Visible = false;

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



        #region PRODUCTOS
        private void buttonprod_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(submenuproductos);
        }

        private void buttonproductos_Click(object sender, EventArgs e)
        {
            abrirform(new ProductoListarVistas());
        }

        private void buttonmarcas_Click(object sender, EventArgs e)
        {
            abrirform(new MarcaListarVistas());
        }

        private void buttoncategorias_Click(object sender, EventArgs e)
        {
            abrirform(new TipoProdListarVistas());

        }
        #endregion


        #region INGRESOS

        private void buttoning_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(submenuingresos);
        }

        private void buttoningresos_Click(object sender, EventArgs e)
        {
            abrirform(new IngresoListarVistas());
        }

        private void buttondetalleing_Click(object sender, EventArgs e)
        {
            abrirform(new DetalleingListarVistas());
        }

        private void buttonprovee_Click(object sender, EventArgs e)
        {
            abrirform(new ProveeListarVistas());
        }
        #endregion




        private void buttonsalir(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
