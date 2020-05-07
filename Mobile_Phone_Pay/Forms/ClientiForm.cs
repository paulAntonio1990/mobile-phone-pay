using Mobile_Phone_Pay.Entity;
using Mobile_Phone_Pay.Exceptions;
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
        private List<Client> clients;
        public ClientiForm()
        {
            InitializeComponent();
            clients = new List<Client>();
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
                    //create new Client

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
    }
}
