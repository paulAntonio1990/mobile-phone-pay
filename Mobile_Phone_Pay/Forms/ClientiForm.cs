using Mobile_Phone_Pay.Entity;
using Mobile_Phone_Pay.Exceptions;
using Mobile_Phone_Pay.Repositories;
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
    public partial class ClientiForm : Form
    {
        private List<Client> clienti;
        private List<TipAbonament> abonamente;
        private List<ExtraOptiune> extraOptiuni;

        public ClientiForm()
        {
            InitializeComponent();
            clienti = new List<Client>();
            abonamente = new List<TipAbonament>();            
            extraOptiuni = new List<ExtraOptiune>();            
        }

        public void LoadAbonamente()
        {
            abonamente.AddRange(TipAbonamentRepository.findAllTipAbonament());         
        }

        public void LoadExtraOptiuni()
        {
            extraOptiuni.AddRange(ExtraOptiuneRepository.findAllExtraOptiune());
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClientiForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.btnCancel.PerformClick();
            }
        }

        private void TbNume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbPrenume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbNume_Validating(object sender, CancelEventArgs e)
        {
            string nume = tbNume.Text.Trim();
            if (nume.Length < 3)
            {
                epNume.SetError(tbNume, "Minim 3 caractere!");
                e.Cancel = true;
            }
        }

        private void TbNume_Validated(object sender, EventArgs e)
        {
            epNume.Clear();
        }

        private void TbPrenume_Validating(object sender, CancelEventArgs e)
        {
            string prenume = tbPrenume.Text.Trim();
            if (prenume.Length < 3)
            {
                epPrenume.SetError(tbPrenume, "Minim 3 caractere!");
                e.Cancel = true;
            }
        }

        private void TbPrenume_Validated(object sender, EventArgs e)
        {
            epPrenume.Clear();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            string nume = tbNume.Text.Trim();
            if (nume.Length < 3)
            {
                isValid = false;
                epNume.SetError(tbNume, "Minim 3 caractere!");
            }

            string prenume = tbPrenume.Text.Trim();
            if (prenume.Length < 3)
            {
                isValid = false;
                epPrenume.SetError(tbPrenume, "Minim 3 caractere!");
            }

            if (cbTipAbonament.SelectedIndex < 0)
            {
                isValid = false;
                epTipAbonament.SetError(cbTipAbonament, "Selecteaza un tip de abonament!");
            }

            if (dtpDataNasterii.Value > DateTime.Now)
            {
                isValid = false;
            }

            if (dtpScadenta.Value < DateTime.Now)
            {
                isValid = false;
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
                    long idPlata = PlataRepository.savePlata(double.Parse(tbPretTotal.Text), dtpScadenta.Value.ToShortDateString());
                    long idClient = ClientRepository.saveClient(
                        nume,
                        prenume,
                        dtpDataNasterii.Value.ToShortDateString(),
                        ((TipAbonament)cbTipAbonament.SelectedItem).Id,
                        ((ExtraOptiune)cbExtraOptiune.SelectedItem).Id,
                        idPlata
                        );

                    Client client = new Client(
                        idClient,
                        nume,
                        prenume,
                        dtpDataNasterii.Value,
                        ((TipAbonament)cbTipAbonament.SelectedItem).Id,
                        ((ExtraOptiune)cbExtraOptiune.SelectedItem).Id,
                        idPlata
                        );

                    clienti.Add(client);

                    AfisareClienti();

                    ClearForm();
                }
                catch (InvalidBirthDateException ex)
                {
                    MessageBox.Show("Invalid date: " + ex.birthDate);
                }
                catch (InvalidDueDateException ex)
                {
                    MessageBox.Show("Invalid date: " + ex.dueDate);
                }
                catch
                {
                    MessageBox.Show("Error encounterer!");
                }
            }
        }

        private void ClearForm()
        {
            tbNume.Clear();
            tbPrenume.Clear();
            dtpDataNasterii.Value = DateTime.Now;
            cbExtraOptiune.SelectedIndex = -1;
            cbExtraOptiune.SelectedText = "---extra-optiune---";
            cbTipAbonament.SelectedIndex = -1;
            cbTipAbonament.SelectedText = "---abonament---";
            dtpScadenta.Value = DateTime.Now;
        }

        public void AfisareClienti()
        {
            lvClienti.Items.Clear();
            foreach (var client in clienti)
            {
                var lvi = new ListViewItem(client.Nume);
                lvi.SubItems.Add(client.Prenume);
                lvi.SubItems.Add(client.DataNasterii.ToShortDateString());

                TipAbonament abonament = TipAbonamentRepository.findTipAbonamentById(client.IdAbonament);
                lvi.SubItems.Add(abonament.Name);

                ExtraOptiune extraOptiune = ExtraOptiuneRepository.findExtraOptiuneById(client.IdExtraOptiune);
                lvi.SubItems.Add(extraOptiune.Name);

                Plata plata = PlataRepository.findPlataById(client.IdFactura);
                lvi.SubItems.Add(plata.Value.ToString());
                lvi.SubItems.Add(plata.DueDate.ToShortDateString());
                lvi.Tag = client;

                lvClienti.Items.Add(lvi);
            }
        }

        private void ClientiForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAbonamente();
                LoadExtraOptiuni();
                LoadAbonamenteComboBox();
                LoadExtraOptiuniComboBox();
                LoadClienti();
                AfisareClienti();

                pbPozaClient.AllowDrop = true;
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void LoadClienti()
        {
            clienti.AddRange(ClientRepository.findAllClienti());
        }

        public void LoadAbonamenteComboBox()
        {
            cbTipAbonament.DataSource = abonamente;
            cbTipAbonament.ValueMember = null;
            cbTipAbonament.DisplayMember = "Name";
            cbTipAbonament.SelectedItem = null;
            cbTipAbonament.SelectedText = "---abonament---";
        }

        public void LoadExtraOptiuniComboBox()
        {
            cbExtraOptiune.DataSource = extraOptiuni;
            cbExtraOptiune.ValueMember = null;
            cbExtraOptiune.DisplayMember = "Name";
            cbExtraOptiune.SelectedItem = null;
            cbExtraOptiune.SelectedText = "---extra-optiune---";
        }

        private void CbTipAbonament_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularePretTotal();
        }

        private void CalcularePretTotal()
        {
            if (cbTipAbonament.SelectedItem != null && cbExtraOptiune.SelectedItem != null)
            {
                tbPretTotal.Text = (((TipAbonament)cbTipAbonament.SelectedItem).Price + ((ExtraOptiune)cbExtraOptiune.SelectedItem).Price).ToString();
            }
            else if (cbTipAbonament.SelectedItem != null)
            {
                tbPretTotal.Text = ((TipAbonament)cbTipAbonament.SelectedItem).Price.ToString();
            }
            else if (cbExtraOptiune.SelectedItem != null)
            {
                tbPretTotal.Text = ((ExtraOptiune)cbExtraOptiune.SelectedItem).Price.ToString();
            }
            else
            {
                tbPretTotal.Text = "0";
            }
        }

        private void CbTipAbonament_Validating(object sender, CancelEventArgs e)
        {
            if (cbTipAbonament.SelectedIndex < 0)
            {
                epTipAbonament.SetError(cbTipAbonament, "Selecteaza un tip de abonament!");
                e.Cancel = true;
            }
            else
            {
                epTipAbonament.Clear();
            }
        }

        private void CbExtraOptiune_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularePretTotal();
        }

        private void CbExtraOptiune_Validating(object sender, CancelEventArgs e)
        {
            if (cbExtraOptiune.SelectedIndex < 0)
            {
                epExtraOptiune.SetError(cbExtraOptiune, "Selecteaza o extra-optiune!");
                e.Cancel = true;
            }
            else
            {
                epExtraOptiune.Clear();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (lvClienti.SelectedItems.Count != 1)
            {
                MessageBox.Show("Alegeti un client!");
                return;
            }

            if (MessageBox.Show("Sunteti sigur?",
                "Stergere Client",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ListViewItem lvi = lvClienti.SelectedItems[0];
                Client client = (Client)lvi.Tag;

                PlataRepository.deletePlata(client.IdFactura);
                ClientRepository.deleteClient(client.Id);
               
                clienti.Remove(client);

                AfisareClienti();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (lvClienti.SelectedItems.Count != 1)
            {
                MessageBox.Show("Alegeti un client!");
                return;
            }

            ListViewItem lvi = lvClienti.SelectedItems[0];
            Client client = (Client)lvi.Tag;
            Plata plata = PlataRepository.findPlataById(client.IdFactura);

            EditClientForm editClientForm = new EditClientForm(client, plata);
            if (editClientForm.ShowDialog() == DialogResult.OK)
            {
                PlataRepository.updatePlata(plata);
                ClientRepository.updateClient(client);
                AfisareClienti();
            }

        }

        private void PbPozaClient_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void PbPozaClient_DragDrop(object sender, DragEventArgs e)
        {
            var filesDropped = (string[])e.Data.GetData(DataFormats.FileDrop);
            
            if (filesDropped.Length != 1)
            {
                MessageBox.Show(
                    "Error while Drag and Drop picture",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (!checkIfImageAlreadyDropped())
                {
                    pbPozaClient.Image = null;
                }
                pbPozaClient.SizeMode = PictureBoxSizeMode.StretchImage;
                try {
                    pbPozaClient.Image = Image.FromFile(filesDropped[0]);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(
                    "File is not a picture!" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private bool checkIfImageAlreadyDropped()
        {
            return pbPozaClient == null || pbPozaClient.Image == null;
        }
    }
}
