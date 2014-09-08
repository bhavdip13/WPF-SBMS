﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Infrastructure
{
    public static class Globals
    {
        public static class Assembly
        {
            public static string EXE_VERSION = "0.1.0";
        }
        public static class App
        {
            public static readonly string APPLICATION_EXE = @"\SBMS.exe";
        }
        public static class EmbededDB
        {
            public static readonly string DB_PATH = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\SBMS\sbms_db";
        }
        public static class RegistryConstants
        {
            public static readonly string KEY_PATH = @"MOTO-ID\NID-PRINT";
            public static readonly string LOCALE_KEY_NAME = "LOCALE";
            public static readonly string MONITOR_X = @"MONITOR_X";
            public static readonly string MONITOR_Y = @"MONITOR_Y";
        }
    }
}
