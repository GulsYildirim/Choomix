﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Sayfa
{
    public class LoginAssign
    {
        public static string kullanıcı ;
        public static string mailadresi ;
        public static string telnumarasi ;

       
        public LoginAssign(string k, string l,string m)
        {
            kullanıcı = k;
            mailadresi = l;
            telnumarasi = m;
        }

    }
}
