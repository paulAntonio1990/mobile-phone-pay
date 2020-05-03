using Mobile_Phone_Pay.Entity;
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
    public partial class ExtraOptiuniForm : Form
    {
        private List<ExtraOptiune> extraOptiuni;
        public ExtraOptiuniForm()
        {
            InitializeComponent();
            extraOptiuni = new List<ExtraOptiune>();
        }

        private void ExtraOptiuniForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.btnClose.PerformClick();
            }
        }

        private void TbDenumire_Validating(object sender, CancelEventArgs e)
        {
            string denumire = tbDenumire.Text;
            if (denumire.Length < 3)
            {
                epDenumire.SetError(tbDenumire, "At least 3 chars!");
                e.Cancel = true;
            }
        }

        private void TbDenumire_Validated(object sender, EventArgs e)
        {
            epDenumire.Clear();
        }

        private void TbMinute_Validating(object sender, CancelEventArgs e)
        {
            string minute = tbMinute.Text.Trim();
            if (minute.Length < 1 || (minute.StartsWith("0") && minute.Length > 1))
            {
                epMinute.SetError(tbMinute, "Invalid number!");
                e.Cancel = true;
            }
        }

        private void TbMinute_Validated(object sender, EventArgs e)
        {
            epMinute.Clear();
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

        private void TbNetMb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbPret_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && tbPret.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }

            if (!char.IsNumber(ch) && !char.IsControl(ch) && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void TbMesaje_Validating(object sender, CancelEventArgs e)
        {
            string mesaje = tbMesaje.Text;
            if (mesaje.Length < 1 || (mesaje.StartsWith("0") && mesaje.Length > 1))
            {
                epMesaje.SetError(tbMesaje, "Invalid quantity!");
                e.Cancel = true;
            }
        }

        private void TbMesaje_Validated(object sender, EventArgs e)
        {
            epMesaje.Clear();
        }

        private void TbNetMb_Validating(object sender, CancelEventArgs e)
        {
            string netMb = tbNetMb.Text;
            if (netMb.Length < 1 || (netMb.StartsWith("0") && netMb.Length > 1))
            {
                epNetMb.SetError(tbNetMb, "Invalid quantity!");
                e.Cancel = true;
            }
        }

        private void TbNetMb_Validated(object sender, EventArgs e)
        {
            epNetMb.Clear();
        }

        private void TbPret_Validating(object sender, CancelEventArgs e)
        {
            string pretExtraOptiune = tbPret.Text;
            if (pretExtraOptiune.Length < 1 ||
                (pretExtraOptiune.StartsWith("0") && ((pretExtraOptiune.Contains(".") && pretExtraOptiune.IndexOf('.') != 1) || (!pretExtraOptiune.Contains(".") && pretExtraOptiune.Length > 1))) ||
                (pretExtraOptiune.StartsWith("0") && pretExtraOptiune.Contains(".") && pretExtraOptiune.IndexOf('.') == 1 && pretExtraOptiune.Length < 3))
            {
                epPret.SetError(
                    tbPret,
                    "Invalid value!");
                e.Cancel = true;
            }
        }

        private void TbPret_Validated(object sender, EventArgs e)
        {
            epPret.Clear();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            string denumire = tbDenumire.Text;
            if (denumire.Length < 3)
            {
                isValid = false;
                epDenumire.SetError(tbDenumire, "At least 3 chars!");
            }

            string minute = tbMinute.Text.Trim();
            if (minute.Length < 1 || (minute.StartsWith("0") && minute.Length > 1))
            {
                isValid = false;
                epMinute.SetError(tbMinute, "Invalid number!");
            }

            string mesaje = tbMesaje.Text;
            if (mesaje.Length < 1 || (mesaje.StartsWith("0") && mesaje.Length > 1))
            {
                isValid = false;
                epMesaje.SetError(tbMesaje, "Invalid quantity!");
            }

            string netMb = tbNetMb.Text;
            if (netMb.Length < 1 || (netMb.StartsWith("0") && netMb.Length > 1))
            {
                isValid = false;
                epNetMb.SetError(tbNetMb, "Invalid quantity!");
            }

            string pretExtraOptiune = tbPret.Text;
            if (pretExtraOptiune.Length < 1 ||
                (pretExtraOptiune.StartsWith("0") && ((pretExtraOptiune.Contains(".") && pretExtraOptiune.IndexOf('.') != 1) || (!pretExtraOptiune.Contains(".") && pretExtraOptiune.Length > 1))) ||
                (pretExtraOptiune.StartsWith("0") && pretExtraOptiune.Contains(".") && pretExtraOptiune.IndexOf('.') == 1 && pretExtraOptiune.Length < 3))
            {
                isValid = false;
                epPret.SetError(
                    tbPret,
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
                    var extraOptiune = new ExtraOptiune(
                        denumire,
                        int.Parse(minute),
                        int.Parse(mesaje),
                        int.Parse(netMb),
                        double.Parse(pretExtraOptiune));

                    extraOptiuni.Add(extraOptiune);

                    AfisareExtraOptiuni();

                    tbDenumire.Clear();
                    tbMinute.Clear();
                    tbMesaje.Clear();
                    tbNetMb.Clear();
                    tbPret.Clear();
                }
                catch
                {
                    MessageBox.Show("Error encountered!");
                }
            }

        }

        private void AfisareExtraOptiuni()
        {
            lvExtraOptiuni.Items.Clear();
            foreach (var optiune in extraOptiuni)
            {
                var lvi = new ListViewItem(optiune.Name);
                lvi.SubItems.Add(optiune.NoMinutes.ToString());
                lvi.SubItems.Add(optiune.NoMessages.ToString());
                lvi.SubItems.Add(optiune.NoNetMb.ToString());
                lvi.SubItems.Add(optiune.Price.ToString());
                lvi.Tag = optiune;

                lvExtraOptiuni.Items.Add(lvi);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SerializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<ExtraOptiune>));
            using(FileStream stream = File.Create("extraoptiuni.xml"))
            {
                serializer.Serialize(stream, extraOptiuni);
            }
        }

        private void DeserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<ExtraOptiune>));
            using (FileStream stream = File.OpenRead("extraoptiuni.xml"))
            {
                extraOptiuni = (List<ExtraOptiune>)serializer.Deserialize(stream);
                AfisareExtraOptiuni();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (lvExtraOptiuni.SelectedItems.Count != 1)
            {
                MessageBox.Show("Alegeti o extra-optiune!");
                return;
            }

            if (MessageBox.Show(
                "Sinteti sigur de stergere?",
                "Stergere extra-optiune",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ListViewItem lvi = lvExtraOptiuni.SelectedItems[0];
                ExtraOptiune optiune = (ExtraOptiune)lvi.Tag;
                extraOptiuni.Remove(optiune);
                AfisareExtraOptiuni();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (lvExtraOptiuni.SelectedItems.Count != 1)
            {
                MessageBox.Show("Alegeti o extra-optiune!");
                return;
            }

            ListViewItem lvi = lvExtraOptiuni.SelectedItems[0];
            ExtraOptiune optiune = (ExtraOptiune)lvi.Tag;

            EditExtraOptiuneForm editExtraOptiuneForm = new EditExtraOptiuneForm(optiune);
            if (editExtraOptiuneForm.ShowDialog() == DialogResult.OK)
            {
                AfisareExtraOptiuni();
            }
        }

        private void LvExtraOptiuni_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvExtraOptiuni.FocusedItem.Bounds.Contains(e.Location))
                {
                    cmsContextMenu.Show(Cursor.Position);
                }
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvExtraOptiuni.SelectedItems.Count != 1)
            {
                MessageBox.Show("Alegeti o extra-optiune!");
                return;
            }

            ListViewItem lvi = lvExtraOptiuni.SelectedItems[0];
            ExtraOptiune optiune = (ExtraOptiune)lvi.Tag;

            EditExtraOptiuneForm editExtraOptiuneForm = new EditExtraOptiuneForm(optiune);
            if (editExtraOptiuneForm.ShowDialog() == DialogResult.OK)
            {
                AfisareExtraOptiuni();
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvExtraOptiuni.SelectedItems.Count != 1)
            {
                MessageBox.Show("Alegeti o extra-optiune!");
                return;
            }

            if (MessageBox.Show(
                "Sinteti sigur de stergere?",
                "Stergere extra-optiune",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ListViewItem lvi = lvExtraOptiuni.SelectedItems[0];
                ExtraOptiune optiune = (ExtraOptiune)lvi.Tag;
                extraOptiuni.Remove(optiune);
                AfisareExtraOptiuni();
            }
        }
    }
}
