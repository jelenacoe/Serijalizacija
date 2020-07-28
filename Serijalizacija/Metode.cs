using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serijalizacija
{
    static class Metode
    {
        public static void Serijalizuj(string imeFajla, Ucenik ucenik)
        {
            using (FileStream izlazniStream = File.Create(imeFajla))
            {
                BinaryFormatter formater = new BinaryFormatter();
                formater.Serialize(izlazniStream, ucenik);
            }

        }
        public static Ucenik Deserijalizuj(string imeFajla)
        {
            using (FileStream ulazniStream = File.OpenRead(imeFajla))
            {
                BinaryFormatter formater = new BinaryFormatter();
                object obj = formater.Deserialize(ulazniStream);
                Ucenik ucenik = (Ucenik)obj;
                return ucenik;
            }
        }
    }
}
