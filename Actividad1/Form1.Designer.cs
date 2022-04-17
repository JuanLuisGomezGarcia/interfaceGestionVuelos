
namespace Actividad1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bt_reserva = new System.Windows.Forms.Button();
            this.label_Aerolinea = new System.Windows.Forms.Label();
            this.list_aerolinea = new System.Windows.Forms.ComboBox();
            this.list_aeropuerto_origen = new System.Windows.Forms.ComboBox();
            this.label_Origen = new System.Windows.Forms.Label();
            this.list_aeropuerto_destino = new System.Windows.Forms.ComboBox();
            this.label_Destino = new System.Windows.Forms.Label();
            this.CheckBox_EquipajeExtra = new System.Windows.Forms.CheckBox();
            this.checkBox_niños = new System.Windows.Forms.CheckBox();
            this.textBox_numeroNiños = new System.Windows.Forms.TextBox();
            this.button_salir = new System.Windows.Forms.Button();
            this.dateTimePicker_fechaIda = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_fechaVuelta = new System.Windows.Forms.DateTimePicker();
            this.panel_fecha = new System.Windows.Forms.Panel();
            this.label_FechaVuelta = new System.Windows.Forms.Label();
            this.label_FechaIda = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_datos = new System.Windows.Forms.Panel();
            this.label_Billetes = new System.Windows.Forms.Label();
            this.textBox_billetes = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_filtro = new System.Windows.Forms.Button();
            this.textBox_codigo = new System.Windows.Forms.TextBox();
            this.label_Codigo = new System.Windows.Forms.Label();
            this.button_Informacion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_fecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel_datos.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_reserva
            // 
            this.bt_reserva.BackColor = System.Drawing.Color.Red;
            this.bt_reserva.Location = new System.Drawing.Point(308, 516);
            this.bt_reserva.Name = "bt_reserva";
            this.bt_reserva.Size = new System.Drawing.Size(198, 38);
            this.bt_reserva.TabIndex = 1;
            this.bt_reserva.Text = "CONFIRMAR RESERVA";
            this.bt_reserva.UseVisualStyleBackColor = false;
            this.bt_reserva.Click += new System.EventHandler(this.bt_reserva_Click);
            // 
            // label_Aerolinea
            // 
            this.label_Aerolinea.AutoSize = true;
            this.label_Aerolinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Aerolinea.Location = new System.Drawing.Point(10, 16);
            this.label_Aerolinea.Name = "label_Aerolinea";
            this.label_Aerolinea.Size = new System.Drawing.Size(104, 25);
            this.label_Aerolinea.TabIndex = 6;
            this.label_Aerolinea.Text = "Aerolinea";
            // 
            // list_aerolinea
            // 
            this.list_aerolinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_aerolinea.FormattingEnabled = true;
            this.list_aerolinea.Location = new System.Drawing.Point(135, 16);
            this.list_aerolinea.Name = "list_aerolinea";
            this.list_aerolinea.Size = new System.Drawing.Size(182, 33);
            this.list_aerolinea.TabIndex = 8;
            this.list_aerolinea.SelectedIndexChanged += new System.EventHandler(this.list_aerolinea_SelectedIndexChanged);
            // 
            // list_aeropuerto_origen
            // 
            this.list_aeropuerto_origen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_aeropuerto_origen.FormattingEnabled = true;
            this.list_aeropuerto_origen.Location = new System.Drawing.Point(135, 69);
            this.list_aeropuerto_origen.Name = "list_aeropuerto_origen";
            this.list_aeropuerto_origen.Size = new System.Drawing.Size(182, 33);
            this.list_aeropuerto_origen.TabIndex = 9;
            // 
            // label_Origen
            // 
            this.label_Origen.AutoSize = true;
            this.label_Origen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Origen.Location = new System.Drawing.Point(37, 69);
            this.label_Origen.Name = "label_Origen";
            this.label_Origen.Size = new System.Drawing.Size(77, 25);
            this.label_Origen.TabIndex = 10;
            this.label_Origen.Text = "Origen";
            // 
            // list_aeropuerto_destino
            // 
            this.list_aeropuerto_destino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_aeropuerto_destino.FormattingEnabled = true;
            this.list_aeropuerto_destino.Location = new System.Drawing.Point(135, 122);
            this.list_aeropuerto_destino.Name = "list_aeropuerto_destino";
            this.list_aeropuerto_destino.Size = new System.Drawing.Size(182, 33);
            this.list_aeropuerto_destino.TabIndex = 12;
            // 
            // label_Destino
            // 
            this.label_Destino.AutoSize = true;
            this.label_Destino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Destino.Location = new System.Drawing.Point(29, 122);
            this.label_Destino.Name = "label_Destino";
            this.label_Destino.Size = new System.Drawing.Size(85, 25);
            this.label_Destino.TabIndex = 13;
            this.label_Destino.Text = "Destino";
            // 
            // CheckBox_EquipajeExtra
            // 
            this.CheckBox_EquipajeExtra.AutoSize = true;
            this.CheckBox_EquipajeExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox_EquipajeExtra.Location = new System.Drawing.Point(0, 0);
            this.CheckBox_EquipajeExtra.Name = "CheckBox_EquipajeExtra";
            this.CheckBox_EquipajeExtra.Size = new System.Drawing.Size(174, 29);
            this.CheckBox_EquipajeExtra.TabIndex = 14;
            this.CheckBox_EquipajeExtra.Text = "Extra Equipaje";
            this.CheckBox_EquipajeExtra.UseVisualStyleBackColor = true;
            // 
            // checkBox_niños
            // 
            this.checkBox_niños.AutoSize = true;
            this.checkBox_niños.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_niños.Location = new System.Drawing.Point(1, 27);
            this.checkBox_niños.Name = "checkBox_niños";
            this.checkBox_niños.Size = new System.Drawing.Size(118, 29);
            this.checkBox_niños.TabIndex = 18;
            this.checkBox_niños.Text = "Menores";
            this.checkBox_niños.UseVisualStyleBackColor = true;
            this.checkBox_niños.CheckedChanged += new System.EventHandler(this.checkBox_niños_CheckedChanged);
            // 
            // textBox_numeroNiños
            // 
            this.textBox_numeroNiños.Location = new System.Drawing.Point(1, 53);
            this.textBox_numeroNiños.Name = "textBox_numeroNiños";
            this.textBox_numeroNiños.Size = new System.Drawing.Size(100, 22);
            this.textBox_numeroNiños.TabIndex = 19;
            // 
            // button_salir
            // 
            this.button_salir.BackColor = System.Drawing.Color.OrangeRed;
            this.button_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_salir.Location = new System.Drawing.Point(12, 516);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(87, 38);
            this.button_salir.TabIndex = 20;
            this.button_salir.Text = "SALIR";
            this.button_salir.UseVisualStyleBackColor = false;
            this.button_salir.Click += new System.EventHandler(this.button_salir_Click);
            // 
            // dateTimePicker_fechaIda
            // 
            this.dateTimePicker_fechaIda.Location = new System.Drawing.Point(144, 21);
            this.dateTimePicker_fechaIda.Name = "dateTimePicker_fechaIda";
            this.dateTimePicker_fechaIda.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_fechaIda.TabIndex = 21;
            // 
            // dateTimePicker_fechaVuelta
            // 
            this.dateTimePicker_fechaVuelta.Location = new System.Drawing.Point(144, 63);
            this.dateTimePicker_fechaVuelta.Name = "dateTimePicker_fechaVuelta";
            this.dateTimePicker_fechaVuelta.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_fechaVuelta.TabIndex = 22;
            // 
            // panel_fecha
            // 
            this.panel_fecha.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel_fecha.Controls.Add(this.label_FechaVuelta);
            this.panel_fecha.Controls.Add(this.dateTimePicker_fechaVuelta);
            this.panel_fecha.Controls.Add(this.dateTimePicker_fechaIda);
            this.panel_fecha.Controls.Add(this.label_FechaIda);
            this.panel_fecha.Location = new System.Drawing.Point(436, 232);
            this.panel_fecha.Name = "panel_fecha";
            this.panel_fecha.Size = new System.Drawing.Size(352, 108);
            this.panel_fecha.TabIndex = 23;
            // 
            // label_FechaVuelta
            // 
            this.label_FechaVuelta.AutoSize = true;
            this.label_FechaVuelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FechaVuelta.Location = new System.Drawing.Point(3, 65);
            this.label_FechaVuelta.Name = "label_FechaVuelta";
            this.label_FechaVuelta.Size = new System.Drawing.Size(116, 20);
            this.label_FechaVuelta.TabIndex = 24;
            this.label_FechaVuelta.Text = "Fecha vuelta";
            // 
            // label_FechaIda
            // 
            this.label_FechaIda.AutoSize = true;
            this.label_FechaIda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FechaIda.Location = new System.Drawing.Point(12, 19);
            this.label_FechaIda.Name = "label_FechaIda";
            this.label_FechaIda.Size = new System.Drawing.Size(103, 24);
            this.label_FechaIda.TabIndex = 23;
            this.label_FechaIda.Text = "Fecha ida";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel_datos
            // 
            this.panel_datos.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel_datos.Controls.Add(this.label_Billetes);
            this.panel_datos.Controls.Add(this.textBox_billetes);
            this.panel_datos.Controls.Add(this.list_aerolinea);
            this.panel_datos.Controls.Add(this.label_Aerolinea);
            this.panel_datos.Controls.Add(this.list_aeropuerto_origen);
            this.panel_datos.Controls.Add(this.label_Origen);
            this.panel_datos.Controls.Add(this.list_aeropuerto_destino);
            this.panel_datos.Controls.Add(this.label_Destino);
            this.panel_datos.Location = new System.Drawing.Point(21, 232);
            this.panel_datos.Name = "panel_datos";
            this.panel_datos.Size = new System.Drawing.Size(346, 210);
            this.panel_datos.TabIndex = 24;
            // 
            // label_Billetes
            // 
            this.label_Billetes.AutoSize = true;
            this.label_Billetes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Billetes.Location = new System.Drawing.Point(32, 172);
            this.label_Billetes.Name = "label_Billetes";
            this.label_Billetes.Size = new System.Drawing.Size(82, 25);
            this.label_Billetes.TabIndex = 26;
            this.label_Billetes.Text = "Billetes";
            // 
            // textBox_billetes
            // 
            this.textBox_billetes.Location = new System.Drawing.Point(135, 172);
            this.textBox_billetes.Name = "textBox_billetes";
            this.textBox_billetes.Size = new System.Drawing.Size(100, 22);
            this.textBox_billetes.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Sienna;
            this.panel2.Controls.Add(this.CheckBox_EquipajeExtra);
            this.panel2.Controls.Add(this.checkBox_niños);
            this.panel2.Controls.Add(this.textBox_numeroNiños);
            this.panel2.Location = new System.Drawing.Point(436, 365);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 77);
            this.panel2.TabIndex = 25;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(768, 208);
            this.listView1.TabIndex = 26;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Aerolinea";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Numero";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fecha";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Origen";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Destino";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nacional";
            this.columnHeader6.Width = 90;
            // 
            // button_filtro
            // 
            this.button_filtro.BackColor = System.Drawing.Color.Tomato;
            this.button_filtro.Location = new System.Drawing.Point(361, 477);
            this.button_filtro.Name = "button_filtro";
            this.button_filtro.Size = new System.Drawing.Size(91, 33);
            this.button_filtro.TabIndex = 27;
            this.button_filtro.Text = "FILTRAR";
            this.button_filtro.UseVisualStyleBackColor = false;
            this.button_filtro.Click += new System.EventHandler(this.button_filtro_Click);
            // 
            // textBox_codigo
            // 
            this.textBox_codigo.Location = new System.Drawing.Point(27, 33);
            this.textBox_codigo.Name = "textBox_codigo";
            this.textBox_codigo.Size = new System.Drawing.Size(100, 22);
            this.textBox_codigo.TabIndex = 28;
            // 
            // label_Codigo
            // 
            this.label_Codigo.AutoSize = true;
            this.label_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Codigo.Location = new System.Drawing.Point(8, 7);
            this.label_Codigo.Name = "label_Codigo";
            this.label_Codigo.Size = new System.Drawing.Size(134, 24);
            this.label_Codigo.TabIndex = 29;
            this.label_Codigo.Text = "Codigo vuelo";
            // 
            // button_Informacion
            // 
            this.button_Informacion.BackColor = System.Drawing.Color.Silver;
            this.button_Informacion.Location = new System.Drawing.Point(12, 489);
            this.button_Informacion.Name = "button_Informacion";
            this.button_Informacion.Size = new System.Drawing.Size(99, 23);
            this.button_Informacion.TabIndex = 30;
            this.button_Informacion.Text = "Informacion";
            this.button_Informacion.UseVisualStyleBackColor = false;
            this.button_Informacion.Click += new System.EventHandler(this.button_Informacion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.label_Codigo);
            this.panel1.Controls.Add(this.textBox_codigo);
            this.panel1.Location = new System.Drawing.Point(641, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 77);
            this.panel1.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(796, 568);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_Informacion);
            this.Controls.Add(this.button_filtro);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_datos);
            this.Controls.Add(this.panel_fecha);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.bt_reserva);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Viajes Gomez Garcia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_fecha.ResumeLayout(false);
            this.panel_fecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel_datos.ResumeLayout(false);
            this.panel_datos.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_reserva;
        private System.Windows.Forms.Label label_Aerolinea;
        private System.Windows.Forms.ComboBox list_aerolinea;
        private System.Windows.Forms.ComboBox list_aeropuerto_origen;
        private System.Windows.Forms.Label label_Origen;
        private System.Windows.Forms.ComboBox list_aeropuerto_destino;
        private System.Windows.Forms.Label label_Destino;
        private System.Windows.Forms.CheckBox CheckBox_EquipajeExtra;
        private System.Windows.Forms.CheckBox checkBox_niños;
        private System.Windows.Forms.TextBox textBox_numeroNiños;
        private System.Windows.Forms.Button button_salir;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fechaIda;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fechaVuelta;
        private System.Windows.Forms.Panel panel_fecha;
        private System.Windows.Forms.Label label_FechaVuelta;
        private System.Windows.Forms.Label label_FechaIda;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_datos;
        private System.Windows.Forms.Label label_Billetes;
        private System.Windows.Forms.TextBox textBox_billetes;
        private System.Windows.Forms.Button button_filtro;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox textBox_codigo;
        private System.Windows.Forms.Label label_Codigo;
        private System.Windows.Forms.Button button_Informacion;
        private System.Windows.Forms.Panel panel1;
    }
}

