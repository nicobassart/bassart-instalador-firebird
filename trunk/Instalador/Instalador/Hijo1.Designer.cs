namespace Instalador
{
    partial class Hijo1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hijo1));
            this.folder = new System.Windows.Forms.FolderBrowserDialog();
            this.carpeta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_selecciona = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // carpeta
            // 
            this.carpeta.Location = new System.Drawing.Point(12, 124);
            this.carpeta.Name = "carpeta";
            this.carpeta.Size = new System.Drawing.Size(388, 20);
            this.carpeta.TabIndex = 11;
            this.carpeta.TextChanged += new System.EventHandler(this.Hijo1_Disposed);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 64);
            this.label2.TabIndex = 0;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // btn_selecciona
            // 
            this.btn_selecciona.Location = new System.Drawing.Point(418, 124);
            this.btn_selecciona.Name = "btn_selecciona";
            this.btn_selecciona.Size = new System.Drawing.Size(75, 23);
            this.btn_selecciona.TabIndex = 12;
            this.btn_selecciona.Text = "Seleccionar carpeta";
            this.btn_selecciona.UseVisualStyleBackColor = true;
            this.btn_selecciona.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 77);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selección de ruta de instalación";
            // 
            // Hijo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(505, 182);
            this.Controls.Add(this.carpeta);
            this.Controls.Add(this.btn_selecciona);
            this.Controls.Add(this.groupBox1);
            this.Name = "Hijo1";
            this.Text = "Hijo1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folder;
        private System.Windows.Forms.TextBox carpeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_selecciona;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}