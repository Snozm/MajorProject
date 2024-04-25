﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MajorProject
{
    internal class StaticData
    {
        private static string server = @"LAB108PC17\SQLEXPRESS";
        public static string conString = @"Data Source=" + server + @"; Initial Catalog=RailwaysProject; Integrated Security=True;";
        public static string hashPassword(string password)
        {
            SHA256 hashAlgorithm = SHA256.Create();
            var bytes = Encoding.Default.GetBytes(password);
            var hash = hashAlgorithm.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
        public static byte[] ImageToByteArray(Image picture)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                picture.Save(ms, picture.RawFormat);
                return ms.ToArray();
            }
        }
    }
}