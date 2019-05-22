using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CakeBuilder
{
    class DataBase
    {
        private List<Ingridient> materials = new List<Ingridient>();

        public DataBase()
        {
            Import import = new Import();
            GetTheMaterialData(import);

        }
        public List<Ingridient> Materials
        {
            get { return materials; }
        }
        private void GetTheMaterialData(Import import)
        {
            for (int i = 0; i < import.MaterialName.Count; i++)
            {
                materials.Add(new Ingridient(import.MaterialName[i], import.MaterialUnitType[i], import.MaterialUnitPrice[i], import.MaterialUnitQuantity[i]));
            }
        }
        public int GetTheMaterialIndexByName(string ingridientName)
        {
            for (int i = 0; i < materials.Count; i++)
            {
                if(materials[i].Name == ingridientName)
                {
                    return i;
                }
            }
            return 0;
        }
    }
}