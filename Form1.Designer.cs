﻿
namespace SaludosBotones
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
            this.btnJavier = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJavier
            // 
            this.btnJavier.Location = new System.Drawing.Point(168, 129);
            this.btnJavier.Name = "btnJavier";
            this.btnJavier.Size = new System.Drawing.Size(197, 140);
            this.btnJavier.TabIndex = 1;
            this.btnJavier.Text = "Hola, soy Javier";
            this.btnJavier.UseVisualStyleBackColor = true;
            this.btnJavier.Click += new System.EventHandler(this.btnJavier_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 140);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hola, soy Javier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnJavier_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnJavier);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJavier;
        private System.Windows.Forms.Button button1;
    }
}

