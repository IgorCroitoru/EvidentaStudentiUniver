﻿using LibrarieModele;
using NivelAccesDate;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdministrareStudenti asT = new AdministrareStudenti();
            asT.Test();
                
            Console.ReadLine();
        }
    }
}