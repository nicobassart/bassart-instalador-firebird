using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Instalador
{
    public partial class Padre : Form
    {
        int hijo = 0;
        //Path donde van a estar tanto la carpeta prog como la carpeta temp.
        public static String PATH_LOCAL_INSTALADOR;
        //Path completo al temporal donde estan el mysql y el scrypt de creacion de bd.
        public static String PATH_LOCAL_TEMP_INSTALADOR;
        //Path completo de la ruta donde estan los .class y favicon.
        public static String PATH_LOCAL_PROG_INSTALADOR;
        //Path completo de la ruta donde esta la base de datos;
        public static String PATH_LOCAL_BBDD_INSTALADOR;
        //Path completo de la ruta donde estan las DLLS
        public static String PATH_LOCAL_DLLS_INSTALADOR;

        //Ejecutable de la aplicacion
        public static String EJECUTABLE ="Inmobiliaria.jnlp";

        //el punto ico debe estar dentro de la carpeta prog del site
        public static String FILE_ICON = "icono.ico";

        //Usuario y clave de acceso al FTP
        public static String FTP_PASSWORD = "Pp123456B";
        public static String FTP_USUARIO = "bassart.com.ar";

        //Url desde donde descarga toda la carpeta temportal 
        public static String PATH_WEB_INSTALADOR_TMP_32 = "ftp://ftp.bassart.com.ar/htdocs/fire/Instalador_32/tmp";
        //URL de desde donde descarga todo el codigo fuente
        public static String PATH_WEB_INSTALADOR_PROG_32 = "ftp://ftp.bassart.com.ar/htdocs/fire/Instalador_32/prog";
        //URL donde descarga la base de datos
        public static String PATH_WEB_INSTALADOR_BBDD_32 = "ftp://ftp.bassart.com.ar/htdocs/fire/Instalador_32/database";
        //URL de descarga de Dlls
        public static String PATH_WEB_INSTALADOR_DLLS_32 = "ftp://ftp.bassart.com.ar/htdocs/fire/Instalador_32/dlls";


        //Url desde donde descarga toda la carpeta temportal 
        public static String PATH_WEB_INSTALADOR_TMP_64 = "ftp://ftp.bassart.com.ar/htdocs/fire/Instalador_64/tmp";
        //URL de desde donde descarga todo el codigo fuente
        public static String PATH_WEB_INSTALADOR_PROG_64 = "ftp://ftp.bassart.com.ar/htdocs/fire/Instalador_64/prog";
        //URL donde descarga la base de datos
        public static String PATH_WEB_INSTALADOR_BBDD_64 = "ftp://ftp.bassart.com.ar/htdocs/fire/Instalador_64/database";
        //URL de descarga de Dlls
        public static String PATH_WEB_INSTALADOR_DLLS_64 = "ftp://ftp.bassart.com.ar/htdocs/fire/Instalador_64/dlls";

        public static int seleccion = 64;

        public Padre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            this.panelContenedor.Controls.Clear();
            hijo++;
            Form fh = null;
            switch (hijo)
            {

                case 1:
                        fh = new Hijo1();
                        break;
                case 2:
                        fh = new Hijo2();
                        break;
                case 3:
                        fh = new Hijo3();
                        break;
                case 4:
                        {
                            fh = new Hijo4();
                            btn_siguiente.Visible = false;
                            finalizar.Visible = true;
                            btn_salir.Visible = false;
                            break;
                        }

            }
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
            this.panelContenedor.Refresh();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void comenzar() { 
            
        }

        private void finalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
