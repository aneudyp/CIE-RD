﻿namespace CIE_RD
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
            this.txtCIE = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCIE
            // 
            this.txtCIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCIE.Location = new System.Drawing.Point(15, 33);
            this.txtCIE.MaxLength = 13;
            this.txtCIE.Name = "txtCIE";
            this.txtCIE.Size = new System.Drawing.Size(303, 29);
            this.txtCIE.TabIndex = 0;
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.Brown;
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.ForeColor = System.Drawing.Color.White;
            this.btnValidar.Location = new System.Drawing.Point(324, 9);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(157, 80);
            this.btnValidar.TabIndex = 1;
            this.btnValidar.Text = "&Verificar";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cédula de Indentidad y Electoral:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 66);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(20, 29);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 101);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txtCIE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VALIDAR CEDULA DE IDENTIDAD ELECTORAL - REP. DOM.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCIE;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultado;
    }
}

