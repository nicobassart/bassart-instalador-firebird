using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

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
            configuraciones.Visible = false;
            try
            {
                progressBar.Value = 50;
                // Acá vamos a generar el icono de acceso directo al ejecutable de la aplicacion

                this.generarIcono(Padre.PATH_LOCAL_PROG_INSTALADOR, Padre.EJECUTABLE, Padre.FILE_ICON);
                progressBar.Value = 100;

            }
            catch (Exception ex) {
                // Deberia generar un log y emitir una alerta
                MessageBox.Show(ex.Message + " FUENTE:" + ex.Source +"" +ex.Data);
            }
            configuraciones.Visible = true;
        }
        public void ejecutarPrograma(String prog, String commando)
        {
            /*
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

            System.Threading.Thread.Sleep(120);*/
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
            string app = path + @"\" + ejecutable;

            IShellLink link = (IShellLink)new ShellLink();

            // setup shortcut information
            link.SetDescription("Gestion Inmobiliaria");
            link.SetPath(app);
            link.SetWorkingDirectory(path);
            string icon = path + @"\" + icono;
            link.SetIconLocation(icon, 0);

            // save it
            IPersistFile file = (IPersistFile)link;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            file.Save(Path.Combine(desktopPath, "Gestion Inmobiliaria.lnk"), false);




        }

        public void generarIconoXP(String path, String ejecutable, String icono)
        {
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(escritorio + "\\" + "Gestion Inmobiliaria" + ".url"))
            {

                string app = path + @"\" + ejecutable;
                writer.WriteLine("[InternetShortcut]");
                writer.WriteLine("URL=file:///" + app);
                writer.WriteLine("URL=" + app);
                writer.WriteLine("IconIndex=0");
                writer.WriteLine("WORKINGDIR=" + app);

                string icon = path + @"\" + icono;
                writer.WriteLine("IconFile=" + icon);
                writer.Flush();
            }
        }
    }
    [ComImport]
    [Guid("00021401-0000-0000-C000-000000000046")]
    internal class ShellLink
    {
    }

    [ComImport]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("000214F9-0000-0000-C000-000000000046")]
    internal interface IShellLink
    {
        void GetPath([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszFile, int cchMaxPath, out IntPtr pfd, int fFlags);
        void GetIDList(out IntPtr ppidl);
        void SetIDList(IntPtr pidl);
        void GetDescription([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszName, int cchMaxName);
        void SetDescription([MarshalAs(UnmanagedType.LPWStr)] string pszName);
        void GetWorkingDirectory([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszDir, int cchMaxPath);
        void SetWorkingDirectory([MarshalAs(UnmanagedType.LPWStr)] string pszDir);
        void GetArguments([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszArgs, int cchMaxPath);
        void SetArguments([MarshalAs(UnmanagedType.LPWStr)] string pszArgs);
        void GetHotkey(out short pwHotkey);
        void SetHotkey(short wHotkey);
        void GetShowCmd(out int piShowCmd);
        void SetShowCmd(int iShowCmd);
        void GetIconLocation([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszIconPath, int cchIconPath, out int piIcon);
        void SetIconLocation([MarshalAs(UnmanagedType.LPWStr)] string pszIconPath, int iIcon);
        void SetRelativePath([MarshalAs(UnmanagedType.LPWStr)] string pszPathRel, int dwReserved);
        void Resolve(IntPtr hwnd, int fFlags);
        void SetPath([MarshalAs(UnmanagedType.LPWStr)] string pszFile);
    }
}
