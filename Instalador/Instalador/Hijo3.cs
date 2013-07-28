using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Instalador
{
    public partial class Hijo3 : Form
    {
        public Hijo3()
        {
            InitializeComponent();
        }

        private void Hijo3_Load(object sender, EventArgs e)
        {
            try
            {
                String param1;
                String param2;
                String param3;
                String param4;
                String param5;
                String param6;
                String param7;
                String commando;

                param1 = " /i \"" + Padre.PATH_LOCAL_TEMP_INSTALADOR + "\\mysql-5.5.24-win32.msi\"";
                param2 = "/qn INSTALLDIR=\"" + Padre.PATH_LOCAL_INSTALADOR + "\\MySQL\" DATADIR=\"" + Padre.PATH_LOCAL_INSTALADOR + "\\MySQL\"";
                param3 = "/L* \"" + Padre.PATH_LOCAL_INSTALADOR + "\\mysql-log.txt\"";
                commando = param1 + " " + param2 + " " + param3;

                textoInstalando.Text = "Instalando Mysql";
                progressBar.Value = 33;

                this.ejecutarPrograma("msiexec", commando);

                param1 = "\"-l" + Padre.PATH_LOCAL_INSTALADOR + "\\mysql_install_log.txt\"";
                param2 = "\"-nMySQL Server\"";
                param3 = "\"-p" + Padre.PATH_LOCAL_INSTALADOR + "\\MySQL\"";
                param4 = "-v5.1.68";
                param5 = "\"-t" + Padre.PATH_LOCAL_INSTALADOR + "\\MySQL\\my-template.ini\"";
                param6 = "\"-c" + Padre.PATH_LOCAL_INSTALADOR + "\\MySQL\\mytest.ini\"";
                param7 = "ServerType=DEVELOPMENT DatabaseType=MIXED ConnectionUsage=DSS Port=3306 ServiceName=MySQL51 RootPassword=root";

                commando = " -i -q " + param1 + " " + param2 + " " + param3 + " " + param4 + " " + param5 + " " + param6 + " " + param7;

                textoInstalando.Text = "Configurando Mysql";
                progressBar.Value = 66;

                this.ejecutarPrograma(Padre.PATH_LOCAL_INSTALADOR + "\\MySQL\\bin\\mysqlinstanceconfig", commando);

                param1 = "-h localhost";
                param2 = "-u root";
                param3 = "-proot";
                param4 = "-e \"create database inmobiliaria\"";

                commando = param1 + " " + param2 + " " + param3 + " " + param4;
                textoInstalando.Text = "Creando la base de batos";

                progressBar.Value = 88;

                this.ejecutarPrograma(Padre.PATH_LOCAL_INSTALADOR + "\\MySQL\\bin\\mysql", commando);

                param1 = "-h localhost";
                param2 = "-u root";
                param3 = "-proot";
                param4 = "--port=3306";
                param5 = @"-D inmobiliaria < "+Padre.PATH_LOCAL_TEMP_INSTALADOR + @"\CreateAll.sql";

                commando = param1 + " " + param2 + " " + param3 + " " + param4 + " " + param5;
                textoInstalando.Text = "Ejecutando Script sql";

                progressBar.Value = 100;

                this.ejecutarProgramaCMD("\"" + Padre.PATH_LOCAL_INSTALADOR + @"\MySQL\bin\mysql"+ "\"", commando);

                // Acá vamos a generar el icono de acceso directo al ejecutable de la aplicacion

                this.generarIcono(Padre.PATH_LOCAL_PROG_INSTALADOR, Padre.EJECUTABLE, Padre.FILE_ICON);


            }
            catch (Exception ex) {
                // Deberia generar un log y emitir una alerta
                MessageBox.Show(ex.Message + " FUENTE:" + ex.Source +"" +ex.Data);
            }

        }
        public void ejecutarPrograma(String prog, String commando)
        {

            int timeOut = 10000;
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(@prog);
            psi.RedirectStandardOutput = true;
            psi.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            psi.UseShellExecute = false;
            psi.Arguments = commando;
            System.Diagnostics.Process proc = System.Diagnostics.Process.Start(psi);
            System.IO.StreamReader myOutput = proc.StandardOutput;
            System.IO.StreamWriter SR = new System.IO.StreamWriter(Padre.PATH_LOCAL_INSTALADOR + @"\SqlCreate.log");

            SR.Write(myOutput.ReadToEnd());
            SR.Close();

            //proc.WaitForInputIdle();
            proc.WaitForExit(timeOut);
            if (proc.HasExited==false)
                if (proc.Responding)
                    //El proceso estaba respondiendo; cerrar la ventana principal.
                    proc.CloseMainWindow();
                else
                    //El proceso no estaba respondiendo; forzar el cierre del proceso.
                    proc.Kill();

            System.Threading.Thread.Sleep(120);
        }

        public void ejecutarProgramaCMD(String prog, String commando)
        {
            int timeOut = 10000;
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("cmd.exe");
            psi.UseShellExecute = false;
            psi.Arguments = commando;
            psi.CreateNoWindow = true;
            psi.ErrorDialog = true;
            psi.RedirectStandardError = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardInput = true;

            System.Diagnostics.Process proc = System.Diagnostics.Process.Start(psi);
            Encoding encoding = proc.StandardOutput.CurrentEncoding;
            System.IO.StreamWriter SW = proc.StandardInput;
            SW.WriteLine(@prog + " " + @commando);
            SW.Close();

            System.IO.StreamWriter SR = new System.IO.StreamWriter(Padre.PATH_LOCAL_INSTALADOR+@"\SqlCreate.log", false, encoding);

            SR.Write(proc.StandardOutput.ReadToEnd());
            SR.Close();

            proc.WaitForExit(timeOut);
            if (proc.HasExited == false)
                if (proc.Responding)
                    //El proceso estaba respondiendo; cerrar la ventana principal.
                    proc.CloseMainWindow();
                else
                    //El proceso no estaba respondiendo; forzar el cierre del proceso.
                    proc.Kill();
        }

        public void generarIcono(String path,String ejecutable, String icono) {
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(escritorio + "\\" + "Gestion Inmobiliaria" + ".url"))
            {

                string app = path + @"\" + ejecutable;
                writer.WriteLine("[InternetShortcut]");
                writer.WriteLine("URL=file:///" + app);
                writer.WriteLine("IconIndex=0");
                string icon = path + @"\" +icono;
                writer.WriteLine("IconFile=" + icon);
                writer.Flush();
            }
        }
    }
}
