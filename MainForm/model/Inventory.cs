using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.model
{
    public  class Inventory
    {

        public static BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public static BindingList<Part> AllParts { get; set; } = new BindingList<Part> ();

    

        //add products

        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        //remove products

        public static bool RemoveProduct(int productId) 
        {
           
            for( int i =0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == productId)
                {
                    Products.RemoveAt(i);
                    return true;
                }
                }
                return false;
        }
        //lookup product

        public static Product LookupProduct(int productId)
        {
            Product myProduct = null;
            foreach( var product in Products)
            {
                if (product.ProductID == productId)
                {
                    myProduct = product;
                    break;
                }
            }
            return myProduct;
        }
        //update product

        public static void UpdateProduct(int productId, Product updateProduct) 
        {

            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == productId)
                {
                    Products[i] = updateProduct;
                    break;
                }
            }
        }
        


        //add part

        public static void AddPart(Part part) 
        {
            AllParts.Add(part);
        
        }

        //delete part

        public static bool DeletePart(Part part)
        {
            return AllParts.Remove(part);
        }

        //lookup part

        public static Part LookupPart(int partId)
        {
            Part myPart = null;
            foreach (var part in AllParts)
            {
                if(part.PartID == partId)
                {
                    myPart = part;
                    break;
                }
            }
            return myPart;
        }
        //update part

        public static void UpdatePart(int partId, Part updatedPart)
        {
            for(int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID == partId)
                {
                    AllParts[i] = updatedPart;
                    break;
                }
            }
        }
        #region Dummy Data

        public static void MyDummyData()
        {
            Product dummyProduct1 = new Product(1, "Product 1", 14, 9, 10, 6);
            Product dummyProduct2 = new Product(2, "Product 2", 24, 8, 9, 10);
            Product dummyProduct3 = new Product(3, "Product 3", 8, 10, 7, 5);
            Product dummyProduct4 = new Product(4, "Product 4", 12,11, 11, 17);

            Products.Add(dummyProduct1);
            Products.Add(dummyProduct2);
            Products.Add(dummyProduct3);
            Products.Add(dummyProduct4);


            Part dummyPart1 = new InHouse(1, "Part1", 10, 22,5, 10, 2001);
            Part dummyPart2 = new InHouse(2, "Part2", 13, 11,3, 9, 2001);
            Part dummyPart3 = new InHouse(3, "Part3", 11, 23,4, 11, 2002);
            Part dummyPart4 = new InHouse(4, "Part4", 11, 24,4, 14, 2002);
            Part dummyPart5 = new InHouse(5, "Part5", 112, 21,7, 17, 2003);
            Part dummyPart6 = new Outsourced(6, "Part6", 10, 21, 7, 10, "Big Lots");
            Part dummyPart7 = new Outsourced(7, "Part7", 11, 22, 7, 10, "Walmart");
            Part dummyPart8 = new Outsourced(8, "Part8", 9, 21, 5, 10, "Akira's Store");

            AllParts.Add(dummyPart1);
            AllParts.Add(dummyPart2);
            AllParts.Add(dummyPart3);
            AllParts.Add(dummyPart4);
            AllParts.Add(dummyPart5);
            AllParts.Add(dummyPart6);
            AllParts.Add(dummyPart7);
            AllParts.Add(dummyPart8);
           
        
           

        }




        #endregion


    }
}
