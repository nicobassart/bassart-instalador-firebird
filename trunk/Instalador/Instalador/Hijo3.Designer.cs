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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comienza la descarga de los programas, configuración y inicalización";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 62);
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
            // Hijo3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 182);
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
    }
}