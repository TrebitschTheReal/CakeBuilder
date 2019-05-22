using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CakeBuilder
{
    class Export
    {
        private static string accesPath = "MentettTortak\\autosave_latestCake.csv";

        public static void AutoSave(DataBase data)
        {
            StreamWriter sw = new StreamWriter(accesPath, false, Encoding.Default);

            sw.WriteLine("Név;EgységTípus;Egységár;Mennyiség;Végösszeg");
            for (int i = 0; i < data.Materials.Count; i++)
            {
                sw.Write(data.Materials[i].Name + ";");
                sw.Write(data.Materials[i].UnitType + ";");
                sw.Write(data.Materials[i].UnitPrice + ";");
                sw.Write(data.Materials[i].UnitQuantity + ";");
                sw.Write(data.Materials[i].OverallPrice + ";");
                sw.WriteLine();
            }
            sw.Close();
        }

        public static void SaveTheCake(DataBase data, string cakeName)
        {
            string newAccesPath = @"MentettTortak\" + cakeName + ".csv";

            StreamWriter sw = new StreamWriter(newAccesPath, false, Encoding.Default);

            sw.WriteLine("Név;EgységTípus;Egységár;Mennyiség;Végösszeg");
            for (int i = 0; i < data.Materials.Count; i++)
            {
                sw.Write(data.Materials[i].Name + ";");
                sw.Write(data.Materials[i].UnitType + ";");
                sw.Write(data.Materials[i].UnitPrice + ";");
                sw.Write(data.Materials[i].UnitQuantity + ";");
                sw.Write(data.Materials[i].OverallPrice + ";");
                sw.WriteLine();
            }
            sw.Close();
        }
    }
}