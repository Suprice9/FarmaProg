﻿namespace sistema_de_productos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.barratitulo = new System.Windows.Forms.Panel();
            this.btn_restaurar = new System.Windows.Forms.PictureBox();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_maximizar = new System.Windows.Forms.PictureBox();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.menuvertical = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btn_compras = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.btn_ventas = new System.Windows.Forms.Button();
            this.btn_productos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelcontenedor = new System.Windows.Forms.Panel();
            this.barratitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.menuvertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // barratitulo
            // 
            this.barratitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.barratitulo.Controls.Add(this.btn_restaurar);
            this.barratitulo.Controls.Add(this.btn_minimizar);
            this.barratitulo.Controls.Add(this.btn_maximizar);
            this.barratitulo.Controls.Add(this.btn_cerrar);
            this.barratitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barratitulo.Location = new System.Drawing.Point(0, 0);
            this.barratitulo.Name = "barratitulo";
            this.barratitulo.Size = new System.Drawing.Size(1300, 35);
            this.barratitulo.TabIndex = 0;
            this.barratitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.barratitulo_Paint);
            this.barratitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barratitulo_MouseDown);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_restaurar.Image = ((System.Drawing.Image)(resources.GetObject("btn_restaurar.Image")));
            this.btn_restaurar.Location = new System.Drawing.Point(1222, 7);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(25, 25);
            this.btn_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_restaurar.TabIndex = 3;
            this.btn_restaurar.TabStop = false;
            this.btn_restaurar.Visible = false;
            this.btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(1180, 7);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(25, 25);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_minimizar.TabIndex = 2;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_maximizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_maximizar.Image")));
            this.btn_maximizar.Location = new System.Drawing.Point(1222, 7);
            this.btn_maximizar.Name = "btn_maximizar";
            this.btn_maximizar.Size = new System.Drawing.Size(25, 25);
            this.btn_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_maximizar.TabIndex = 1;
            this.btn_maximizar.TabStop = false;
            this.btn_maximizar.Click += new System.EventHandler(this.btn_maximizar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(1263, 7);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(25, 25);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_cerrar.TabIndex = 0;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // menuvertical
            // 
            this.menuvertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuvertical.Controls.Add(this.pictureBox6);
            this.menuvertical.Controls.Add(this.pictureBox5);
            this.menuvertical.Controls.Add(this.btn_compras);
            this.menuvertical.Controls.Add(this.pictureBox4);
            this.menuvertical.Controls.Add(this.pictureBox3);
            this.menuvertical.Controls.Add(this.pictureBox2);
            this.menuvertical.Controls.Add(this.btn_clientes);
            this.menuvertical.Controls.Add(this.btn_ventas);
            this.menuvertical.Controls.Add(this.btn_productos);
            this.menuvertical.Controls.Add(this.pictureBox1);
            this.menuvertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuvertical.Location = new System.Drawing.Point(0, 35);
            this.menuvertical.Name = "menuvertical";
            this.menuvertical.Size = new System.Drawing.Size(220, 615);
            this.menuvertical.TabIndex = 1;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(12, 546);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(46, 57);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(25, 381);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(33, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // btn_compras
            // 
            this.btn_compras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_compras.FlatAppearance.BorderSize = 0;
            this.btn_compras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_compras.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_compras.Location = new System.Drawing.Point(9, 362);
            this.btn_compras.Name = "btn_compras";
            this.btn_compras.Size = new System.Drawing.Size(202, 68);
            this.btn_compras.TabIndex = 6;
            this.btn_compras.Text = "compras";
            this.btn_compras.UseVisualStyleBackColor = false;
            this.btn_compras.Click += new System.EventHandler(this.btn_compras_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(25, 474);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(25, 288);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 176);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btn_clientes
            // 
            this.btn_clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_clientes.FlatAppearance.BorderSize = 0;
            this.btn_clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_clientes.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clientes.Location = new System.Drawing.Point(10, 455);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(202, 68);
            this.btn_clientes.TabIndex = 3;
            this.btn_clientes.Text = "clientes";
            this.btn_clientes.UseVisualStyleBackColor = false;
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
            // 
            // btn_ventas
            // 
            this.btn_ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_ventas.FlatAppearance.BorderSize = 0;
            this.btn_ventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_ventas.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ventas.Location = new System.Drawing.Point(12, 270);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(202, 68);
            this.btn_ventas.TabIndex = 2;
            this.btn_ventas.Text = "ventas";
            this.btn_ventas.UseVisualStyleBackColor = false;
            this.btn_ventas.Click += new System.EventHandler(this.btn_ventas_Click);
            // 
            // btn_productos
            // 
            this.btn_productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_productos.FlatAppearance.BorderSize = 0;
            this.btn_productos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_productos.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_productos.Location = new System.Drawing.Point(12, 166);
            this.btn_productos.Name = "btn_productos";
            this.btn_productos.Size = new System.Drawing.Size(202, 68);
            this.btn_productos.TabIndex = 1;
            this.btn_productos.Text = "productos";
            this.btn_productos.UseVisualStyleBackColor = false;
            this.btn_productos.Click += new System.EventHandler(this.btn_productos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.Location = new System.Drawing.Point(220, 35);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(1080, 615);
            this.panelcontenedor.TabIndex = 2;
            this.panelcontenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcontenedor_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.menuvertical);
            this.Controls.Add(this.barratitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.barratitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.menuvertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barratitulo;
        private System.Windows.Forms.PictureBox btn_cerrar;
        private System.Windows.Forms.Panel menuvertical;
        private System.Windows.Forms.Panel panelcontenedor;
        private System.Windows.Forms.PictureBox btn_restaurar;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.PictureBox btn_maximizar;
        private System.Windows.Forms.Button btn_productos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btn_compras;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.Button btn_ventas;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}
