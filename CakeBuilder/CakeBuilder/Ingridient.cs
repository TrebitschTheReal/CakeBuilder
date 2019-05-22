using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeBuilder
{
    class Ingridient
    {
        private string name = "";
        private string unitType = "";
        private int unitPrice = 0;
        private int unitQuantity = 0;
        private int overallPrice = 0;

        public Ingridient(string name, string unitType, int unitPrice, int materialQuantity)
        {
            this.name = name;
            this.unitType = unitType;
            this.unitPrice = unitPrice;
            this.unitQuantity = materialQuantity;
            this.overallPrice = unitQuantity * unitPrice;
        }
        public string Name
        {
            get { return name; }
        }
        public int UnitQuantity
        {
            get { return unitQuantity; }
            set { unitQuantity = value; }
        }
        public string UnitType
        {
            get { return unitType; }
        }
        public int UnitPrice
        {
            get { return unitPrice; }
        }
        public int OverallPrice
        {
            get { return unitQuantity * unitPrice; }
        }

    }
}