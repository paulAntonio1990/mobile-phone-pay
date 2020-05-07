using Mobile_Phone_Pay.Entity;
using Mobile_Phone_Pay.Exceptions;
using Mobile_Phone_Pay.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Mobile_Phone_Pay.Forms
{
    public partial class AbonamenteForm : Form
    {
        private List<TipAbonament> abonamente;
        public AbonamenteForm()
        {
            InitializeComponent();
            abonamente = new List<TipAbonament>();
        }

        private void AbonamenteForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.CancelButton.PerformClick();
            }
        }

        private void TbMinute_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbMesaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbNet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbValoare_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && tbValoare.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }

            if (!char.IsNumber(ch) && !char.IsControl(ch) && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void TbDenumireAb_Validating(object sender, CancelEventArgs e)
        {
            string denumireAbonament = tbDenumireAb.Text.Trim();
            if (denumireAbonament.Length < 3)
            {
                epName.SetError(
                    tbDenumireAb,
                    "At least 3 characters!");

                e.Cancel = true;
            }
        }

        private void TbDenumireAb_Validated(object sender, EventArgs e)
        {
            epName.Clear();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            string denumireAbonament = tbDenumireAb.Text.Trim();
            if (denumireAbonament.Length < 3)
            {
                isValid = false;
                epName.SetError(
                    tbDenumireAb,
                    "At least 3 characters!");
            }

            string minute = tbMinute.Text;
            if (minute.Length < 1 || (minute.StartsWith("0") && minute.Length > 1))
            {
                isValid = false;
                epMinutes.SetError(
                    tbMinute,
                    "Invalid quantity!");
            }

            string mesage = tbMesaje.Text;
            if (mesage.Length < 1 || (mesage.StartsWith("0") && mesage.Length > 1))
            {
                isValid = false;
                epMessages.SetError(
                    tbMesaje,
                    "Invalid quantity!");
            }

            string net_MB = tbNet.Text;
            if (net_MB.Length < 1 || (net_MB.StartsWith("0") && net_MB.Length > 1))
            {
                isValid = false;
                epNetMb.SetError(
                    tbNet,
                    "Invalid quantity!");
            }

            string pretAbonament = tbValoare.Text;
            if (pretAbonament.Length < 1 ||
                (pretAbonament.StartsWith("0") && ((pretAbonament.Contains(".") && pretAbonament.IndexOf('.') != 1) || (!pretAbonament.Contains(".") && pretAbonament.Length > 1))) ||
                (pretAbonament.StartsWith("0") && pretAbonament.Contains(".") && pretAbonament.IndexOf('.') == 1 && pretAbonament.Length < 3))
            {
                isValid = false;
                epValoarePlati.SetError(
                    tbValoare,
                    "Invalid value!");
            }

            if (!isValid)
            {
                MessageBox.Show(
                    "Form contains errors!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    long id = TipAbonamentRepository.saveTipAbonament(denumireAbonament,
                        int.Parse(minute),
                        int.Parse(mesage),
                        int.Parse(net_MB),
                        double.Parse(pretAbonament));

                    var tipAbonament = new TipAbonament(
                        id,
                        denumireAbonament,
                        int.Parse(minute),
                        int.Parse(mesage),
                        int.Parse(net_MB),
                        double.Parse(pretAbonament));

                    abonamente.Add(tipAbonament);

                    AfisareAbonamente();
                    ClearForm();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void ClearForm()
        {
            tbDenumireAb.Clear();
            tbMinute.Clear();
            tbMesaje.Clear();
            tbNet.Clear();
            tbValoare.Clear();
        }

        private void TbMinute_Validating(object sender, CancelEventArgs e)
        {
            string noMinutes = tbMinute.Text;
            if (noMinutes.Length < 1 || (noMinutes.StartsWith("0") && noMinutes.Length > 1))
            {
                epMinutes.SetError(
                    tbMinute,
                    "Invalid quantity!");
                e.Cancel = true;
            }
        }

        private void TbMinute_Validated(object sender, EventArgs e)
        {
            epMinutes.Clear();
        }

        private void TbMesaje_Validating(object sender, CancelEventArgs e)
        {
            string noMessages = tbMesaje.Text;
            if (noMessages.Length < 1 || (noMessages.StartsWith("0") && noMessages.Length > 1))
            {
                epMessages.SetError(
                    tbMesaje,
                    "Invalid quantity!");

                e.Cancel = true;
            }
        }

        private void TbMesaje_Validated(object sender, EventArgs e)
        {
            epMessages.Clear();
        }

        private void TbNet_Validating(object sender, CancelEventArgs e)
        {
            string noNetMb = tbNet.Text;
            if (noNetMb.Length < 1 || (noNetMb.StartsWith("0") && noNetMb.Length > 1))
            {
                epNetMb.SetError(
                    tbNet,
                    "Invalid quantity!");
                e.Cancel = true;
            }
        }

        private void TbNet_Validated(object sender, EventArgs e)
        {
            epNetMb.Clear();
        }

        private void TbValoare_Validating(object sender, CancelEventArgs e)
        {
            string valoarePlati = tbValoare.Text;
            if (valoarePlati.Length < 1 ||
                (valoarePlati.StartsWith("0") && ((valoarePlati.Contains(".") && valoarePlati.IndexOf('.') != 1) || (!valoarePlati.Contains(".") && valoarePlati.Length > 1))) ||
                (valoarePlati.StartsWith("0") && valoarePlati.Contains(".") && valoarePlati.IndexOf('.') == 1 && valoarePlati.Length < 3))
            {
                epValoarePlati.SetError(
                    tbValoare,
                    "Invalid value!");
                e.Cancel = true;
            }
        }

        private void TbValoare_Validated(object sender, EventArgs e)
        {
            epValoarePlati.Clear();
        }
        

        public void AfisareAbonamente()
        {
            lvTipAbonament.Items.Clear();
            foreach(var abonament in abonamente)
            {
                var lvi = new ListViewItem(abonament.Name);
                lvi.SubItems.Add(abonament.NoMinutes.ToString());
                lvi.SubItems.Add(abonament.NoMessages.ToString());
                lvi.SubItems.Add(abonament.NoNetMb.ToString());
                lvi.SubItems.Add(abonament.Price.ToString());
                lvi.Tag = abonament;

                lvTipAbonament.Items.Add(lvi);
            }
        }

        public void LoadAbonamente()
        {
            abonamente.AddRange(TipAbonamentRepository.findAllTipAbonament());
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SerializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<TipAbonament>));

            using (FileStream stream = File.Create("Abonamente_serializate.xml"))
            {
                serializer.Serialize(stream, abonamente);
            }
        }

        private void DeserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<TipAbonament>));

            using(FileStream stream = File.OpenRead("Abonamente_serializate.xml"))
            {
                abonamente = (List<TipAbonament>)serializer.Deserialize(stream);
                AfisareAbonamente();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (lvTipAbonament.SelectedItems.Count != 1)
            {
                MessageBox.Show("Alegeti un abonament!");
                return;
            }

            ListViewItem lvi = lvTipAbonament.SelectedItems[0];
            TipAbonament abonament = (TipAbonament)lvi.Tag;

            EditTipAbonamentForm editTipAbonamentForm = new EditTipAbonamentForm(abonament);
            if (editTipAbonamentForm.ShowDialog() == DialogResult.OK)
            {
                TipAbonamentRepository.updateAbonament(abonament);
                AfisareAbonamente();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (lvTipAbonament.SelectedItems.Count != 1)
            {
                MessageBox.Show("Alegeti un abonament!");
                return;
            }

            if (MessageBox.Show("Sunteti sigur?", 
                "Stergere Tip Abonament",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ListViewItem lvi = lvTipAbonament.SelectedItems[0];
                TipAbonament abonament = (TipAbonament)lvi.Tag;

                TipAbonamentRepository.deleteAbonament(abonament);
                abonamente.Remove(abonament);
                AfisareAbonamente();
            }
        }

        private void AbonamenteForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAbonamente();
                AfisareAbonamente();
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
