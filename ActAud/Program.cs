﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ActAud
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application. На этот раз все готово
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormClients());
        }
    }
}
