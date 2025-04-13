﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.model
{
    public class InHouse : Part
    {
        public int MachineID { get; set; }
        public InHouse(int partID, string name, decimal price, int inStock, int min, int max, int machineID)

        { 
            PartID = partID;
            Name = name;
            Price = price;
            Instock = inStock;
            Min = min;
            Max = max;
            MachineID = machineID;

        
        }
    }
}
