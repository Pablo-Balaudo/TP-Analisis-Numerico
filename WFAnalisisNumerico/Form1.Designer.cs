namespace WFAnalisisNumerico
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
            this.Panel = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.tabTan = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_Solucion_1 = new System.Windows.Forms.Label();
            this.lbl_Tole_1 = new System.Windows.Forms.Label();
            this.lbl_Iter_1 = new System.Windows.Forms.Label();
            this.btn1_ObtenerClick = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_LD = new System.Windows.Forms.TextBox();
            this.txt_LI = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_Iter = new System.Windows.Forms.TextBox();
            this.txt_Tole = new System.Windows.Forms.TextBox();
            this.txt_Funcion = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Panel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabTan.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.tabPage1);
            this.Panel.Controls.Add(this.tabPage2);
            this.Panel.Location = new System.Drawing.Point(12, 12);
            this.Panel.Name = "Panel";
            this.Panel.SelectedIndex = 0;
            this.Panel.Size = new System.Drawing.Size(776, 426);
            this.Panel.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tabTan);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Unidad 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Métodos";
            // 
            // tabTan
            // 
            this.tabTan.Controls.Add(this.tabPage3);
            this.tabTan.Controls.Add(this.tabPage4);
            this.tabTan.Location = new System.Drawing.Point(24, 191);
            this.tabTan.Name = "tabTan";
            this.tabTan.SelectedIndex = 0;
            this.tabTan.Size = new System.Drawing.Size(714, 193);
            this.tabTan.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(706, 167);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Bisección";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_Solucion_1);
            this.groupBox2.Controls.Add(this.lbl_Tole_1);
            this.groupBox2.Controls.Add(this.lbl_Iter_1);
            this.groupBox2.Controls.Add(this.btn1_ObtenerClick);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(5, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(608, 102);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de salida";
            // 
            // lbl_Solucion_1
            // 
            this.lbl_Solucion_1.AutoSize = true;
            this.lbl_Solucion_1.Location = new System.Drawing.Point(122, 70);
            this.lbl_Solucion_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Solucion_1.Name = "lbl_Solucion_1";
            this.lbl_Solucion_1.Size = new System.Drawing.Size(13, 13);
            this.lbl_Solucion_1.TabIndex = 26;
            this.lbl_Solucion_1.Text = "--";
            // 
            // lbl_Tole_1
            // 
            this.lbl_Tole_1.AutoSize = true;
            this.lbl_Tole_1.Location = new System.Drawing.Point(122, 47);
            this.lbl_Tole_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Tole_1.Name = "lbl_Tole_1";
            this.lbl_Tole_1.Size = new System.Drawing.Size(13, 13);
            this.lbl_Tole_1.TabIndex = 25;
            this.lbl_Tole_1.Text = "--";
            // 
            // lbl_Iter_1
            // 
            this.lbl_Iter_1.AutoSize = true;
            this.lbl_Iter_1.Location = new System.Drawing.Point(122, 24);
            this.lbl_Iter_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Iter_1.Name = "lbl_Iter_1";
            this.lbl_Iter_1.Size = new System.Drawing.Size(13, 13);
            this.lbl_Iter_1.TabIndex = 24;
            this.lbl_Iter_1.Text = "--";
            // 
            // btn1_ObtenerClick
            // 
            this.btn1_ObtenerClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1_ObtenerClick.Location = new System.Drawing.Point(535, 70);
            this.btn1_ObtenerClick.Margin = new System.Windows.Forms.Padding(2);
            this.btn1_ObtenerClick.Name = "btn1_ObtenerClick";
            this.btn1_ObtenerClick.Size = new System.Drawing.Size(69, 26);
            this.btn1_ObtenerClick.TabIndex = 6;
            this.btn1_ObtenerClick.Text = "Obtener";
            this.btn1_ObtenerClick.UseVisualStyleBackColor = true;
            this.btn1_ObtenerClick.Click += new System.EventHandler(this.btn1_ObtenerClick_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Solucion =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Error Relativo =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Iteraciones =";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(706, 167);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Regla Falsa";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_LD);
            this.groupBox1.Controls.Add(this.txt_LI);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.txt_Iter);
            this.groupBox1.Controls.Add(this.txt_Tole);
            this.groupBox1.Controls.Add(this.txt_Funcion);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de entrada";
            // 
            // txt_LD
            // 
            this.txt_LD.Location = new System.Drawing.Point(301, 49);
            this.txt_LD.Margin = new System.Windows.Forms.Padding(2);
            this.txt_LD.Name = "txt_LD";
            this.txt_LD.Size = new System.Drawing.Size(104, 20);
            this.txt_LD.TabIndex = 21;
            // 
            // txt_LI
            // 
            this.txt_LI.Location = new System.Drawing.Point(301, 26);
            this.txt_LI.Margin = new System.Windows.Forms.Padding(2);
            this.txt_LI.Name = "txt_LI";
            this.txt_LI.Size = new System.Drawing.Size(104, 20);
            this.txt_LI.TabIndex = 20;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(258, 52);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(36, 13);
            this.label21.TabIndex = 19;
            this.label21.Text = "L.D. =";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(263, 29);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 13);
            this.label22.TabIndex = 18;
            this.label22.Text = "L.I. = ";
            // 
            // txt_Iter
            // 
            this.txt_Iter.Location = new System.Drawing.Point(86, 79);
            this.txt_Iter.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Iter.Name = "txt_Iter";
            this.txt_Iter.Size = new System.Drawing.Size(104, 20);
            this.txt_Iter.TabIndex = 17;
            // 
            // txt_Tole
            // 
            this.txt_Tole.Location = new System.Drawing.Point(86, 54);
            this.txt_Tole.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Tole.Name = "txt_Tole";
            this.txt_Tole.Size = new System.Drawing.Size(104, 20);
            this.txt_Tole.TabIndex = 16;
            // 
            // txt_Funcion
            // 
            this.txt_Funcion.Location = new System.Drawing.Point(86, 29);
            this.txt_Funcion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Funcion.Name = "txt_Funcion";
            this.txt_Funcion.Size = new System.Drawing.Size(104, 20);
            this.txt_Funcion.TabIndex = 15;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(14, 82);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 13);
            this.label23.TabIndex = 14;
            this.label23.Text = "Iteraciones =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tolerancia =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "f (x) =";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Panel.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabTan.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Panel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabTan;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_LD;
        private System.Windows.Forms.TextBox txt_LI;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txt_Iter;
        private System.Windows.Forms.TextBox txt_Tole;
        private System.Windows.Forms.TextBox txt_Funcion;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Solucion_1;
        private System.Windows.Forms.Label lbl_Tole_1;
        private System.Windows.Forms.Label lbl_Iter_1;
        private System.Windows.Forms.Button btn1_ObtenerClick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

