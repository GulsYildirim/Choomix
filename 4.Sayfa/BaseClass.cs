using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Sayfa
{
    public abstract class BaseClass
    {
       
        public int Fiyat;
        public  String x;
        public  String y;
        public  String z;
        public  String t;
        public  String k;

        public static string kategori;
        public static string isim;

        public BaseClass()
        {
            
            x = "TL";
            y = "Euro";
            z = "Ars";
            t = "Kron";
            k = "Yen";

        }

      
        public abstract int Hesap();




    }

}
