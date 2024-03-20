﻿using SistemasVentas.BSS;
using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SitemasVentas.VISTA.PersonasVistas
{
    public partial class PersonaEditarVista : Form
    {
        int idx = 0;
        Persona p = new Persona();
        PersonaBss bss = new PersonaBss();
        public PersonaEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void PersonaEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerIdBss(idx);
            textBox1.Text = p.Nombre;
            textBox2.Text = p.Apellido;
            textBox3.Text = p.Telefono;
            textBox4.Text = p.CI;
            textBox5.Text = p.Correo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.Nombre = textBox1.Text;
            p.Apellido = textBox2.Text;
            p.Telefono = textBox3.Text;
            p.CI = textBox4.Text;
            p.Correo = textBox5.Text;

            bss.EditarPersonaBss(p);
            MessageBox.Show("Datos actulizados");
        }

        private void PersonaEditarVista_Load_1(object sender, EventArgs e)
        {
            p = bss.ObtenerIdBss(idx);
            textBox1.Text = p.Nombre;
            textBox2.Text = p.Apellido;
            textBox3.Text = p.Telefono;
            textBox4.Text = p.CI;
            textBox5.Text = p.Correo;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            p.Nombre = textBox1.Text;
            p.Apellido = textBox2.Text;
            p.Telefono = textBox3.Text;
            p.CI = textBox4.Text;
            p.Correo = textBox5.Text;

            bss.EditarPersonaBss(p);
            MessageBox.Show("Datos actulizados");
        }
    }
}
