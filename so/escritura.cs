using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace so
{
    public class escritura
    {

        public void escribir(String texto)
        {
            // Define Output File
            const string fic = @"C:\Users\jchocooj\Desktop\so.txt";
            System.IO.StreamWriter sw = new System.IO.StreamWriter(fic,true);
            sw.WriteLine(texto);
            sw.Close();
        }


        public static void main()
        {
            escritura x = new escritura();
            //x.escribir("Hi");
        }
    }
}
