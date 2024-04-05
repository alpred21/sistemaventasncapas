namespace SistemasVentas.VISTA.InterfazGerenteVista
{
    partial class InterfazGerenteMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazGerenteMenu));
            panel1 = new Panel();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            panelmenu = new Panel();
            panel5 = new Panel();
            buttonrol = new Button();
            submenuventas = new Panel();
            buttondetallevent = new Button();
            buttonvent = new Button();
            buttonventa = new Button();
            submenuingresos = new Panel();
            buttonprovee = new Button();
            buttondetalleing = new Button();
            buttoningresos = new Button();
            buttoning = new Button();
            submenuproductos = new Panel();
            buttoncategorias = new Button();
            buttonmarcas = new Button();
            buttonproductos = new Button();
            buttonprod = new Button();
            submenupersona = new Panel();
            buttonusuariorol = new Button();
            buttontodos = new Button();
            buttonusuarios = new Button();
            buttonclientes = new Button();
            buttonproveedores = new Button();
            buttonpersona = new Button();
            panelcargarform = new Panel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelmenu.SuspendLayout();
            panel5.SuspendLayout();
            submenuventas.SuspendLayout();
            submenuingresos.SuspendLayout();
            submenuproductos.SuspendLayout();
            submenupersona.SuspendLayout();
            panelcargarform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 130);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Magneto", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(279, 4);
            label4.Name = "label4";
            label4.Padding = new Padding(60, 35, 50, 30);
            label4.Size = new Size(473, 123);
            label4.TabIndex = 17;
            label4.Text = "PREDSHOP";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(20);
            pictureBox2.Size = new Size(152, 130);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            button3.FlatAppearance.MouseOverBackColor = Color.Red;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Red;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(9, 45);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(93, 33);
            button3.TabIndex = 2;
            button3.Text = "SALIR";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += buttonsalir;
            // 
            // panelmenu
            // 
            panelmenu.AutoScroll = true;
            panelmenu.BackColor = Color.Black;
            panelmenu.BackgroundImageLayout = ImageLayout.None;
            panelmenu.Controls.Add(panel5);
            panelmenu.Controls.Add(buttonrol);
            panelmenu.Controls.Add(submenuventas);
            panelmenu.Controls.Add(buttonventa);
            panelmenu.Controls.Add(submenuingresos);
            panelmenu.Controls.Add(buttoning);
            panelmenu.Controls.Add(submenuproductos);
            panelmenu.Controls.Add(buttonprod);
            panelmenu.Controls.Add(submenupersona);
            panelmenu.Controls.Add(buttonpersona);
            panelmenu.Dock = DockStyle.Left;
            panelmenu.Location = new Point(0, 130);
            panelmenu.Name = "panelmenu";
            panelmenu.Size = new Size(220, 531);
            panelmenu.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(button3);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 680);
            panel5.Name = "panel5";
            panel5.Size = new Size(203, 87);
            panel5.TabIndex = 19;
            // 
            // buttonrol
            // 
            buttonrol.BackColor = Color.Black;
            buttonrol.BackgroundImageLayout = ImageLayout.Zoom;
            buttonrol.Cursor = Cursors.Hand;
            buttonrol.Dock = DockStyle.Top;
            buttonrol.FlatAppearance.BorderColor = Color.FromArgb(94, 142, 62);
            buttonrol.FlatAppearance.CheckedBackColor = Color.Silver;
            buttonrol.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonrol.FlatAppearance.MouseOverBackColor = Color.Gray;
            buttonrol.FlatStyle = FlatStyle.Flat;
            buttonrol.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonrol.ForeColor = Color.White;
            buttonrol.Image = (Image)resources.GetObject("buttonrol.Image");
            buttonrol.ImageAlign = ContentAlignment.MiddleLeft;
            buttonrol.Location = new Point(0, 635);
            buttonrol.Name = "buttonrol";
            buttonrol.Size = new Size(203, 45);
            buttonrol.TabIndex = 18;
            buttonrol.Text = "ROLES";
            buttonrol.UseVisualStyleBackColor = false;
            buttonrol.Click += buttonrol_Click;
            // 
            // submenuventas
            // 
            submenuventas.BackColor = Color.FromArgb(6, 21, 1);
            submenuventas.Controls.Add(buttondetallevent);
            submenuventas.Controls.Add(buttonvent);
            submenuventas.Dock = DockStyle.Top;
            submenuventas.Location = new Point(0, 565);
            submenuventas.Name = "submenuventas";
            submenuventas.Size = new Size(203, 70);
            submenuventas.TabIndex = 17;
            submenuventas.Visible = false;
            // 
            // buttondetallevent
            // 
            buttondetallevent.BackColor = Color.Transparent;
            buttondetallevent.Dock = DockStyle.Top;
            buttondetallevent.FlatAppearance.BorderSize = 0;
            buttondetallevent.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 0);
            buttondetallevent.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            buttondetallevent.FlatStyle = FlatStyle.Flat;
            buttondetallevent.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttondetallevent.ForeColor = Color.White;
            buttondetallevent.Location = new Point(0, 35);
            buttondetallevent.Name = "buttondetallevent";
            buttondetallevent.Padding = new Padding(30, 0, 0, 0);
            buttondetallevent.Size = new Size(203, 35);
            buttondetallevent.TabIndex = 4;
            buttondetallevent.Text = "Detalle ventas";
            buttondetallevent.TextAlign = ContentAlignment.MiddleLeft;
            buttondetallevent.UseVisualStyleBackColor = false;
            buttondetallevent.Click += buttondetallevent_Click;
            // 
            // buttonvent
            // 
            buttonvent.BackColor = Color.Transparent;
            buttonvent.Dock = DockStyle.Top;
            buttonvent.FlatAppearance.BorderSize = 0;
            buttonvent.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 0);
            buttonvent.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            buttonvent.FlatStyle = FlatStyle.Flat;
            buttonvent.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonvent.ForeColor = Color.White;
            buttonvent.Location = new Point(0, 0);
            buttonvent.Name = "buttonvent";
            buttonvent.Padding = new Padding(30, 0, 0, 0);
            buttonvent.Size = new Size(203, 35);
            buttonvent.TabIndex = 3;
            buttonvent.Text = "Ventas";
            buttonvent.TextAlign = ContentAlignment.MiddleLeft;
            buttonvent.UseVisualStyleBackColor = false;
            buttonvent.Click += buttonvent_Click;
            // 
            // buttonventa
            // 
            buttonventa.BackColor = Color.Black;
            buttonventa.BackgroundImageLayout = ImageLayout.Zoom;
            buttonventa.Cursor = Cursors.Hand;
            buttonventa.Dock = DockStyle.Top;
            buttonventa.FlatAppearance.BorderColor = Color.FromArgb(94, 142, 62);
            buttonventa.FlatAppearance.CheckedBackColor = Color.Silver;
            buttonventa.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonventa.FlatAppearance.MouseOverBackColor = Color.Gray;
            buttonventa.FlatStyle = FlatStyle.Flat;
            buttonventa.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonventa.ForeColor = Color.White;
            buttonventa.Image = (Image)resources.GetObject("buttonventa.Image");
            buttonventa.ImageAlign = ContentAlignment.MiddleLeft;
            buttonventa.Location = new Point(0, 520);
            buttonventa.Name = "buttonventa";
            buttonventa.Size = new Size(203, 45);
            buttonventa.TabIndex = 16;
            buttonventa.Text = "VENTAS";
            buttonventa.UseVisualStyleBackColor = false;
            buttonventa.Click += buttonventa_Click;
            // 
            // submenuingresos
            // 
            submenuingresos.BackColor = Color.FromArgb(6, 21, 1);
            submenuingresos.Controls.Add(buttonprovee);
            submenuingresos.Controls.Add(buttondetalleing);
            submenuingresos.Controls.Add(buttoningresos);
            submenuingresos.Dock = DockStyle.Top;
            submenuingresos.Location = new Point(0, 415);
            submenuingresos.Name = "submenuingresos";
            submenuingresos.Size = new Size(203, 105);
            submenuingresos.TabIndex = 15;
            submenuingresos.Visible = false;
            // 
            // buttonprovee
            // 
            buttonprovee.BackColor = Color.Transparent;
            buttonprovee.Dock = DockStyle.Top;
            buttonprovee.FlatAppearance.BorderSize = 0;
            buttonprovee.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 0);
            buttonprovee.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            buttonprovee.FlatStyle = FlatStyle.Flat;
            buttonprovee.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonprovee.ForeColor = Color.White;
            buttonprovee.Location = new Point(0, 70);
            buttonprovee.Name = "buttonprovee";
            buttonprovee.Padding = new Padding(30, 0, 0, 0);
            buttonprovee.Size = new Size(203, 35);
            buttonprovee.TabIndex = 2;
            buttonprovee.Text = "Provee";
            buttonprovee.TextAlign = ContentAlignment.MiddleLeft;
            buttonprovee.UseVisualStyleBackColor = false;
            buttonprovee.Click += buttonprovee_Click;
            // 
            // buttondetalleing
            // 
            buttondetalleing.BackColor = Color.Transparent;
            buttondetalleing.Dock = DockStyle.Top;
            buttondetalleing.FlatAppearance.BorderSize = 0;
            buttondetalleing.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 0);
            buttondetalleing.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            buttondetalleing.FlatStyle = FlatStyle.Flat;
            buttondetalleing.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttondetalleing.ForeColor = Color.White;
            buttondetalleing.Location = new Point(0, 35);
            buttondetalleing.Name = "buttondetalleing";
            buttondetalleing.Padding = new Padding(30, 0, 0, 0);
            buttondetalleing.Size = new Size(203, 35);
            buttondetalleing.TabIndex = 4;
            buttondetalleing.Text = "Detalle ingreso";
            buttondetalleing.TextAlign = ContentAlignment.MiddleLeft;
            buttondetalleing.UseVisualStyleBackColor = false;
            buttondetalleing.Click += buttondetalleing_Click;
            // 
            // buttoningresos
            // 
            buttoningresos.BackColor = Color.Transparent;
            buttoningresos.Dock = DockStyle.Top;
            buttoningresos.FlatAppearance.BorderSize = 0;
            buttoningresos.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 0);
            buttoningresos.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            buttoningresos.FlatStyle = FlatStyle.Flat;
            buttoningresos.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttoningresos.ForeColor = Color.White;
            buttoningresos.Location = new Point(0, 0);
            buttoningresos.Name = "buttoningresos";
            buttoningresos.Padding = new Padding(30, 0, 0, 0);
            buttoningresos.Size = new Size(203, 35);
            buttoningresos.TabIndex = 3;
            buttoningresos.Text = "Ingresos";
            buttoningresos.TextAlign = ContentAlignment.MiddleLeft;
            buttoningresos.UseVisualStyleBackColor = false;
            buttoningresos.Click += buttoningresos_Click;
            // 
            // buttoning
            // 
            buttoning.BackColor = Color.Black;
            buttoning.BackgroundImageLayout = ImageLayout.Zoom;
            buttoning.Cursor = Cursors.Hand;
            buttoning.Dock = DockStyle.Top;
            buttoning.FlatAppearance.BorderColor = Color.FromArgb(94, 142, 62);
            buttoning.FlatAppearance.CheckedBackColor = Color.Silver;
            buttoning.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttoning.FlatAppearance.MouseOverBackColor = Color.Gray;
            buttoning.FlatStyle = FlatStyle.Flat;
            buttoning.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttoning.ForeColor = Color.White;
            buttoning.Image = (Image)resources.GetObject("buttoning.Image");
            buttoning.ImageAlign = ContentAlignment.MiddleLeft;
            buttoning.Location = new Point(0, 370);
            buttoning.Name = "buttoning";
            buttoning.Size = new Size(203, 45);
            buttoning.TabIndex = 14;
            buttoning.Text = "INGRESOS";
            buttoning.UseVisualStyleBackColor = false;
            buttoning.Click += buttoning_Click;
            // 
            // submenuproductos
            // 
            submenuproductos.BackColor = Color.FromArgb(6, 21, 1);
            submenuproductos.Controls.Add(buttoncategorias);
            submenuproductos.Controls.Add(buttonmarcas);
            submenuproductos.Controls.Add(buttonproductos);
            submenuproductos.Dock = DockStyle.Top;
            submenuproductos.Location = new Point(0, 265);
            submenuproductos.Name = "submenuproductos";
            submenuproductos.Size = new Size(203, 105);
            submenuproductos.TabIndex = 13;
            submenuproductos.Visible = false;
            // 
            // buttoncategorias
            // 
            buttoncategorias.BackColor = Color.Transparent;
            buttoncategorias.Dock = DockStyle.Top;
            buttoncategorias.FlatAppearance.BorderSize = 0;
            buttoncategorias.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 0);
            buttoncategorias.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            buttoncategorias.FlatStyle = FlatStyle.Flat;
            buttoncategorias.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttoncategorias.ForeColor = Color.White;
            buttoncategorias.Location = new Point(0, 70);
            buttoncategorias.Name = "buttoncategorias";
            buttoncategorias.Padding = new Padding(30, 0, 0, 0);
            buttoncategorias.Size = new Size(203, 35);
            buttoncategorias.TabIndex = 2;
            buttoncategorias.Text = "Categorias";
            buttoncategorias.TextAlign = ContentAlignment.MiddleLeft;
            buttoncategorias.UseVisualStyleBackColor = false;
            buttoncategorias.Click += buttoncategorias_Click;
            // 
            // buttonmarcas
            // 
            buttonmarcas.BackColor = Color.Transparent;
            buttonmarcas.Dock = DockStyle.Top;
            buttonmarcas.FlatAppearance.BorderSize = 0;
            buttonmarcas.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 0);
            buttonmarcas.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            buttonmarcas.FlatStyle = FlatStyle.Flat;
            buttonmarcas.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonmarcas.ForeColor = Color.White;
            buttonmarcas.Location = new Point(0, 35);
            buttonmarcas.Name = "buttonmarcas";
            buttonmarcas.Padding = new Padding(30, 0, 0, 0);
            buttonmarcas.Size = new Size(203, 35);
            buttonmarcas.TabIndex = 4;
            buttonmarcas.Text = "Marcas";
            buttonmarcas.TextAlign = ContentAlignment.MiddleLeft;
            buttonmarcas.UseVisualStyleBackColor = false;
            buttonmarcas.Click += buttonmarcas_Click;
            // 
            // buttonproductos
            // 
            buttonproductos.BackColor = Color.Transparent;
            buttonproductos.Dock = DockStyle.Top;
            buttonproductos.FlatAppearance.BorderSize = 0;
            buttonproductos.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 0);
            buttonproductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            buttonproductos.FlatStyle = FlatStyle.Flat;
            buttonproductos.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonproductos.ForeColor = Color.White;
            buttonproductos.Location = new Point(0, 0);
            buttonproductos.Name = "buttonproductos";
            buttonproductos.Padding = new Padding(30, 0, 0, 0);
            buttonproductos.Size = new Size(203, 35);
            buttonproductos.TabIndex = 3;
            buttonproductos.Text = "Productos";
            buttonproductos.TextAlign = ContentAlignment.MiddleLeft;
            buttonproductos.UseVisualStyleBackColor = false;
            buttonproductos.Click += buttonproductos_Click;
            // 
            // buttonprod
            // 
            buttonprod.BackColor = Color.Black;
            buttonprod.BackgroundImageLayout = ImageLayout.Zoom;
            buttonprod.Cursor = Cursors.Hand;
            buttonprod.Dock = DockStyle.Top;
            buttonprod.FlatAppearance.BorderColor = Color.FromArgb(94, 142, 62);
            buttonprod.FlatAppearance.CheckedBackColor = Color.Silver;
            buttonprod.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonprod.FlatAppearance.MouseOverBackColor = Color.Gray;
            buttonprod.FlatStyle = FlatStyle.Flat;
            buttonprod.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonprod.ForeColor = Color.White;
            buttonprod.Image = (Image)resources.GetObject("buttonprod.Image");
            buttonprod.ImageAlign = ContentAlignment.MiddleLeft;
            buttonprod.Location = new Point(0, 220);
            buttonprod.Name = "buttonprod";
            buttonprod.Size = new Size(203, 45);
            buttonprod.TabIndex = 12;
            buttonprod.Text = "PRODUCTOS";
            buttonprod.UseVisualStyleBackColor = false;
            buttonprod.Click += buttonprod_Click;
            // 
            // submenupersona
            // 
            submenupersona.BackColor = Color.FromArgb(6, 21, 1);
            submenupersona.Controls.Add(buttonusuariorol);
            submenupersona.Controls.Add(buttonusuarios);
            submenupersona.Controls.Add(buttonclientes);
            submenupersona.Controls.Add(buttonproveedores);
            submenupersona.Controls.Add(buttontodos);
            submenupersona.Dock = DockStyle.Top;
            submenupersona.Location = new Point(0, 45);
            submenupersona.Name = "submenupersona";
            submenupersona.Size = new Size(203, 175);
            submenupersona.TabIndex = 11;
            submenupersona.Visible = false;
            // 
            // buttonusuariorol
            // 
            buttonusuariorol.BackColor = Color.Transparent;
            buttonusuariorol.Dock = DockStyle.Top;
            buttonusuariorol.FlatAppearance.BorderSize = 0;
            buttonusuariorol.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 0);
            buttonusuariorol.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            buttonusuariorol.FlatStyle = FlatStyle.Flat;
            buttonusuariorol.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonusuariorol.ForeColor = Color.White;
            buttonusuariorol.Location = new Point(0, 140);
            buttonusuariorol.Name = "buttonusuariorol";
            buttonusuariorol.Padding = new Padding(30, 0, 0, 0);
            buttonusuariorol.Size = new Size(203, 35);
            buttonusuariorol.TabIndex = 5;
            buttonusuariorol.Text = "Usuario rol";
            buttonusuariorol.TextAlign = ContentAlignment.MiddleLeft;
            buttonusuariorol.UseVisualStyleBackColor = false;
            buttonusuariorol.Click += buttonusuariorol_Click;
            // 
            // buttontodos
            // 
            buttontodos.BackColor = Color.Transparent;
            buttontodos.Dock = DockStyle.Top;
            buttontodos.FlatAppearance.BorderSize = 0;
            buttontodos.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 0);
            buttontodos.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            buttontodos.FlatStyle = FlatStyle.Flat;
            buttontodos.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttontodos.ForeColor = Color.White;
            buttontodos.Location = new Point(0, 0);
            buttontodos.Name = "buttontodos";
            buttontodos.Padding = new Padding(30, 0, 0, 0);
            buttontodos.Size = new Size(203, 35);
            buttontodos.TabIndex = 1;
            buttontodos.Text = "Todos";
            buttontodos.TextAlign = ContentAlignment.MiddleLeft;
            buttontodos.UseVisualStyleBackColor = false;
            buttontodos.Click += buttontodos_Click;
            // 
            // buttonusuarios
            // 
            buttonusuarios.BackColor = Color.Transparent;
            buttonusuarios.Dock = DockStyle.Top;
            buttonusuarios.FlatAppearance.BorderSize = 0;
            buttonusuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 0);
            buttonusuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            buttonusuarios.FlatStyle = FlatStyle.Flat;
            buttonusuarios.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonusuarios.ForeColor = Color.White;
            buttonusuarios.Location = new Point(0, 105);
            buttonusuarios.Name = "buttonusuarios";
            buttonusuarios.Padding = new Padding(30, 0, 0, 0);
            buttonusuarios.Size = new Size(203, 35);
            buttonusuarios.TabIndex = 2;
            buttonusuarios.Text = "Usuarios";
            buttonusuarios.TextAlign = ContentAlignment.MiddleLeft;
            buttonusuarios.UseVisualStyleBackColor = false;
            buttonusuarios.Click += buttonusuarios_Click;
            // 
            // buttonclientes
            // 
            buttonclientes.BackColor = Color.Transparent;
            buttonclientes.Dock = DockStyle.Top;
            buttonclientes.FlatAppearance.BorderSize = 0;
            buttonclientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 0);
            buttonclientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            buttonclientes.FlatStyle = FlatStyle.Flat;
            buttonclientes.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonclientes.ForeColor = Color.White;
            buttonclientes.Location = new Point(0, 70);
            buttonclientes.Name = "buttonclientes";
            buttonclientes.Padding = new Padding(30, 0, 0, 0);
            buttonclientes.Size = new Size(203, 35);
            buttonclientes.TabIndex = 4;
            buttonclientes.Text = "Clientes";
            buttonclientes.TextAlign = ContentAlignment.MiddleLeft;
            buttonclientes.UseVisualStyleBackColor = false;
            buttonclientes.Click += buttonclientes_Click;
            // 
            // buttonproveedores
            // 
            buttonproveedores.BackColor = Color.Transparent;
            buttonproveedores.Dock = DockStyle.Top;
            buttonproveedores.FlatAppearance.BorderSize = 0;
            buttonproveedores.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 0);
            buttonproveedores.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            buttonproveedores.FlatStyle = FlatStyle.Flat;
            buttonproveedores.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonproveedores.ForeColor = Color.White;
            buttonproveedores.Location = new Point(0, 35);
            buttonproveedores.Name = "buttonproveedores";
            buttonproveedores.Padding = new Padding(30, 0, 0, 0);
            buttonproveedores.Size = new Size(203, 35);
            buttonproveedores.TabIndex = 3;
            buttonproveedores.Text = "Proveedores";
            buttonproveedores.TextAlign = ContentAlignment.MiddleLeft;
            buttonproveedores.UseVisualStyleBackColor = false;
            buttonproveedores.Click += buttonproveedores_Click;
            // 
            // buttonpersona
            // 
            buttonpersona.BackColor = Color.Black;
            buttonpersona.BackgroundImageLayout = ImageLayout.Zoom;
            buttonpersona.Cursor = Cursors.Hand;
            buttonpersona.Dock = DockStyle.Top;
            buttonpersona.FlatAppearance.BorderColor = Color.FromArgb(94, 142, 62);
            buttonpersona.FlatAppearance.CheckedBackColor = Color.Silver;
            buttonpersona.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonpersona.FlatAppearance.MouseOverBackColor = Color.Gray;
            buttonpersona.FlatStyle = FlatStyle.Flat;
            buttonpersona.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonpersona.ForeColor = Color.White;
            buttonpersona.Image = (Image)resources.GetObject("buttonpersona.Image");
            buttonpersona.ImageAlign = ContentAlignment.MiddleLeft;
            buttonpersona.Location = new Point(0, 0);
            buttonpersona.Name = "buttonpersona";
            buttonpersona.Size = new Size(203, 45);
            buttonpersona.TabIndex = 5;
            buttonpersona.Text = "PERSONAS";
            buttonpersona.UseVisualStyleBackColor = false;
            buttonpersona.Click += buttonpersona_Click;
            // 
            // panelcargarform
            // 
            panelcargarform.BackColor = Color.FromArgb(40, 40, 40);
            panelcargarform.Controls.Add(pictureBox3);
            panelcargarform.Dock = DockStyle.Fill;
            panelcargarform.Location = new Point(220, 130);
            panelcargarform.Name = "panelcargarform";
            panelcargarform.Size = new Size(764, 531);
            panelcargarform.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(257, 150);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Padding = new Padding(20);
            pictureBox3.Size = new Size(285, 259);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Magneto", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(813, 93);
            label1.Name = "label1";
            label1.Padding = new Padding(1);
            label1.Size = new Size(171, 34);
            label1.TabIndex = 19;
            label1.Text = "GERENTE";
            // 
            // InterfazGerenteMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(984, 661);
            Controls.Add(panelcargarform);
            Controls.Add(panelmenu);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InterfazGerenteMenu";
            StartPosition = FormStartPosition.Manual;
            Text = "InterfazGerente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelmenu.ResumeLayout(false);
            panel5.ResumeLayout(false);
            submenuventas.ResumeLayout(false);
            submenuingresos.ResumeLayout(false);
            submenuproductos.ResumeLayout(false);
            submenupersona.ResumeLayout(false);
            panelcargarform.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelmenu;
        private Panel panelcargarform;
        private PictureBox pictureBox2;
        private Label label4;
        private Button button3;
        private Panel panelpersona;
        private Button buttonpersona;
        private PictureBox pictureBox1;
        private Label label7;
        private Panel submenuproductos;
        private Button buttoncategorias;
        private Button buttonmarcas;
        private Button buttonproductos;
        private Button buttonprod;
        private Panel submenupersona;
        private Button buttontodos;
        private Button buttonusuarios;
        private Button buttonclientes;
        private Button buttonproveedores;
        private Panel panelRol;
        private Label label12;
        private PictureBox pictureBox7;
        private Button buttonrol;
        private Panel submenuventas;
        private Button buttondetallevent;
        private Button buttonvent;
        private Button buttonventa;
        private Panel submenuingresos;
        private Button buttonprovee;
        private Button buttondetalleing;
        private Button buttoningresos;
        private Button buttoning;
        private Panel panel5;
        private PictureBox pictureBox3;
        private Button buttonusuariorol;
        private Label label1;
    }
}