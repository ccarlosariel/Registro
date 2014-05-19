namespace Registro
{
    partial class Maestros
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
            this.identificacionlbl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nombrelbl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.apellidolbl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.telefonolbl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.direccionlbl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.correolbl = new System.Windows.Forms.TextBox();
            this.agregarcmd = new System.Windows.Forms.Button();
            this.cerrarcmd = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.limpiarcmd = new System.Windows.Forms.Button();
            this.ListaMaestros = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.profesionlbl = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // identificacionlbl
            // 
            this.identificacionlbl.Location = new System.Drawing.Point(91, 35);
            this.identificacionlbl.Name = "identificacionlbl";
            this.identificacionlbl.Size = new System.Drawing.Size(100, 20);
            this.identificacionlbl.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Identificacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // nombrelbl
            // 
            this.nombrelbl.Location = new System.Drawing.Point(66, 94);
            this.nombrelbl.Name = "nombrelbl";
            this.nombrelbl.Size = new System.Drawing.Size(176, 20);
            this.nombrelbl.TabIndex = 3;
            this.nombrelbl.TextChanged += new System.EventHandler(this.nombrelbl_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellidos";
            // 
            // apellidolbl
            // 
            this.apellidolbl.Location = new System.Drawing.Point(66, 144);
            this.apellidolbl.Name = "apellidolbl";
            this.apellidolbl.Size = new System.Drawing.Size(176, 20);
            this.apellidolbl.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefono";
            // 
            // telefonolbl
            // 
            this.telefonolbl.Location = new System.Drawing.Point(66, 192);
            this.telefonolbl.Name = "telefonolbl";
            this.telefonolbl.Size = new System.Drawing.Size(100, 20);
            this.telefonolbl.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Direccion";
            // 
            // direccionlbl
            // 
            this.direccionlbl.Location = new System.Drawing.Point(66, 231);
            this.direccionlbl.Name = "direccionlbl";
            this.direccionlbl.Size = new System.Drawing.Size(412, 20);
            this.direccionlbl.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Profesion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Correo";
            // 
            // correolbl
            // 
            this.correolbl.Location = new System.Drawing.Point(300, 94);
            this.correolbl.Name = "correolbl";
            this.correolbl.Size = new System.Drawing.Size(178, 20);
            this.correolbl.TabIndex = 15;
            // 
            // agregarcmd
            // 
            this.agregarcmd.Location = new System.Drawing.Point(494, 25);
            this.agregarcmd.Name = "agregarcmd";
            this.agregarcmd.Size = new System.Drawing.Size(75, 23);
            this.agregarcmd.TabIndex = 17;
            this.agregarcmd.Text = "Agregar";
            this.agregarcmd.UseVisualStyleBackColor = true;
            this.agregarcmd.Click += new System.EventHandler(this.button2_Click);
            // 
            // cerrarcmd
            // 
            this.cerrarcmd.Location = new System.Drawing.Point(494, 121);
            this.cerrarcmd.Name = "cerrarcmd";
            this.cerrarcmd.Size = new System.Drawing.Size(75, 23);
            this.cerrarcmd.TabIndex = 18;
            this.cerrarcmd.Text = "Cerrar";
            this.cerrarcmd.UseVisualStyleBackColor = true;
            this.cerrarcmd.Click += new System.EventHandler(this.cerrarcmd_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(278, 192);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // limpiarcmd
            // 
            this.limpiarcmd.Location = new System.Drawing.Point(494, 89);
            this.limpiarcmd.Name = "limpiarcmd";
            this.limpiarcmd.Size = new System.Drawing.Size(75, 23);
            this.limpiarcmd.TabIndex = 20;
            this.limpiarcmd.Text = "Limpiar";
            this.limpiarcmd.UseVisualStyleBackColor = true;
            this.limpiarcmd.Click += new System.EventHandler(this.limpiarcmd_Click);
            // 
            // ListaMaestros
            // 
            this.ListaMaestros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.ListaMaestros.Location = new System.Drawing.Point(15, 269);
            this.ListaMaestros.Name = "ListaMaestros";
            this.ListaMaestros.Size = new System.Drawing.Size(554, 174);
            this.ListaMaestros.TabIndex = 24;
            this.ListaMaestros.UseCompatibleStateImageBehavior = false;
            this.ListaMaestros.View = System.Windows.Forms.View.Details;
            this.ListaMaestros.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cedula";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Apellido";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefono";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Direccion";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Correo";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Profesion";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Fecha Naciminento";
            // 
            // profesionlbl
            // 
            this.profesionlbl.FormattingEnabled = true;
            this.profesionlbl.Items.AddRange(new object[] {
            "Ing. de Sistemas",
            "Ing. Telematico",
            "Ing. Civil",
            "Ing. Industrial",
            "Ing. Electronica",
            "Ing. Electromecanica",
            "Ing. Mecatronica",
            "Ing. Quimica",
            "Ing. Nuclear",
            "Lic. Adm. de Empresas",
            "Lic. Derecho",
            "Lic. Contabilidad",
            "Lic. Mercadeo"});
            this.profesionlbl.Location = new System.Drawing.Point(309, 144);
            this.profesionlbl.Name = "profesionlbl";
            this.profesionlbl.Size = new System.Drawing.Size(169, 21);
            this.profesionlbl.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(494, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Maestros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 471);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.profesionlbl);
            this.Controls.Add(this.ListaMaestros);
            this.Controls.Add(this.limpiarcmd);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cerrarcmd);
            this.Controls.Add(this.agregarcmd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.correolbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.direccionlbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.telefonolbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.apellidolbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombrelbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.identificacionlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Maestros";
            this.Text = "Maestros";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Maestros_FormClosed);
            this.Load += new System.EventHandler(this.Maestros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox identificacionlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombrelbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox apellidolbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox telefonolbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox direccionlbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox correolbl;
        private System.Windows.Forms.Button agregarcmd;
        private System.Windows.Forms.Button cerrarcmd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button limpiarcmd;
        private System.Windows.Forms.ListView ListaMaestros;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ComboBox profesionlbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}