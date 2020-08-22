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
            this.tabUnidades = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
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
            this.tabUnidades.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUnidades
            // 
            this.tabUnidades.Controls.Add(this.tabPage1);
            this.tabUnidades.Controls.Add(this.tabPage2);
            this.tabUnidades.Location = new System.Drawing.Point(12, 12);
            this.tabUnidades.Name = "tabUnidades";
            this.tabUnidades.SelectedIndex = 0;
            this.tabUnidades.Size = new System.Drawing.Size(776, 426);
            this.tabUnidades.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(24, 191);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(714, 193);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(706, 167);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(706, 167);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
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
            this.Controls.Add(this.tabUnidades);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabUnidades.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUnidades;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl2;
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
    }
}

