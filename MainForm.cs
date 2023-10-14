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
        public MainForm()
        {
            payModeDAO = new PayModeDAO();
            InitializeComponent();
            payModeDAO.AddPayMode(new View.PayMode(null, "Cash", "No Observation"));
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
            PayModeForm formPayMode = new PayModeForm(ref payModeDAO);
            formPayMode.MdiParent = this;
            formPayMode.Show();
        }
    }
}
