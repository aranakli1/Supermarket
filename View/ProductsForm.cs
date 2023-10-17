using Supermarket.Business;
using Supermarket.Model;
using Supermarket.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket.View
{
    public partial class ProductsForm : Form
    {
        private readonly ProductsDAO productsDAO;
        private bool EditMode;
        private bool IsNew;
        internal ProductsForm(ref ProductsDAO productsDAO)
        {
            InitializeComponent();
            this.productsDAO = productsDAO;
            LoadProductsList();
            EditMode = false;
            IsNew = false;
        }
        private void LoadProductsList()
        {
            DgProducts.Rows.Clear();
            foreach (KeyValuePair<int, Products> productsKV in this.productsDAO.GetProductsList())
            {
                DgProducts.Rows.Add(productsKV.Value.Id, productsKV.Value.Name, productsKV.Value.Price,
                                    productsKV.Value.Stock, productsKV.Value.CategoryId);

            }
        }
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgProducts_Click(object sender, EventArgs e)
        {
            txtId.Text = DgProducts.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = DgProducts.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = DgProducts.CurrentRow.Cells[2].Value.ToString();
            txtStock.Text = DgProducts.CurrentRow.Cells[3].Value.ToString();
            txtCatId.Text = DgProducts.CurrentRow.Cells[4].Value.ToString();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            if (EditMode == false)
            {
                EditMode = true;
                IsNew = true;
            }
            else
            {
                if (SaveProducts() == false)
                {
                    return;
                };
                EditMode = false;
                IsNew = false;
            }
            txtId.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtStock.Text = "";
            txtCatId.Text = "";
            ActivateControls(EditMode);
        }
        private void ActivateControls(bool state)
        {
            if (EditMode == true)
            {
                BtnNew.Text = "Save";
                BtnNew.Image = Resources.save;
                BtnEdit.Text = "Cancel";
                BtnEdit.Image = Resources.edit;
            }
            else
            {
                BtnNew.Text = "New";
                BtnNew.Image = Resources._new;
                BtnEdit.Text = "Edit";
                BtnEdit.Image = Resources.edit;
            }
            txtName.Enabled = state;
            txtPrice.Enabled = state;
            txtStock.Enabled = state;
            txtCatId.Enabled = state;
            DgProducts.Enabled = !state;
            BtnDelete.Enabled = !state;
            BtnClose.Enabled = !state;
            txtName.Focus();
        }
        private bool SaveProducts()
        {
            if (!IsNameFilled())
            {
                return false;
            }
            if (IsNew == true)
            {
                Products products = new(null, txtName.Text, Int32.Parse(txtPrice.Text),
                                        Int32.Parse(txtStock.Text), Int32.Parse(txtCatId.Text));
                if (productsDAO.AddProducts(products) == false)
                {
                    MessageBox.Show("Error. Error al salvar", "Alert",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                MessageBox.Show("Info. Products save susessfuly", "Alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProductsList();
            }
            else
            {
                int id = Int32.Parse(txtId.Text);
                Products products = productsDAO.GetProducts(id);
                if (products != null)
                {
                    if (!IsNameFilled())
                    {
                        return false;
                    }
                    products.Name = txtName.Text;
                    products.Price = Int32.Parse(txtPrice.Text);
                    products.Stock = Int32.Parse(txtStock.Text);
                    products.CategoryId = Int32.Parse(txtCatId.Text);
                    productsDAO.UpdateProducts(id, products);
                    LoadProductsList();
                    return true;
                }
                return false;
            }
            return true;
        }
        private bool IsNameFilled()
        {
            if ((txtName.Text).Trim().Length == 0)
            {
                MessageBox.Show("The product name is required", "Alert",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }
            if ((txtPrice.Text).Trim().Length == 0)
            {
                MessageBox.Show("The product price is required", "Alert",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                txtPrice.Focus();
                return false;
            }
            if ((txtStock.Text).Trim().Length == 0)
            {
                MessageBox.Show("The product stock is required", "Alert",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                txtStock.Focus();
                return false;
            }
            if ((txtCatId.Text).Trim().Length == 0)
            {
                MessageBox.Show("The product category Id is required", "Alert",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                txtCatId.Focus();
                return false;
            }
            return true;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (EditMode == true)
            {
                EditMode = false;
            }
            else
            {
                if (txtName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Info. Select one register of the list", "Alert",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation);
                    return;
                };
                EditMode = true;
                IsNew = false;
            }
            ActivateControls(EditMode);
        }
    }
}
