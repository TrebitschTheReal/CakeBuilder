using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CakeBuilder
{
    class Import
    {
        private static int numberOfMaterials;
        private List<string> materialName = new List<string>();
        private List<string> materialUnitType = new List<string>();
        private List<int> materialUnitPrice = new List<int>();
        private List<int> materialUnitQuantity = new List<int>();

        public Import()
        {
            numberOfMaterials = MaterialCounter();
            GenerateMaterialData();

        }
        public List<string> MaterialName
        {
            get { return materialName; }
        }
        public List<string> MaterialUnitType
        {
            get { return materialUnitType; }
        }
        public List<int> MaterialUnitPrice
        {
            get { return materialUnitPrice; }
        }
        public List<int> MaterialUnitQuantity
        {
            get { return materialUnitQuantity; }
        }


        public int NumberOfMaterials
        {
            get { return numberOfMaterials; }
        }

        public string StringUntilFirstSpace(string text)
        {
            string textPiece = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    textPiece += text[i];
                }
            }
            return textPiece;
        }
        public int MaterialCounter()
        {
            int numberOfLines = 0;

            StreamReader sr = new StreamReader(@"alapanyag_data\alapanyagok.csv", Encoding.Default);
            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                numberOfLines++;
            }

            numberOfLines -= 1;
            sr.Close();
            return numberOfLines;
        }
        private void GenerateMaterialData()
        {
            StreamReader sr = new StreamReader(@"alapanyag_data\alapanyagok.csv", Encoding.Default);
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] elements = line.Split(';');

                materialName.Add(elements[0]);
                materialUnitType.Add(elements[1]);
                materialUnitPrice.Add(int.Parse(elements[2]));
                materialUnitQuantity.Add(int.Parse(elements[3]));
            }
            sr.Close();
        }

    }
}