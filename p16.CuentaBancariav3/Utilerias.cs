using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _14.CuentaBancaria {
    static class Utilerias {

        public static void Grabar(string archivo, Banco banco) {
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter binFormat = new BinaryFormatter();
            binFormat.Serialize(fs, banco);
            fs.Close();
        }
        
        public static void Cargar(string archivo, ref Banco banco) {
            FileStream fs = new FileStream(archivo, FileMode.Open, FileAccess.Read);
            BinaryFormatter binFormat = new BinaryFormatter();
            banco = (Banco)binFormat.Deserialize(fs);
            fs.Close();
        }

    }
}