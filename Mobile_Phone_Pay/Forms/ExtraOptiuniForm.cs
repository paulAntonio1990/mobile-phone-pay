using Mobile_Phone_Pay.Entity;
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
                    long id = ExtraOptiuneRepository.saveExtraOptiune(
                        denumire,
                        int.Parse(minute),
                        int.Parse(mesaje),
                        int.Parse(netMb),
                        double.Parse(pretExtraOptiune));

                    var extraOptiune = new ExtraOptiune(
                        id,
                        denumire,
                        int.Parse(minute),
                        int.Parse(mesaje),
                        int.Parse(netMb),
                        double.Parse(pretExtraOptiune));

                    extraOptiuni.Add(extraOptiune);

                    AfisareExtraOptiuni();
                    ClearForm();
                }
                catch
                {
                    MessageBox.Show("Error encountered!");
                }
            }

        }

        private void ClearForm()
        {
            tbDenumire.Clear();
            tbMinute.Clear();
            tbMesaje.Clear();
            tbNetMb.Clear();
            tbPret.Clear();
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
                ExtraOptiuneRepository.deleteExtraOptiune(optiune);
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
                ExtraOptiuneRepository.updateExtraOptiune(optiune);
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
            this.btnEdit.PerformClick();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnDelete.PerformClick();
        }

        private void PageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog.Document = printDocument;
            pageSetupDialog.PageSettings = printDocument.DefaultPageSettings;

            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
                printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;
        }

        int currentExtraOptiuneIndex = 0;
        private readonly int currentExtr;

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Initialize the font to be used for printing.
            Font font = new Font("Microsoft Sans Serif", 12);

            var pageSettings = printDocument.DefaultPageSettings;
            // Initialize local variables that contain the bounds of the printing 
            // area rectangle.
            var intPrintAreaHeight = pageSettings.PaperSize.Height - pageSettings.Margins.Top - pageSettings.Margins.Bottom;
            var intPrintAreaWidth = pageSettings.PaperSize.Width - pageSettings.Margins.Left - pageSettings.Margins.Right;

            // Initialize local variables to hold margin values that will serve
            // as the X and Y coordinates for the upper left corner of the printing 
            // area rectangle.
            var marginLeft = pageSettings.Margins.Left;
            // X coordinate
            var marginTop = pageSettings.Margins.Top;
            // Y coordinate

            // If the user selected Landscape mode, swap the printing area height 
            // and width.
            if (printDocument.DefaultPageSettings.Landscape)
            {
                var intTemp = intPrintAreaHeight;
                intPrintAreaHeight = intPrintAreaWidth;
                intPrintAreaWidth = intTemp;
            }

            const int rowHeight = 40;
            var columnWidth = intPrintAreaWidth / 5;

            // Instantiate the StringFormat class, which encapsulates text layout 
            // information (such as alignment and line spacing), display manipulations 
            // (such as ellipsis insertion and national digit substitution) and OpenType 
            // features. Use of StringFormat causes MeasureString and DrawString to use
            // only an integer number of lines when printing each page, ignoring partial
            // lines that would otherwise likely be printed if the number of lines per 
            // page do not divide up cleanly for each page (which is usually the case).
            // See further discussion in the SDK documentation about StringFormatFlags.
            StringFormat fmt = new StringFormat(StringFormatFlags.LineLimit);
            fmt.Trimming = StringTrimming.EllipsisCharacter;

            var currentY = marginTop;
            AppendHeaderToPrint(e, font, marginLeft, rowHeight, columnWidth, fmt, currentY);

            currentY += rowHeight;

            while (currentExtraOptiuneIndex < extraOptiuni.Count)
            {
                //Reset the horizontal drawing coordinate
                var currentX = marginLeft;

                //Draw the border of the cell
                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                //Draw the text in the cell
                /*e.Graphics.DrawString(
                    _participants[i].FirstName,
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);*/
                // By specifying a LayoutRectangle, we are forcing the text into a specific area, with automatic word wrapping and other features controllable through the StringFormat parameter
                e.Graphics.DrawString(
                    extraOptiuni[currentExtr].Name,
                    font,
                    Brushes.Black,
                    new RectangleF(currentX, currentY, columnWidth, rowHeight),
                    fmt);
                //Update the horizontal drawing coordinate
                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    extraOptiuni[currentExtraOptiuneIndex].NoMinutes.ToString(),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    extraOptiuni[currentExtraOptiuneIndex].NoMessages.ToString(),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    extraOptiuni[currentExtraOptiuneIndex].NoNetMb.ToString(),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    extraOptiuni[currentExtraOptiuneIndex].Price.ToString(),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);

                //Update the participant index
                currentExtraOptiuneIndex++;
                //Update the vertifcal drawing coordinate
                currentY += rowHeight;


                // HasMorePages tells the printing module whether another PrintPage event should be fired.
                if (currentY + rowHeight > intPrintAreaHeight)
                {
                    e.HasMorePages = true;
                    break;
                }
            }
        }

        private void AppendHeaderToPrint(System.Drawing.Printing.PrintPageEventArgs e, Font font, int marginLeft, int rowHeight, int columnWidth, StringFormat fmt, int currentY)
        {
            var curX = marginLeft;
            foreach (ColumnHeader header in lvExtraOptiuni.Columns)
            {
                e.Graphics.DrawRectangle(
                    Pens.Black,
                    curX,
                    currentY,
                    columnWidth,
                    rowHeight);

                e.Graphics.DrawString(
                    header.Text,
                    font,
                    Brushes.Black,
                    new RectangleF(curX, currentY, columnWidth, rowHeight),
                    fmt);
                curX += columnWidth;
            }
        }

        private void PrintDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            currentExtraOptiuneIndex = 0;
        }

        private void PrintPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Error while printing!");
            }
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void ExtraOptiuniForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadExtraOptiuni();
                AfisareExtraOptiuni();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadExtraOptiuni()
        {
            extraOptiuni.AddRange(ExtraOptiuneRepository.findAllExtraOptiune());
        }
    }
}
