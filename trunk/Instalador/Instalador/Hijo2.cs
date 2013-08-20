using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Security.Permissions;

namespace Instalador
{
    public partial class Hijo2 : Form
    {
        public Hijo2()
        {
            InitializeComponent();
        }
        private void Hijo2_Shown(object sender, EventArgs e)
        {
            
            if (Padre.seleccion.Equals(32))
            {
                this.crearDirectorio(Padre.PATH_LOCAL_INSTALADOR);

                //this.crearDirectorio(Padre.PATH_LOCAL_TEMP_INSTALADOR); linea comentada de la version con mysql
                this.crearDirectorio(Padre.PATH_LOCAL_PROG_INSTALADOR);
                this.crearDirectorio(Padre.PATH_LOCAL_BBDD_INSTALADOR);
                this.crearDirectorio(Padre.PATH_LOCAL_DLLS_INSTALADOR);

                this.descargarArchivos(Padre.PATH_WEB_INSTALADOR_PROG_32, Padre.PATH_LOCAL_PROG_INSTALADOR, Padre.FTP_USUARIO, Padre.FTP_PASSWORD);
                this.descargarArchivos(Padre.PATH_WEB_INSTALADOR_BBDD_32, Padre.PATH_LOCAL_BBDD_INSTALADOR, Padre.FTP_USUARIO, Padre.FTP_PASSWORD);
                this.descargarArchivos(Padre.PATH_WEB_INSTALADOR_DLLS_32, Padre.PATH_LOCAL_DLLS_INSTALADOR, Padre.FTP_USUARIO, Padre.FTP_PASSWORD);
                //this.descargarArchivos(Padre.PATH_WEB_INSTALADOR_TMP_32, Padre.PATH_LOCAL_TEMP_INSTALADOR, Padre.FTP_USUARIO, Padre.FTP_PASSWORD); -- linea comentada de la version mysql
            }
            else {
                this.crearDirectorio(Padre.PATH_LOCAL_INSTALADOR);

                //this.crearDirectorio(Padre.PATH_LOCAL_TEMP_INSTALADOR); linea comentada de la version con mysql
                this.crearDirectorio(Padre.PATH_LOCAL_PROG_INSTALADOR);
                this.crearDirectorio(Padre.PATH_LOCAL_BBDD_INSTALADOR);
                this.crearDirectorio(Padre.PATH_LOCAL_DLLS_INSTALADOR);

                this.descargarArchivos(Padre.PATH_WEB_INSTALADOR_PROG_64, Padre.PATH_LOCAL_PROG_INSTALADOR, Padre.FTP_USUARIO, Padre.FTP_PASSWORD);
                this.descargarArchivos(Padre.PATH_WEB_INSTALADOR_BBDD_64, Padre.PATH_LOCAL_BBDD_INSTALADOR, Padre.FTP_USUARIO, Padre.FTP_PASSWORD);
                this.descargarArchivos(Padre.PATH_WEB_INSTALADOR_DLLS_64, Padre.PATH_LOCAL_DLLS_INSTALADOR, Padre.FTP_USUARIO, Padre.FTP_PASSWORD);
                //this.descargarArchivos(Padre.PATH_WEB_INSTALADOR_TMP_32, Padre.PATH_LOCAL_TEMP_INSTALADOR, Padre.FTP_USUARIO, Padre.FTP_PASSWORD); -- linea comentada de la version mysql
            }
            descarga.Visible = true;
        }

        [FileIOPermission(SecurityAction.Demand, Write = @"C:\Program Files (x86)")]
        private void crearDirectorio(String carpeta)
        {
            // Se crean los directorios necesarios para la instalación.

            // Se tiene que verificar si existe o no el directorio, en caso de que exista solamente deberiamos generar el temporal
            // si no existe tenemos que generar el temporal y tambien el del instalador.

            if (!System.IO.Directory.Exists(carpeta)) {
                try
                {
                    System.IO.Directory.CreateDirectory(carpeta);
                }
                catch (UnauthorizedAccessException esa)
                {
                    MessageBox.Show("Usted no tiene permisos de acceso sobre la carpeta seleccionada");
                }
            }
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void descargarArchivos(String fuente, String destino, String usuario, String clave){

            List<String> list = new List<String>();

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(fuente);
            request.Method = WebRequestMethods.Ftp.ListDirectory;

            request.Credentials = new NetworkCredential(Padre.FTP_USUARIO, Padre.FTP_PASSWORD);

            StreamReader streamReader = new StreamReader(request.GetResponse().GetResponseStream());

            string fileName = streamReader.ReadLine();
            while (fileName != null)
            {
                Console.WriteLine(fileName);
                if (fileName != "." && fileName != "..")
                    list.Add(fileName);
                fileName = streamReader.ReadLine();
            }
            request = null;
            streamReader = null;
            int cantElemRead = 0;
            foreach (String file in list)
            {

                cantElemRead++;
                fileDownload.Text = file;

                progressBar.Value = ((cantElemRead) * 100) / list.Count;
                fileDownload.Refresh();
                progressBar.Refresh();

                FtpWebRequest request2 = (FtpWebRequest)WebRequest.Create(fuente + "//" + file);
                request2.Method = WebRequestMethods.Ftp.DownloadFile;
                request2.Credentials = new NetworkCredential(usuario, clave);
                FtpWebResponse response = (FtpWebResponse)request2.GetResponse();

                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);

                FileStream writeStream = new FileStream(destino + "/" + file, FileMode.Create);

                int Length = 2048;
                Byte[] buffer = new Byte[Length];
                int bytesRead = responseStream.Read(buffer, 0, Length);

                while (bytesRead > 0)
                {
                    writeStream.Write(buffer, 0, bytesRead);
                    bytesRead = responseStream.Read(buffer, 0, Length);
                }
                writeStream.Close();
                response.Close();

                Console.WriteLine("Download Complete, status {0}", response.StatusDescription);
                reader.Close();
                response.Close();

            }
        }
    }
}

