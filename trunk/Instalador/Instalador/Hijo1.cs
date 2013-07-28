using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Instalador
{
    public partial class Hijo1 : Form
    {
        public Hijo1()
        {
            InitializeComponent();
            carpeta.Text = Hijo1.PerfilUsuario() + "\\GestionInmobiliaria";
            Padre.PATH_LOCAL_INSTALADOR = carpeta.Text;
            Padre.PATH_LOCAL_TEMP_INSTALADOR = Padre.PATH_LOCAL_INSTALADOR + "\\temp";
            Padre.PATH_LOCAL_PROG_INSTALADOR = Padre.PATH_LOCAL_INSTALADOR + "\\prog";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (folder.ShowDialog() == DialogResult.OK)
            {
                carpeta.Text = folder.SelectedPath;
                Padre.PATH_LOCAL_INSTALADOR = carpeta.Text;
                Padre.PATH_LOCAL_TEMP_INSTALADOR = Padre.PATH_LOCAL_INSTALADOR + "\\temp";
                Padre.PATH_LOCAL_PROG_INSTALADOR = Padre.PATH_LOCAL_INSTALADOR + "\\prog";
                Padre.PATH_LOCAL_BBDD_INSTALADOR = Padre.PATH_LOCAL_PROG_INSTALADOR + "\\database";
                Padre.PATH_LOCAL_DLLS_INSTALADOR = Padre.PATH_LOCAL_PROG_INSTALADOR + "\\dlls";
            }
        }
        private void Hijo1_Disposed(object sender, EventArgs e)
        {
            Padre.PATH_LOCAL_INSTALADOR = carpeta.Text;
            Padre.PATH_LOCAL_TEMP_INSTALADOR = Padre.PATH_LOCAL_INSTALADOR + "\\temp";
            Padre.PATH_LOCAL_PROG_INSTALADOR = Padre.PATH_LOCAL_INSTALADOR + "\\prog";
            Padre.PATH_LOCAL_BBDD_INSTALADOR = Padre.PATH_LOCAL_PROG_INSTALADOR + "\\database";
            Padre.PATH_LOCAL_DLLS_INSTALADOR = Padre.PATH_LOCAL_PROG_INSTALADOR + "\\dlls";

        }


        static string ProgramFilesx86()
        {
            if (8 == IntPtr.Size
                || (!String.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"))))
            {
                return Environment.GetEnvironmentVariable("ProgramFiles(x86)");
            }
            return Environment.GetEnvironmentVariable("ProgramFiles");
        }

        static string PerfilUsuario()
        {
            if (8 == IntPtr.Size
                || (!String.IsNullOrEmpty(Environment.GetEnvironmentVariable("USERPROFILE"))))
            {
                return Environment.GetEnvironmentVariable("USERPROFILE");
            }
            return Environment.GetEnvironmentVariable("USERPROFILE");
        }    
    }
}
