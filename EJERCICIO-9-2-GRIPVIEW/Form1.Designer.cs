namespace EJERCICIO_9_2_GRIPVIEW
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btadicional = new System.Windows.Forms.Button();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.cbcantidad = new System.Windows.Forms.ComboBox();
            this.dwrecibe = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bteliminar = new System.Windows.Forms.Button();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btactualizar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btbuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dwrecibe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // btadicional
            // 
            this.btadicional.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btadicional.Location = new System.Drawing.Point(756, 129);
            this.btadicional.Name = "btadicional";
            this.btadicional.Size = new System.Drawing.Size(87, 44);
            this.btadicional.TabIndex = 1;
            this.btadicional.Text = "Adicionar";
            this.btadicional.UseVisualStyleBackColor = true;
            this.btadicional.Click += new System.EventHandler(this.btadicional_Click);
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(48, 129);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(121, 23);
            this.txtproducto.TabIndex = 2;
            // 
            // cbcantidad
            // 
            this.cbcantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcantidad.FormattingEnabled = true;
            this.cbcantidad.Location = new System.Drawing.Point(213, 129);
            this.cbcantidad.Name = "cbcantidad";
            this.cbcantidad.Size = new System.Drawing.Size(60, 23);
            this.cbcantidad.TabIndex = 3;
            // 
            // dwrecibe
            // 
            this.dwrecibe.AllowUserToAddRows = false;
            this.dwrecibe.AllowUserToDeleteRows = false;
            this.dwrecibe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dwrecibe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Cantidad,
            this.Precio,
            this.Subtotal});
            this.dwrecibe.Location = new System.Drawing.Point(48, 246);
            this.dwrecibe.Name = "dwrecibe";
            this.dwrecibe.ReadOnly = true;
            this.dwrecibe.RowTemplate.Height = 25;
            this.dwrecibe.Size = new System.Drawing.Size(601, 174);
            this.dwrecibe.TabIndex = 4;
            this.dwrecibe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dwrecibe_CellClick);
            this.dwrecibe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dwrecibe_CellContentClick);
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 200;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 150;
            // 
            // bteliminar
            // 
            this.bteliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bteliminar.Location = new System.Drawing.Point(756, 197);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(87, 44);
            this.bteliminar.TabIndex = 5;
            this.bteliminar.Text = "Eliminar";
            this.bteliminar.UseVisualStyleBackColor = true;
            this.bteliminar.Click += new System.EventHandler(this.bteliminar_Click);
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(404, 129);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(121, 23);
            this.txtprecio.TabIndex = 7;
            this.txtprecio.TextChanged += new System.EventHandler(this.txtprecio_TextChanged);
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Location = new System.Drawing.Point(581, 129);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(121, 23);
            this.txtsubtotal.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(213, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(404, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(581, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Subtotal";
            // 
            // btactualizar
            // 
            this.btactualizar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btactualizar.Location = new System.Drawing.Point(756, 263);
            this.btactualizar.Name = "btactualizar";
            this.btactualizar.Size = new System.Drawing.Size(87, 44);
            this.btactualizar.TabIndex = 12;
            this.btactualizar.Text = "Actualizar";
            this.btactualizar.UseVisualStyleBackColor = true;
            this.btactualizar.Click += new System.EventHandler(this.btactualizar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(48, 197);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(149, 23);
            this.txtbuscar.TabIndex = 13;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // btbuscar
            // 
            this.btbuscar.Location = new System.Drawing.Point(242, 197);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(75, 23);
            this.btbuscar.TabIndex = 14;
            this.btbuscar.Text = "Buscar";
            this.btbuscar.UseVisualStyleBackColor = true;
            this.btbuscar.Click += new System.EventHandler(this.btbuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 450);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.btactualizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.bteliminar);
            this.Controls.Add(this.dwrecibe);
            this.Controls.Add(this.cbcantidad);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.btadicional);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dwrecibe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btadicional;
        private TextBox txtproducto;
        private ComboBox cbcantidad;
        private DataGridView dwrecibe;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Subtotal;
        private Button bteliminar;
        private TextBox txtprecio;
        private TextBox txtsubtotal;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btactualizar;
        private TextBox txtbuscar;
        private Button btbuscar;
    }
}