using Supermarket.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Business
{
    internal class CategoriesDAO
    {
        private readonly Dictionary<int, Categories> CategoriesList;
        private static int categoriesSecuencial;

        public CategoriesDAO()
        {
            CategoriesList = new Dictionary<int, Categories>();
            categoriesSecuencial = 0;
        }
        public bool AddCategories(Categories categories)
        {
            try
            {
                categories.Id = ++categoriesSecuencial;
                CategoriesList.Add((int)categories.Id, categories);
            }
            catch(ArgumentException) 
            {
                return false;
            }
            return true;
        }
        public bool RemoveCategories(int id) 
        {
            bool idExists = CategoriesList.ContainsKey(id);
            if (idExists) 
            {
                CategoriesList.Remove(id);
                return true;
            }
            return false;
        }
        public Categories GetCategories(int id) 
        {
            bool idExists = CategoriesList.ContainsKey(id);
            if (idExists) 
            {
                Categories categories = CategoriesList[id];
                return categories;
            }
            return null;
        }
        public bool UpdateCategories(int id, Categories categories)
        {
            bool idExists = CategoriesList.ContainsKey(id);
            if (idExists)
            {
                try
                {
                    CategoriesList[id] = categories;
                    return true;
                }
                catch (KeyNotFoundException)
                {
                    return false;
                }
            }
            return false;
        }
        public Dictionary<int, Categories> GetCategoriesList()
        {
            return CategoriesList;
        }
    }
}
