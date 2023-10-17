using Supermarket.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Business
{
    internal class ProductsDAO
    {
        private readonly Dictionary<int, Products> ProductsList;
        private static int productsSecuencial;

        public ProductsDAO()
        {
            ProductsList = new Dictionary<int, Products>();
            productsSecuencial = 0;
        }
        public bool AddProducts(Products products)
        {
            try
            {
                products.Id = ++productsSecuencial;
                ProductsList.Add((int)products.Id, products);
            }
            catch(ArgumentException) 
            {
                return false;
            }
            return true;
        }
        public bool RemoveProducts(int id) 
        {
            bool idExists = ProductsList.ContainsKey(id);
            if (idExists) 
            {
                ProductsList.Remove(id);
                return true;
            }
            return false;
        }
        public Products GetProducts(int id) 
        {
            bool idExists = ProductsList.ContainsKey(id);
            if (idExists) 
            {
                Products products = ProductsList[id];
                return products;
            }
            return null;
        }
        public bool UpdateProducts(int id, Products products)
        {
            bool idExists = ProductsList.ContainsKey(id);
            if (idExists)
            {
                try
                {
                    ProductsList[id] = products;
                    return true;
                }
                catch (KeyNotFoundException)
                {
                    return false;
                }
            }
            return false;
        }
        public Dictionary<int, Products> GetProductsList()
        {
            return ProductsList;
        }
    }
}
