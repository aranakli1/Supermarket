using Supermarket.Business;
using Supermarket.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class MainForm : Form
    {
        internal PayModeDAO payModeDAO;
        internal CategoriesDAO categoriesDAO;
        internal ProductsDAO productsDAO;
        public MainForm()
        {
            payModeDAO = new PayModeDAO();
            categoriesDAO = new CategoriesDAO();
            productsDAO = new ProductsDAO();
            InitializeComponent();
            payModeDAO.AddPayMode(new Model.PayMode(null, "Cash", "No Observation"));
            categoriesDAO.AddCategories(new Model.Categories(null, "SeaFood", "Various kinds"));
            productsDAO.AddProducts(new Model.Products(null, "Fish", 77, 32, 1));
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Supermarkert V 0.1", "About us");
        }

        private void PayModeMenuItem_Click(object sender, EventArgs e)
        {
            PayModeForm formPayMode = new(ref payModeDAO);
            formPayMode.MdiParent = this;
            formPayMode.Show();
        }

        private void CategoriesMenuItem_Click(object sender, EventArgs e)
        {
            CategoriesForm formCategories = new CategoriesForm(ref categoriesDAO);
            formCategories.MdiParent = this;
            formCategories.Show();
        }

        private void ProductsMenuItem_Click(object sender, EventArgs e)
        {
            ProductsForm formProducts = new ProductsForm(ref productsDAO);
            formProducts.MdiParent = this;
            formProducts.Show();
        }
    }
}
