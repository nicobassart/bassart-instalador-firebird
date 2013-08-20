namespace Instalador
{
    partial class Hijo2
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.fileDownload = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descarga = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 42);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(481, 22);
            this.progressBar.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Progreso de descarga del aplicativo";
            // 
            // fileDownload
            // 
            this.fileDownload.AutoSize = true;
            this.fileDownload.Location = new System.Drawing.Point(317, 71);
            this.fileDownload.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fileDownload.Name = "fileDownload";
            this.fileDownload.Size = new System.Drawing.Size(0, 13);
            this.fileDownload.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(11, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(481, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tenga en cuenta que este procesos puede tardar varios minutos, dependiendo del ti" +
                "po de conexion.";
            // 
            // descarga
            // 
            this.descarga.AutoSize = true;
            this.descarga.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.descarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descarga.Location = new System.Drawing.Point(129, 108);
            this.descarga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descarga.Name = "descarga";
            this.descarga.Size = new System.Drawing.Size(261, 13);
            this.descarga.TabIndex = 19;
            this.descarga.Text = "DESCARGA REALIZADA CORRECTAMENTE";
            this.descarga.Visible = false;
            // 
            // Hijo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(505, 182);
            this.Controls.Add(this.descarga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileDownload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Hijo2";
            this.Text = "Hijo2";
            this.Shown += new System.EventHandler(this.Hijo2_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fileDownload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label descarga;
    }
}