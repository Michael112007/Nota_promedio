namespace iniciar01
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
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Salirr = new System.Windows.Forms.Button();
            this.btn_Limpiarr = new System.Windows.Forms.Button();
            this.txt_Nota1 = new System.Windows.Forms.TextBox();
            this.txt_Nota2 = new System.Windows.Forms.TextBox();
            this.txt_Nota3 = new System.Windows.Forms.TextBox();
            this.txt_Nota4 = new System.Windows.Forms.TextBox();
            this.txt_promedios = new System.Windows.Forms.TextBox();
            this.txt_situaciones = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(685, 101);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(150, 64);
            this.btn_Calcular.TabIndex = 0;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_Salirr
            // 
            this.btn_Salirr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salirr.Location = new System.Drawing.Point(685, 171);
            this.btn_Salirr.Name = "btn_Salirr";
            this.btn_Salirr.Size = new System.Drawing.Size(150, 54);
            this.btn_Salirr.TabIndex = 1;
            this.btn_Salirr.Text = "Salir";
            this.btn_Salirr.UseVisualStyleBackColor = true;
            this.btn_Salirr.Click += new System.EventHandler(this.btn_Salirr_Click);
            // 
            // btn_Limpiarr
            // 
            this.btn_Limpiarr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiarr.Location = new System.Drawing.Point(685, 242);
            this.btn_Limpiarr.Name = "btn_Limpiarr";
            this.btn_Limpiarr.Size = new System.Drawing.Size(150, 54);
            this.btn_Limpiarr.TabIndex = 2;
            this.btn_Limpiarr.Text = "Limpiar";
            this.btn_Limpiarr.UseVisualStyleBackColor = true;
            this.btn_Limpiarr.Click += new System.EventHandler(this.btn_Limpiarr_Click);
            // 
            // txt_Nota1
            // 
            this.txt_Nota1.Location = new System.Drawing.Point(345, 101);
            this.txt_Nota1.Name = "txt_Nota1";
            this.txt_Nota1.Size = new System.Drawing.Size(100, 22);
            this.txt_Nota1.TabIndex = 3;
            // 
            // txt_Nota2
            // 
            this.txt_Nota2.Location = new System.Drawing.Point(345, 174);
            this.txt_Nota2.Name = "txt_Nota2";
            this.txt_Nota2.Size = new System.Drawing.Size(100, 22);
            this.txt_Nota2.TabIndex = 4;
            // 
            // txt_Nota3
            // 
            this.txt_Nota3.Location = new System.Drawing.Point(345, 243);
            this.txt_Nota3.Name = "txt_Nota3";
            this.txt_Nota3.Size = new System.Drawing.Size(100, 22);
            this.txt_Nota3.TabIndex = 5;
            this.txt_Nota3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_Nota4
            // 
            this.txt_Nota4.Location = new System.Drawing.Point(345, 310);
            this.txt_Nota4.Name = "txt_Nota4";
            this.txt_Nota4.Size = new System.Drawing.Size(100, 22);
            this.txt_Nota4.TabIndex = 6;
            // 
            // txt_promedios
            // 
            this.txt_promedios.Location = new System.Drawing.Point(345, 377);
            this.txt_promedios.Name = "txt_promedios";
            this.txt_promedios.Size = new System.Drawing.Size(142, 22);
            this.txt_promedios.TabIndex = 7;
            // 
            // txt_situaciones
            // 
            this.txt_situaciones.Location = new System.Drawing.Point(345, 470);
            this.txt_situaciones.Name = "txt_situaciones";
            this.txt_situaciones.Size = new System.Drawing.Size(167, 22);
            this.txt_situaciones.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nota1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(87, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nota2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(87, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Nota3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(87, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Nota4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(87, 377);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 25);
            this.label11.TabIndex = 13;
            this.label11.Text = "Promedio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(87, 467);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 25);
            this.label12.TabIndex = 14;
            this.label12.Text = "Situacion";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(294, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(290, 33);
            this.label13.TabIndex = 15;
            this.label13.Text = "Calculo de notas ";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(918, 648);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_situaciones);
            this.Controls.Add(this.txt_promedios);
            this.Controls.Add(this.txt_Nota4);
            this.Controls.Add(this.txt_Nota3);
            this.Controls.Add(this.txt_Nota2);
            this.Controls.Add(this.txt_Nota1);
            this.Controls.Add(this.btn_Limpiarr);
            this.Controls.Add(this.btn_Salirr);
            this.Controls.Add(this.btn_Calcular);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Matematica;
        private System.Windows.Forms.TextBox txt_español;
        private System.Windows.Forms.TextBox txt_sociales;
        private System.Windows.Forms.TextBox txt_naturales;
        private System.Windows.Forms.TextBox txt_promedio;
        private System.Windows.Forms.TextBox txt_situacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Calcualar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Salirr;
        private System.Windows.Forms.Button btn_Limpiarr;
        private System.Windows.Forms.TextBox txt_Nota1;
        private System.Windows.Forms.TextBox txt_Nota2;
        private System.Windows.Forms.TextBox txt_Nota3;
        private System.Windows.Forms.TextBox txt_Nota4;
        private System.Windows.Forms.TextBox txt_promedios;
        private System.Windows.Forms.TextBox txt_situaciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

