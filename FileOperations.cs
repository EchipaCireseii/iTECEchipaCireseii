using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace iTEC_Cireseii
{
    /// <summary>
    /// Operatii pe fisierul config
    /// </summary>
    static class FileOperations
    {
        /// <summary>
        /// Procedura de extragere a datelor din fisier
        /// </summary>
        /// <param name="_path"></param>
        /// <returns></returns>
        static public string ExtractConnectionFromFile(string _path)
        {
            string server = "", database = "", username = "", password = "";
            string[] file = File.ReadAllLines(_path);
            foreach (string line in file)
            {
                if (line.Contains("Server:"))
                    server = line.Replace("Server:", "").Trim();
                if (line.Contains("Database:"))
                    database = line.Replace("Database:", "").Trim();
                if (line.Contains("Username:"))
                    username = line.Replace("Username:", "").Trim();
                if (line.Contains("Password: "))
                    password = line.Replace("Password: ", "").Trim();
            }
            return "Server=" + server + ";Database=" + database + ";Username=" + username + ";Password=" + password;
        }
    }
}
