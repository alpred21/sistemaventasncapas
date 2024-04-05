namespace SistemasVentas.VISTA.InterfazVistas
{
    partial class InterfazVentasMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazVentasMenu));
            pictureBox3 = new PictureBox();
            buttonprod = new Button();
            buttoncategorias = new Button();
            buttonmarcas = new Button();
            buttonproductos = new Button();
            submenuproductos = new Panel();
            buttonventa = new Button();
            buttondetallevent = new Button();
            buttonvent = new Button();
            panel5 = new Panel();
            button3 = new Button();
            submenuventas = new Panel();
            panelmenu = new Panel();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            panelcargarform = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            submenuproductos.SuspendLayout();
            panel5.SuspendLayout();
            submenuventas.SuspendLayout();
            panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelcargarform.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(343, 115);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Padding = new Padding(20);
            pictureBox3.Size = new Size(285, 259);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
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
            buttonprod.Location = new Point(0, 0);
            buttonprod.Name = "buttonprod";
            buttonprod.Size = new Size(220, 45);
            buttonprod.TabIndex = 12;
            buttonprod.Text = "PRODUCTOS";
            buttonprod.UseVisualStyleBackColor = false;
            buttonprod.Click += buttonprod_Click;
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
            buttoncategorias.Size = new Size(220, 35);
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
            buttonmarcas.Size = new Size(220, 35);
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
            buttonproductos.Size = new Size(220, 35);
            buttonproductos.TabIndex = 3;
            buttonproductos.Text = "Productos";
            buttonproductos.TextAlign = ContentAlignment.MiddleLeft;
            buttonproductos.UseVisualStyleBackColor = false;
            buttonproductos.Click += buttonproductos_Click;
            // 
            // submenuproductos
            // 
            submenuproductos.BackColor = Color.FromArgb(6, 21, 1);
            submenuproductos.Controls.Add(buttoncategorias);
            submenuproductos.Controls.Add(buttonmarcas);
            submenuproductos.Controls.Add(buttonproductos);
            submenuproductos.Dock = DockStyle.Top;
            submenuproductos.Location = new Point(0, 45);
            submenuproductos.Name = "submenuproductos";
            submenuproductos.Size = new Size(220, 105);
            submenuproductos.TabIndex = 13;
            submenuproductos.Visible = false;
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
            buttonventa.Location = new Point(0, 150);
            buttonventa.Name = "buttonventa";
            buttonventa.Size = new Size(220, 45);
            buttonventa.TabIndex = 16;
            buttonventa.Text = "VENTAS";
            buttonventa.UseVisualStyleBackColor = false;
            buttonventa.Click += buttonventa_Click;
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
            buttondetallevent.Size = new Size(220, 35);
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
            buttonvent.Size = new Size(220, 35);
            buttonvent.TabIndex = 3;
            buttonvent.Text = "Ventas";
            buttonvent.TextAlign = ContentAlignment.MiddleLeft;
            buttonvent.UseVisualStyleBackColor = false;
            buttonvent.Click += buttonvent_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(button3);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 444);
            panel5.Name = "panel5";
            panel5.Size = new Size(220, 87);
            panel5.TabIndex = 19;
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
            // submenuventas
            // 
            submenuventas.BackColor = Color.FromArgb(6, 21, 1);
            submenuventas.Controls.Add(buttondetallevent);
            submenuventas.Controls.Add(buttonvent);
            submenuventas.Dock = DockStyle.Top;
            submenuventas.Location = new Point(0, 195);
            submenuventas.Name = "submenuventas";
            submenuventas.Size = new Size(220, 70);
            submenuventas.TabIndex = 17;
            submenuventas.Visible = false;
            // 
            // panelmenu
            // 
            panelmenu.AutoScroll = true;
            panelmenu.BackColor = Color.Black;
            panelmenu.BackgroundImageLayout = ImageLayout.None;
            panelmenu.Controls.Add(panel5);
            panelmenu.Controls.Add(submenuventas);
            panelmenu.Controls.Add(buttonventa);
            panelmenu.Controls.Add(submenuproductos);
            panelmenu.Controls.Add(buttonprod);
            panelmenu.Dock = DockStyle.Left;
            panelmenu.Location = new Point(0, 130);
            panelmenu.Name = "panelmenu";
            panelmenu.Size = new Size(220, 531);
            panelmenu.TabIndex = 4;
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
            // panelcargarform
            // 
            panelcargarform.BackColor = Color.FromArgb(40, 40, 40);
            panelcargarform.Controls.Add(pictureBox3);
            panelcargarform.Dock = DockStyle.Fill;
            panelcargarform.Location = new Point(220, 130);
            panelcargarform.Name = "panelcargarform";
            panelcargarform.Size = new Size(764, 531);
            panelcargarform.TabIndex = 5;
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
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Magneto", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(824, 93);
            label1.Name = "label1";
            label1.Padding = new Padding(1);
            label1.Size = new Size(157, 34);
            label1.TabIndex = 19;
            label1.Text = "VENTAS";
            // 
            // InterfazVentasMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(panelcargarform);
            Controls.Add(panelmenu);
            Controls.Add(panel1);
            Name = "InterfazVentasMenu";
            Text = "InterfazVentasMenu";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            submenuproductos.ResumeLayout(false);
            panel5.ResumeLayout(false);
            submenuventas.ResumeLayout(false);
            panelmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelcargarform.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox3;
        private Button buttonprod;
        private Button buttoncategorias;
        private Button buttonmarcas;
        private Button buttonproductos;
        private Panel submenuproductos;
        private Button buttonventa;
        private Button buttondetallevent;
        private Button buttonvent;
        private Panel panel5;
        private Button button3;
        private Panel submenuventas;
        private Panel panelmenu;
        private Label label4;
        private PictureBox pictureBox2;
        private Panel panelcargarform;
        private Panel panel1;
        private Label label1;
    }
}