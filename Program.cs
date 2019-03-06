using JWMultimedia;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CorrigeJWMultimedia
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Informe o diretório que contém os arquivos .jw");
                return;
            }

            if (!Directory.Exists(args[0]))
            {
                Console.WriteLine("Diretório não encontrado: " + args[0]);
                return;
            }

            string[] paths = Directory.GetFiles(args[0], "*.jw");

            foreach (var path in paths)
            {
                //descompacta
                Console.WriteLine("Descompactando arquivo " + path);
                object lista = new List<cDatosIdioma>();
                FileToObject(path, ref lista);

                //remover os pts diferentes
                Console.WriteLine("Removendo idiomas PT diferente do brasileiro");
                var obj = (lista as List<cDatosIdioma>).Where(p => p.IdIdioma == "pt" && p.id_LS == "LGP").FirstOrDefault();
                if (obj != null) (lista as List<cDatosIdioma>).Remove(obj);

                obj = (lista as List<cDatosIdioma>).Where(p => p.IdIdioma == "pt" && p.id_LS == "LSB").FirstOrDefault();
                if (obj != null) (lista as List<cDatosIdioma>).Remove(obj);

                Console.WriteLine("Gravando arquivo " + path);
                ObjectToFile(path, ref lista);                
            }

            Console.WriteLine("Processo concluído. Pressione uma tecla para sair.");
            Console.ReadKey();
        }

        static void ObjectToFile(string ruta, ref object obj)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());

            using (FileStream fileStream = new FileStream(ruta, FileMode.Create))
            {
                using (GZipStream gzipStream = new GZipStream(fileStream, CompressionMode.Compress))
                {
                    xmlSerializer.Serialize(gzipStream, RuntimeHelpers.GetObjectValue(obj));
                    gzipStream.Flush();
                    gzipStream.Close();
                }
                fileStream.Close();
            }
        }

        static void FileToObject(string ruta, ref object obj)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());

            using (FileStream fileStream = new FileStream(ruta, FileMode.Open))
            {
                fileStream.Seek(0L, SeekOrigin.Begin);
                using (GZipStream gzipStream = new GZipStream(fileStream, CompressionMode.Decompress))
                {
                    obj = RuntimeHelpers.GetObjectValue(xmlSerializer.Deserialize(gzipStream));
                    gzipStream.Close();
                }
                fileStream.Close();
            }
        }
    }
}
