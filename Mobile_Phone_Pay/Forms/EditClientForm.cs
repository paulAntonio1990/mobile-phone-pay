using Mobile_Phone_Pay.Entity;
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
    public partial class EditClientForm : Form
    {
        private Client client;
        private Plata plata;
        private List<TipAbonament> abonamente;
        private List<ExtraOptiune> extraOptiuni;
        public EditClientForm(Client client, Plata plata)
        {
            InitializeComponent();
            this.client = client;
            this.plata = plata;
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

        private void EditClientForm_Load(object sender, EventArgs e)
        {
            tbNume.Text = client.Nume;
            tbPrenume.Text = client.Prenume;
            dtpDataNasterii.Value = client.DataNasterii;

            LoadAbonamente();
            LoadExtraOptiuni();
            LoadAbonamenteComboBox(client.IdAbonament);
            LoadExtraOptiuniComboBox(client.IdExtraOptiune);

            dtpScadenta.Value = plata.DueDate;
        }

        public void LoadAbonamenteComboBox(long idAbonament)
        {
            cbTipAbonament.DataSource = abonamente;
            cbTipAbonament.ValueMember = "Id";
            cbTipAbonament.DisplayMember = "Name";
            foreach (var item in cbTipAbonament.Items)
            {
                if (((TipAbonament)item).Id == idAbonament)
                {                    
                    cbTipAbonament.SelectedItem = item;
                }
            }
        }

        public void LoadExtraOptiuniComboBox(long idExtraOptiune)
        {
            cbExtraOptiune.DataSource = extraOptiuni;
            cbExtraOptiune.ValueMember = "Id";
            cbExtraOptiune.DisplayMember = "Name";
            foreach (var item in cbExtraOptiune.Items)
            {
                if (((ExtraOptiune)item).Id == idExtraOptiune)
                {
                    cbTipAbonament.SelectedItem = item;
                }
            }
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

        private void CbExtraOptiune_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularePretTotal();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            client.Nume = tbNume.Text.Trim();
            client.Prenume = tbPrenume.Text.Trim();
            client.DataNasterii = dtpDataNasterii.Value;

            client.IdAbonament = ((TipAbonament)cbTipAbonament.SelectedItem).Id;
            client.IdExtraOptiune = ((ExtraOptiune)cbExtraOptiune.SelectedItem).Id;

            plata.Value = double.Parse(tbPretTotal.Text);
            plata.DueDate = dtpScadenta.Value;
        }
    }
}
