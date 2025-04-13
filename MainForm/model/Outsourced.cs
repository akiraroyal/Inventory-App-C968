using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.model
{
    public class Outsourced : Part
    {
        public string CompanyName { get; set; }
        public Outsourced(int partID, string name, decimal price, int inStock, int min, int max, string companyName)
        {
            PartID = partID;
            Name = name;
            Price = price;
            Instock = inStock;
            Min = min;
            Max = max;
            CompanyName = companyName;
 

        }
    }
}
