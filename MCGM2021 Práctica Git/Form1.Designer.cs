﻿
namespace MCGM2021_Práctica_Git
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
            this.aluNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.Label();
            this.listaAlumnos = new System.Windows.Forms.TextBox();
            this.aluNota = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.aluNota)).BeginInit();
            this.SuspendLayout();
            // 
            // aluNombre
            // 
            this.aluNombre.Location = new System.Drawing.Point(37, 68);
            this.aluNombre.Name = "aluNombre";
            this.aluNombre.Size = new System.Drawing.Size(480, 26);
            this.aluNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre alumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(756, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Guardar Alumno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lista
            // 
            this.lista.AutoSize = true;
            this.lista.Location = new System.Drawing.Point(43, 122);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(107, 20);
            this.lista.TabIndex = 5;
            this.lista.Text = "Lista alumnos";
            // 
            // listaAlumnos
            // 
            this.listaAlumnos.Location = new System.Drawing.Point(41, 151);
            this.listaAlumnos.Multiline = true;
            this.listaAlumnos.Name = "listaAlumnos";
            this.listaAlumnos.ReadOnly = true;
            this.listaAlumnos.Size = new System.Drawing.Size(908, 249);
            this.listaAlumnos.TabIndex = 6;
            // 
            // aluNota
            // 
            this.aluNota.Location = new System.Drawing.Point(543, 69);
            this.aluNota.Name = "aluNota";
            this.aluNota.Size = new System.Drawing.Size(81, 26);
            this.aluNota.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 450);
            this.Controls.Add(this.aluNota);
            this.Controls.Add(this.listaAlumnos);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aluNombre);
            this.Name = "Form1";
            this.Text = "Alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.aluNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aluNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lista;
        private System.Windows.Forms.TextBox listaAlumnos;
        private System.Windows.Forms.NumericUpDown aluNota;
    }
}

