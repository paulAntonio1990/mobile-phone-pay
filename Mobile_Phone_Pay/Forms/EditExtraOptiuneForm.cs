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
    public partial class EditExtraOptiuneForm : Form
    {
        private ExtraOptiune extraOptiune;
        public EditExtraOptiuneForm(ExtraOptiune extraOptiune)
        {
            InitializeComponent();
            this.extraOptiune = extraOptiune;
        }

        private void EditExtraOptiuneForm_Load(object sender, EventArgs e)
        {
            tbDenumire.Text = extraOptiune.Name;
            tbMinute.Text = extraOptiune.NoMinutes.ToString();
            tbMesaje.Text = extraOptiune.NoMessages.ToString();
            tbNetMb.Text = extraOptiune.NoNetMb.ToString();
            tbPret.Text = extraOptiune.Price.ToString();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            extraOptiune.Name = tbDenumire.Text.Trim();
            extraOptiune.NoMinutes = int.Parse(tbMinute.Text);
            extraOptiune.NoMessages = int.Parse(tbMesaje.Text);
            extraOptiune.NoNetMb = int.Parse(tbNetMb.Text);
            extraOptiune.Price = double.Parse(tbPret.Text);
        }
    }
}
