using SIPRA_FESC.Application.ViewModels.Request.DocumentosModel;
using System;

namespace SIPRA_FESC.Utils
{
    public class UtilFunction
    {
        public bool EsTipoPDF(IFormFile archivo)
        {
            return archivo.ContentType.ToLower() == "application/pdf";
        }

        public string GenerarNombreUnico(string nombre)
        {
            return $"{DateTime.Now:yyyyMMddHHmmssfff}_{nombre}.pdf";
        }

        public byte[] GenerarPdfBlod(string rutaArchivo)
        {
            byte[] archivoBytes = System.IO.File.ReadAllBytes(rutaArchivo);

            return archivoBytes;
        }

        public string ConstruirRutaArchivo(string rutaDirectorio, string nombreArchivo)
        {
            return Path.Combine(rutaDirectorio, nombreArchivo);
        }

        public void ArchivoExistente(string rutaArchivo)
        {
            try
            {
                if (File.Exists(rutaArchivo))
                {
                    File.Delete(rutaArchivo);
                    Console.WriteLine("The file has been deleted successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

        }

        public void CrearDirectorioSiNoExiste(string rutaDirectorio)
        {
            if (!Directory.Exists(rutaDirectorio))
            {
                Directory.CreateDirectory(rutaDirectorio);
            }
        }

        public void GuardarArchivo(IFormFile archivo, string rutaArchivo)
        {
            using (var archivoStream = new FileStream(rutaArchivo, FileMode.Create))
            {
                archivo.CopyTo(archivoStream);
            }
        }


    }
}
