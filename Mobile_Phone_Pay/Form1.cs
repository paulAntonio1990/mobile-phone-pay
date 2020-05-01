using Mobile_Phone_Pay.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Phone_Pay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnClienti_Click(object sender, EventArgs e)
        {
            ClientiForm clientiForm = new ClientiForm();
            clientiForm.ShowDialog();
        }

        private void BtnAbonamente_Click(object sender, EventArgs e)
        {
            AbonamenteForm abonamenteForm = new AbonamenteForm();
            abonamenteForm.ShowDialog();
        }

        private void BtnExtraOptiuni_Click(object sender, EventArgs e)
        {
            ExtraOptiuniForm extraOptiuniForm = new ExtraOptiuniForm();
            extraOptiuniForm.ShowDialog();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
