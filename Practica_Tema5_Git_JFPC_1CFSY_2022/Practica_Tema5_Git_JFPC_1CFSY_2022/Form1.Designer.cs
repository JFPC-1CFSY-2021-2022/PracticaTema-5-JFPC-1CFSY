
namespace Practica_Tema5_Git_JFPC_1CFSY_2022
{
    partial class Form1
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
            this.lblNombreAlu = new System.Windows.Forms.Label();
            this.aluNombre = new System.Windows.Forms.TextBox();
            this.aluNota = new System.Windows.Forms.TextBox();
            this.lblNotaAlu = new System.Windows.Forms.Label();
            this.listaAlumnos = new System.Windows.Forms.TextBox();
            this.lblListaAlu = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreAlu
            // 
            this.lblNombreAlu.AutoSize = true;
            this.lblNombreAlu.Location = new System.Drawing.Point(46, 31);
            this.lblNombreAlu.Name = "lblNombreAlu";
            this.lblNombreAlu.Size = new System.Drawing.Size(98, 13);
            this.lblNombreAlu.TabIndex = 0;
            this.lblNombreAlu.Text = "Nombre del alumno";
            // 
            // aluNombre
            // 
            this.aluNombre.Location = new System.Drawing.Point(49, 60);
            this.aluNombre.Name = "aluNombre";
            this.aluNombre.Size = new System.Drawing.Size(332, 20);
            this.aluNombre.TabIndex = 1;
            // 
            // aluNota
            // 
            this.aluNota.Location = new System.Drawing.Point(416, 60);
            this.aluNota.Name = "aluNota";
            this.aluNota.Size = new System.Drawing.Size(173, 20);
            this.aluNota.TabIndex = 2;
            // 
            // lblNotaAlu
            // 
            this.lblNotaAlu.AutoSize = true;
            this.lblNotaAlu.Location = new System.Drawing.Point(413, 31);
            this.lblNotaAlu.Name = "lblNotaAlu";
            this.lblNotaAlu.Size = new System.Drawing.Size(84, 13);
            this.lblNotaAlu.TabIndex = 3;
            this.lblNotaAlu.Text = "Nota del alumno";
            // 
            // listaAlumnos
            // 
            this.listaAlumnos.Location = new System.Drawing.Point(49, 129);
            this.listaAlumnos.Multiline = true;
            this.listaAlumnos.Name = "listaAlumnos";
            this.listaAlumnos.ReadOnly = true;
            this.listaAlumnos.Size = new System.Drawing.Size(540, 234);
            this.listaAlumnos.TabIndex = 4;
            // 
            // lblListaAlu
            // 
            this.lblListaAlu.AutoSize = true;
            this.lblListaAlu.Location = new System.Drawing.Point(46, 100);
            this.lblListaAlu.Name = "lblListaAlu";
            this.lblListaAlu.Size = new System.Drawing.Size(86, 13);
            this.lblListaAlu.TabIndex = 5;
            this.lblListaAlu.Text = "Lista de alumnos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 20);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar alumno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblListaAlu);
            this.Controls.Add(this.listaAlumnos);
            this.Controls.Add(this.lblNotaAlu);
            this.Controls.Add(this.aluNota);
            this.Controls.Add(this.aluNombre);
            this.Controls.Add(this.lblNombreAlu);
            this.Name = "Form1";
            this.Text = "Alumnos JFPC_1CFSY_2021_2022";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreAlu;
        private System.Windows.Forms.TextBox aluNombre;
        private System.Windows.Forms.TextBox aluNota;
        private System.Windows.Forms.Label lblNotaAlu;
        private System.Windows.Forms.TextBox listaAlumnos;
        private System.Windows.Forms.Label lblListaAlu;
        private System.Windows.Forms.Button button1;
    }
}