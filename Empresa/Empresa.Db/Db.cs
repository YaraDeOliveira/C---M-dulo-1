﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Db
{
    //Helper para acesso a dados
    public static class Db
    {
        public static string Conexao
        {
            get
            {
                return @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=EmpresaDb;Integrated Security=True;Pooling=False";
            }
        }
    }
}
