using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.model
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();

        public int ProductID { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int InStock { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }

        public Product(int productId, string name, decimal price, int instock, int min, int max)



        {
            AssociatedParts = new BindingList<Part>();
            ProductID = productId;
            Name = name;
            Price = price;
            InStock = instock;
            Min = min;
            Max = max;
        }

        //Added associated part
        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }


        //Remove associated part

        public bool RemoveAssociatedPart(int partID)
        {

            for (int i = 0; i < AssociatedParts.Count; i++)
            {
                if (AssociatedParts[i].PartID == partID)
                {
                    AssociatedParts.RemoveAt(i);
                    return true;
                }
               

            }
            return false;
        }

        


        //lookup associated part
        public Part lookupAssociatedPart(int partID)
        {
             
            for( int i = 0; i < AssociatedParts.Count; i++)
            {
                if (AssociatedParts[i].PartID == partID)
                {
                    return AssociatedParts[i];
                }
            }
            return null;
        }

    }
    
}
