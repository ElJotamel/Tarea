namespace Tarea
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxDistrito = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.textBoxMontoPedido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewdbTarea = new System.Windows.Forms.DataGridView();
            this.dbTareaDataSetchi = new Tarea.dbTareaDataSetchi();
            this.pedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidosTableAdapter = new Tarea.dbTareaDataSetchiTableAdapters.PedidosTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distritoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdbTarea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTareaDataSetchi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDistrito
            // 
            this.comboBoxDistrito.FormattingEnabled = true;
            this.comboBoxDistrito.Location = new System.Drawing.Point(224, 259);
            this.comboBoxDistrito.Name = "comboBoxDistrito";
            this.comboBoxDistrito.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDistrito.TabIndex = 0;
            this.comboBoxDistrito.DropDown += new System.EventHandler(this.Form1_Load);
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(82, 105);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFecha.TabIndex = 1;
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.Location = new System.Drawing.Point(224, 151);
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombreCliente.TabIndex = 2;
            // 
            // textBoxMontoPedido
            // 
            this.textBoxMontoPedido.Location = new System.Drawing.Point(224, 200);
            this.textBoxMontoPedido.Name = "textBoxMontoPedido";
            this.textBoxMontoPedido.Size = new System.Drawing.Size(100, 20);
            this.textBoxMontoPedido.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Monto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Distrito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dataGridViewdbTarea
            // 
            this.dataGridViewdbTarea.AutoGenerateColumns = false;
            this.dataGridViewdbTarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdbTarea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.nombreClienteDataGridViewTextBoxColumn,
            this.montoPedidoDataGridViewTextBoxColumn,
            this.distritoDataGridViewTextBoxColumn});
            this.dataGridViewdbTarea.DataSource = this.pedidosBindingSource;
            this.dataGridViewdbTarea.Location = new System.Drawing.Point(439, 126);
            this.dataGridViewdbTarea.Name = "dataGridViewdbTarea";
            this.dataGridViewdbTarea.Size = new System.Drawing.Size(541, 173);
            this.dataGridViewdbTarea.TabIndex = 10;
            // 
            // dbTareaDataSetchi
            // 
            this.dbTareaDataSetchi.DataSetName = "dbTareaDataSetchi";
            this.dbTareaDataSetchi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidosBindingSource
            // 
            this.pedidosBindingSource.DataMember = "Pedidos";
            this.pedidosBindingSource.DataSource = this.dbTareaDataSetchi;
            // 
            // pedidosTableAdapter
            // 
            this.pedidosTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // nombreClienteDataGridViewTextBoxColumn
            // 
            this.nombreClienteDataGridViewTextBoxColumn.DataPropertyName = "NombreCliente";
            this.nombreClienteDataGridViewTextBoxColumn.HeaderText = "NombreCliente";
            this.nombreClienteDataGridViewTextBoxColumn.Name = "nombreClienteDataGridViewTextBoxColumn";
            // 
            // montoPedidoDataGridViewTextBoxColumn
            // 
            this.montoPedidoDataGridViewTextBoxColumn.DataPropertyName = "MontoPedido";
            this.montoPedidoDataGridViewTextBoxColumn.HeaderText = "MontoPedido";
            this.montoPedidoDataGridViewTextBoxColumn.Name = "montoPedidoDataGridViewTextBoxColumn";
            // 
            // distritoDataGridViewTextBoxColumn
            // 
            this.distritoDataGridViewTextBoxColumn.DataPropertyName = "Distrito";
            this.distritoDataGridViewTextBoxColumn.HeaderText = "Distrito";
            this.distritoDataGridViewTextBoxColumn.Name = "distritoDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 450);
            this.Controls.Add(this.dataGridViewdbTarea);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMontoPedido);
            this.Controls.Add(this.textBoxNombreCliente);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.comboBoxDistrito);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdbTarea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTareaDataSetchi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDistrito;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.TextBox textBoxNombreCliente;
        private System.Windows.Forms.TextBox textBoxMontoPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewdbTarea;
        private dbTareaDataSetchi dbTareaDataSetchi;
        private System.Windows.Forms.BindingSource pedidosBindingSource;
        private dbTareaDataSetchiTableAdapters.PedidosTableAdapter pedidosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distritoDataGridViewTextBoxColumn;
    }
}

