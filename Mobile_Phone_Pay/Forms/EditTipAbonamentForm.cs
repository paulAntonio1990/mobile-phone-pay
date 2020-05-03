using Mobile_Phone_Pay.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Phone_Pay.Forms
{
    public partial class EditTipAbonamentForm : Form
    {
        private TipAbonament tipAbonament;
        public EditTipAbonamentForm(TipAbonament tipAbonament)
        {
            InitializeComponent();
            this.tipAbonament = tipAbonament;
        }

        private void EditTipAbonamentForm_Load(object sender, EventArgs e)
        {
            tbDenumire.Text = tipAbonament.Name;
            tbNrMinute.Text = tipAbonament.NoMinutes.ToString();
            tbNrMesaje.Text = tipAbonament.NoMessages.ToString();
            tbNrMbNet.Text = tipAbonament.NoNetMb.ToString();
            tbValoare.Text = tipAbonament.Price.ToString();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            tipAbonament.Name = tbDenumire.Text;
            tipAbonament.NoMinutes = int.Parse(tbNrMinute.Text);
            tipAbonament.NoMessages = int.Parse(tbNrMesaje.Text);
            tipAbonament.NoNetMb = int.Parse(tbNrMbNet.Text);
            tipAbonament.Price = double.Parse(tbValoare.Text);
        }
    }
}
 