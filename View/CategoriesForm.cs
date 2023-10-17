using Supermarket.Business;
using Supermarket.Model;
using Supermarket.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket.View
{
    public partial class CategoriesForm : Form
    {
        private readonly CategoriesDAO categoriesDAO;
        private bool EditMode;
        private bool IsNew;
        internal CategoriesForm(ref CategoriesDAO categoriesDAO)
        {
            InitializeComponent();
            this.categoriesDAO = categoriesDAO;
            LoadCategoriesList();
            EditMode = false;
            IsNew = false;
        }
        private void LoadCategoriesList()
        {
            DgCategories.Rows.Clear();
            foreach (KeyValuePair<int, Categories> categoriesKV in this.categoriesDAO.GetCategoriesList())
            {
                DgCategories.Rows.Add(categoriesKV.Value.Id,
                                      categoriesKV.Value.Name,
                                      categoriesKV.Value.Description);
            }
        }

        public CategoriesForm()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgCategories_Click(object sender, EventArgs e)
        {
            txtId.Text = DgCategories.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = DgCategories.CurrentRow.Cells[1].Value.ToString();
            txtDesc.Text = DgCategories.CurrentRow.Cells[2].Value.ToString();
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
                if (SaveCategories() == false)
                {
                    return;
                }
                EditMode = false;
                IsNew = false;
            }
            txtId.Text = "";
            txtName.Text = "";
            txtDesc.Text = "";
            ActivateControls(EditMode);
        }
        private void ActivateControls(bool state)
        {
            if (EditMode == true)
            {
                BtnNew.Text = "Save";
                BtnNew.Image = Resources.save;
                BtnEdit.Text = "Cancel";
                BtnEdit.Image = Resources.cancel;
            }
            else
            {
                BtnNew.Text = "New";
                BtnNew.Image = Resources._new;
                BtnEdit.Text = "Edit";
                BtnEdit.Image = Resources.edit;
            }
            txtName.Enabled = state;
            txtDesc.Enabled = state;
            DgCategories.Enabled = !state;
            BtnDelete.Enabled = !state;
            BtnClose.Enabled = !state;
            txtName.Focus();
        }
        private bool SaveCategories()
        {
            if (!IsNameFilled())
            {
                return false;
            }
            if (IsNew == true)
            {
                Categories categories = new(null, txtName.Text, txtDesc.Text);
                if (categoriesDAO.AddCategories(categories) == false)
                {
                    MessageBox.Show("Error. Error to save", "Alert",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                MessageBox.Show("Info. Category save susessfuly", "Alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategoriesList();
            }
            else
            {
                int id = Int32.Parse(txtId.Text);
                Categories categories = categoriesDAO.GetCategories(id);
                if (categories != null)
                {
                    if (!IsNameFilled())
                    {
                        return false;
                    }
                    categories.Name = txtName.Text;
                    categories.Description = txtDesc.Text;
                    categoriesDAO.UpdateCategories(id, categories);
                    LoadCategoriesList();
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
                MessageBox.Show("Error. Category name is required", "Alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
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
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                EditMode = true;
                IsNew = false;
            }
            ActivateControls(EditMode);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Info. Select one register of the list", "Alert",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                string message = "Confirm. Are you sure to delete the registry?";
                string title = "Alert";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon questions = MessageBoxIcon.Question;
                DialogResult result = MessageBox.Show(message, title, buttons, questions);
                if (result == DialogResult.Yes)
                {
                    int id = Int32.Parse(txtId.Text);
                    if (categoriesDAO.RemoveCategories(id) == false)
                    {
                        MessageBox.Show("Error. Error to delete", "Alert",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    MessageBox.Show("Info. Record is deleted", "Alert",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
                else
                {
                    return;
                }
                LoadCategoriesList();
            }
        }
    }
}
