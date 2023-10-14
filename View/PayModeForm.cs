using Supermarket.Business;
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
using System.Xml.Linq;

namespace Supermarket.View
{
    public partial class PayModeForm : Form
    {
        private readonly PayModeDAO payModeDAO;
        private bool EditMode;
        private bool IsNew;
        internal PayModeForm(ref PayModeDAO payModeDAO)
        {
            InitializeComponent();
            this.payModeDAO = payModeDAO;
            LoadPayModeList();
            EditMode = false;
            IsNew = false;
        }
        private void LoadPayModeList()
        {
            DgPayMode.Rows.Clear();
            foreach (KeyValuePair<int, PayMode> payModeKV in this.payModeDAO.GetPayModeList())
            {
                DgPayMode.Rows.Add(payModeKV.Value.Id, payModeKV.Value.Name, payModeKV.Value.Observation);

            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgPayMode_Click(object sender, EventArgs e)
        {
            txtId.Text = DgPayMode.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = DgPayMode.CurrentRow.Cells[1].Value.ToString();
            txtObserv.Text = DgPayMode.CurrentRow.Cells[2].Value.ToString();
        }

        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            txtId.Text = DgPayMode.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = DgPayMode.CurrentRow.Cells[1].Value.ToString();

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
                if (SavePayMode() == false)
                {
                    return;
                };
                IsNew = false;
                EditMode = false;
            }
            txtId.Text = "";
            txtName.Text = "";
            txtObserv.Text = "";
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
            txtObserv.Enabled = state;
            DgPayMode.Enabled = !state;
            BtnDelete.Enabled = !state;
            BtnClose.Enabled = !state;
            txtName.Focus();
        }
        private bool SavePayMode()
        {
            if (!IsNameFilled())
            {
                return false;
            }
            if (IsNew == true)
            {
                PayMode payMode = new(null, txtName.Text, txtObserv.Text);
                if (payModeDAO.AddPayMode(payMode) == false)
                {
                    MessageBox.Show("Error to save", "Alert",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }
                MessageBox.Show("Pay mode save susessfuly", "Alert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                LoadPayModeList();
            }
            else
            {
                int id = Int32.Parse(txtId.Text);
                PayMode payMode = payModeDAO.GetPayMode(id);
                if (payMode != null)
                {
                    if (!IsNameFilled())
                    {
                        return false;
                    }
                    payMode.Name = txtName.Text;
                    payMode.Observation = txtObserv.Text;
                    payModeDAO.UpdatePayMode(id, payMode);
                    LoadPayModeList();
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
                MessageBox.Show("The Pay mode name is required", "Alert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
                    MessageBox.Show("Select one register of the list", "Alert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                    return;
                };
                EditMode = true;
                IsNew = false;
            }
            ActivateControls(EditMode);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Select one register of the list", "Alert",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                string message = "Are you sure to delete the registry?";
                string title = "Alert";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon questions = MessageBoxIcon.Question;
                DialogResult result = MessageBox.Show(message, title, buttons, questions);
                if (result == DialogResult.Yes)
                {
                    int id = Int32.Parse(txtId.Text);
                    if (payModeDAO.RemovePayMode(id) == false)
                    {
                        MessageBox.Show("Error to delete", "Alert",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    MessageBox.Show("Record is deleted", "Alert",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
                else
                {
                    return;
                }
                LoadPayModeList();
            }
        }
    }
}
