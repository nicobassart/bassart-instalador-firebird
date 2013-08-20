namespace Instalador
{
    partial class Hijo3
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.textoInstalando = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.configuraciones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Se estan generando las configuraciones necesarias:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 44);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(481, 23);
            this.progressBar.TabIndex = 1;
            // 
            // textoInstalando
            // 
            this.textoInstalando.AutoSize = true;
            this.textoInstalando.Location = new System.Drawing.Point(260, 92);
            this.textoInstalando.Name = "textoInstalando";
            this.textoInstalando.Size = new System.Drawing.Size(0, 13);
            this.textoInstalando.TabIndex = 2;
            // 
            // configuraciones
            // 
            this.configuraciones.AutoSize = true;
            this.configuraciones.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.configuraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuraciones.Location = new System.Drawing.Point(122, 108);
            this.configuraciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.configuraciones.Name = "configuraciones";
            this.configuraciones.Size = new System.Drawing.Size(296, 13);
            this.configuraciones.TabIndex = 20;
            this.configuraciones.Text = "CONFIGURACION REALIZADA CORRECTAMENTE";
            this.configuraciones.Visible = false;
            // 
            // Hijo3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 182);
            this.Controls.Add(this.configuraciones);
            this.Controls.Add(this.textoInstalando);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.Name = "Hijo3";
            this.Text = "Hijo3";
            this.Load += new System.EventHandler(this.Hijo3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label textoInstalando;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label configuraciones;
    }
}