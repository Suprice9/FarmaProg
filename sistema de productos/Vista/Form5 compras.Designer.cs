namespace sistema_de_productos
{
    partial class Form5_compras
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
            this.GB_datoscompra = new System.Windows.Forms.GroupBox();
            this.txt_presentacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_iddatoscompra = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_comprobante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_concentracion = new System.Windows.Forms.TextBox();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_concentracion = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_producto = new System.Windows.Forms.Label();
            this.GB_datosdelproducto = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_totalapagar = new System.Windows.Forms.TextBox();
            this.btn_nuevo_compras = new System.Windows.Forms.Button();
            this.btn_guardar_compras = new System.Windows.Forms.Button();
            this.btn_cancelar_compras = new System.Windows.Forms.Button();
            this.btn_menu_principal = new System.Windows.Forms.Button();
            this.btn_imprimir_factura = new System.Windows.Forms.Button();
            this.GB_datoscompra.SuspendLayout();
            this.GB_datosdelproducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_datoscompra
            // 
            this.GB_datoscompra.Controls.Add(this.txt_presentacion);
            this.GB_datoscompra.Controls.Add(this.label4);
            this.GB_datoscompra.Controls.Add(this.txt_iddatoscompra);
            this.GB_datoscompra.Controls.Add(this.textBox3);
            this.GB_datoscompra.Controls.Add(this.label5);
            this.GB_datoscompra.Controls.Add(this.txt_comprobante);
            this.GB_datoscompra.Controls.Add(this.label3);
            this.GB_datoscompra.Controls.Add(this.label2);
            this.GB_datoscompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_datoscompra.Location = new System.Drawing.Point(20, 23);
            this.GB_datoscompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_datoscompra.Name = "GB_datoscompra";
            this.GB_datoscompra.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_datoscompra.Size = new System.Drawing.Size(578, 142);
            this.GB_datoscompra.TabIndex = 0;
            this.GB_datoscompra.TabStop = false;
            this.GB_datoscompra.Text = "Datos de la compra";
            this.GB_datoscompra.Enter += new System.EventHandler(this.GB_datoscompra_Enter);
            // 
            // txt_presentacion
            // 
            this.txt_presentacion.Location = new System.Drawing.Point(169, 65);
            this.txt_presentacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_presentacion.Name = "txt_presentacion";
            this.txt_presentacion.Size = new System.Drawing.Size(102, 19);
            this.txt_presentacion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(464, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha:";
            // 
            // txt_iddatoscompra
            // 
            this.txt_iddatoscompra.Location = new System.Drawing.Point(13, 65);
            this.txt_iddatoscompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_iddatoscompra.Name = "txt_iddatoscompra";
            this.txt_iddatoscompra.Size = new System.Drawing.Size(102, 19);
            this.txt_iddatoscompra.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(448, 67);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(102, 19);
            this.textBox3.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(310, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Comprobante:";
            // 
            // txt_comprobante
            // 
            this.txt_comprobante.Location = new System.Drawing.Point(308, 65);
            this.txt_comprobante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_comprobante.Name = "txt_comprobante";
            this.txt_comprobante.Size = new System.Drawing.Size(102, 19);
            this.txt_comprobante.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Presentacion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "id:";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(409, 69);
            this.txt_precio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(102, 19);
            this.txt_precio.TabIndex = 10;
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(247, 105);
            this.txt_stock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(102, 19);
            this.txt_stock.TabIndex = 9;
            // 
            // txt_producto
            // 
            this.txt_producto.Location = new System.Drawing.Point(247, 49);
            this.txt_producto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(102, 19);
            this.txt_producto.TabIndex = 8;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(13, 47);
            this.txt_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(102, 19);
            this.txt_id.TabIndex = 7;
            // 
            // txt_concentracion
            // 
            this.txt_concentracion.Location = new System.Drawing.Point(13, 107);
            this.txt_concentracion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_concentracion.Name = "txt_concentracion";
            this.txt_concentracion.Size = new System.Drawing.Size(102, 19);
            this.txt_concentracion.TabIndex = 6;
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.Location = new System.Drawing.Point(435, 47);
            this.lbl_precio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(55, 18);
            this.lbl_precio.TabIndex = 4;
            this.lbl_precio.Text = "Precio:";
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock.Location = new System.Drawing.Point(274, 83);
            this.lbl_stock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(51, 18);
            this.lbl_stock.TabIndex = 3;
            this.lbl_stock.Text = "Stock:";
            // 
            // lbl_concentracion
            // 
            this.lbl_concentracion.AutoSize = true;
            this.lbl_concentracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_concentracion.Location = new System.Drawing.Point(10, 85);
            this.lbl_concentracion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_concentracion.Name = "lbl_concentracion";
            this.lbl_concentracion.Size = new System.Drawing.Size(109, 18);
            this.lbl_concentracion.TabIndex = 2;
            this.lbl_concentracion.Text = "Concentracion:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(46, 25);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(23, 18);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "id:";
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_producto.Location = new System.Drawing.Point(262, 25);
            this.lbl_producto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(73, 18);
            this.lbl_producto.TabIndex = 0;
            this.lbl_producto.Text = "Producto:";
            // 
            // GB_datosdelproducto
            // 
            this.GB_datosdelproducto.Controls.Add(this.txt_precio);
            this.GB_datosdelproducto.Controls.Add(this.txt_id);
            this.GB_datosdelproducto.Controls.Add(this.txt_stock);
            this.GB_datosdelproducto.Controls.Add(this.lbl_id);
            this.GB_datosdelproducto.Controls.Add(this.txt_producto);
            this.GB_datosdelproducto.Controls.Add(this.lbl_precio);
            this.GB_datosdelproducto.Controls.Add(this.lbl_concentracion);
            this.GB_datosdelproducto.Controls.Add(this.lbl_stock);
            this.GB_datosdelproducto.Controls.Add(this.txt_concentracion);
            this.GB_datosdelproducto.Controls.Add(this.lbl_producto);
            this.GB_datosdelproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_datosdelproducto.Location = new System.Drawing.Point(20, 196);
            this.GB_datosdelproducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_datosdelproducto.Name = "GB_datosdelproducto";
            this.GB_datosdelproducto.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_datosdelproducto.Size = new System.Drawing.Size(578, 142);
            this.GB_datosdelproducto.TabIndex = 1;
            this.GB_datosdelproducto.TabStop = false;
            this.GB_datosdelproducto.Text = "Datos del producto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.productos,
            this.Presentacion,
            this.cantidad,
            this.Precio,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(20, 358);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(578, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // productos
            // 
            this.productos.HeaderText = "Producto";
            this.productos.Name = "productos";
            // 
            // Presentacion
            // 
            this.Presentacion.HeaderText = "Presentacion";
            this.Presentacion.Name = "Presentacion";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 520);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total a pagar:";
            // 
            // txt_totalapagar
            // 
            this.txt_totalapagar.BackColor = System.Drawing.Color.Chartreuse;
            this.txt_totalapagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalapagar.Location = new System.Drawing.Point(429, 522);
            this.txt_totalapagar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_totalapagar.Name = "txt_totalapagar";
            this.txt_totalapagar.Size = new System.Drawing.Size(170, 28);
            this.txt_totalapagar.TabIndex = 11;
            // 
            // btn_nuevo_compras
            // 
            this.btn_nuevo_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo_compras.Location = new System.Drawing.Point(739, 440);
            this.btn_nuevo_compras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_nuevo_compras.Name = "btn_nuevo_compras";
            this.btn_nuevo_compras.Size = new System.Drawing.Size(108, 47);
            this.btn_nuevo_compras.TabIndex = 12;
            this.btn_nuevo_compras.Text = "Nuevo";
            this.btn_nuevo_compras.UseVisualStyleBackColor = true;
            // 
            // btn_guardar_compras
            // 
            this.btn_guardar_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_compras.Location = new System.Drawing.Point(862, 440);
            this.btn_guardar_compras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_guardar_compras.Name = "btn_guardar_compras";
            this.btn_guardar_compras.Size = new System.Drawing.Size(108, 47);
            this.btn_guardar_compras.TabIndex = 13;
            this.btn_guardar_compras.Text = "Guardar";
            this.btn_guardar_compras.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar_compras
            // 
            this.btn_cancelar_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar_compras.Location = new System.Drawing.Point(983, 440);
            this.btn_cancelar_compras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancelar_compras.Name = "btn_cancelar_compras";
            this.btn_cancelar_compras.Size = new System.Drawing.Size(108, 47);
            this.btn_cancelar_compras.TabIndex = 14;
            this.btn_cancelar_compras.Text = "Cancelar";
            this.btn_cancelar_compras.UseVisualStyleBackColor = true;
            // 
            // btn_menu_principal
            // 
            this.btn_menu_principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_principal.Location = new System.Drawing.Point(1002, 10);
            this.btn_menu_principal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_menu_principal.Name = "btn_menu_principal";
            this.btn_menu_principal.Size = new System.Drawing.Size(108, 47);
            this.btn_menu_principal.TabIndex = 15;
            this.btn_menu_principal.Text = "Volver al menu";
            this.btn_menu_principal.UseVisualStyleBackColor = true;
            this.btn_menu_principal.Click += new System.EventHandler(this.btn_menu_principal_Click);
            // 
            // btn_imprimir_factura
            // 
            this.btn_imprimir_factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir_factura.Location = new System.Drawing.Point(739, 500);
            this.btn_imprimir_factura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_imprimir_factura.Name = "btn_imprimir_factura";
            this.btn_imprimir_factura.Size = new System.Drawing.Size(352, 47);
            this.btn_imprimir_factura.TabIndex = 16;
            this.btn_imprimir_factura.Text = "Imprimir";
            this.btn_imprimir_factura.UseVisualStyleBackColor = true;
            // 
            // Form5_compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 557);
            this.Controls.Add(this.btn_imprimir_factura);
            this.Controls.Add(this.btn_menu_principal);
            this.Controls.Add(this.btn_cancelar_compras);
            this.Controls.Add(this.btn_guardar_compras);
            this.Controls.Add(this.btn_nuevo_compras);
            this.Controls.Add(this.txt_totalapagar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GB_datosdelproducto);
            this.Controls.Add(this.GB_datoscompra);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form5_compras";
            this.Text = "Form5_compras";
            this.GB_datoscompra.ResumeLayout(false);
            this.GB_datoscompra.PerformLayout();
            this.GB_datosdelproducto.ResumeLayout(false);
            this.GB_datosdelproducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_datoscompra;
        private System.Windows.Forms.GroupBox GB_datosdelproducto;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Label lbl_concentracion;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_producto;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_concentracion;
        private System.Windows.Forms.TextBox txt_presentacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_iddatoscompra;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_comprobante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_totalapagar;
        private System.Windows.Forms.Button btn_nuevo_compras;
        private System.Windows.Forms.Button btn_guardar_compras;
        private System.Windows.Forms.Button btn_cancelar_compras;
        private System.Windows.Forms.Button btn_menu_principal;
        private System.Windows.Forms.Button btn_imprimir_factura;
    }
}