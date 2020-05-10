namespace Mobile_Phone_Pay.Forms
{
    partial class ClientiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDataNasterii = new System.Windows.Forms.DateTimePicker();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpScadenta = new System.Windows.Forms.DateTimePicker();
            this.tbPretTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbExtraOptiune = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTipAbonament = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.epNume = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPrenume = new System.Windows.Forms.ErrorProvider(this.components);
            this.lvClienti = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.epTipAbonament = new System.Windows.Forms.ErrorProvider(this.components);
            this.epExtraOptiune = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pbPozaClient = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrenume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTipAbonament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epExtraOptiune)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPozaClient)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDataNasterii);
            this.groupBox1.Controls.Add(this.tbPrenume);
            this.groupBox1.Controls.Add(this.tbNume);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalii Client";
            // 
            // dtpDataNasterii
            // 
            this.dtpDataNasterii.Location = new System.Drawing.Point(124, 89);
            this.dtpDataNasterii.Name = "dtpDataNasterii";
            this.dtpDataNasterii.Size = new System.Drawing.Size(249, 22);
            this.dtpDataNasterii.TabIndex = 5;
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(122, 57);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(250, 22);
            this.tbPrenume.TabIndex = 4;
            this.tbPrenume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPrenume_KeyPress);
            this.tbPrenume.Validating += new System.ComponentModel.CancelEventHandler(this.TbPrenume_Validating);
            this.tbPrenume.Validated += new System.EventHandler(this.TbPrenume_Validated);
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(122, 25);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(251, 22);
            this.tbNume.TabIndex = 3;
            this.tbNume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbNume_KeyPress);
            this.tbNume.Validating += new System.ComponentModel.CancelEventHandler(this.TbNume_Validating);
            this.tbNume.Validated += new System.EventHandler(this.TbNume_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Nasterii";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenume";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpScadenta);
            this.groupBox2.Controls.Add(this.tbPretTotal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(434, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalii Plata";
            // 
            // dtpScadenta
            // 
            this.dtpScadenta.Location = new System.Drawing.Point(102, 62);
            this.dtpScadenta.Name = "dtpScadenta";
            this.dtpScadenta.Size = new System.Drawing.Size(223, 22);
            this.dtpScadenta.TabIndex = 3;
            // 
            // tbPretTotal
            // 
            this.tbPretTotal.Location = new System.Drawing.Point(102, 27);
            this.tbPretTotal.Name = "tbPretTotal";
            this.tbPretTotal.ReadOnly = true;
            this.tbPretTotal.Size = new System.Drawing.Size(224, 22);
            this.tbPretTotal.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Scadenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pret Total";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbExtraOptiune);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cbTipAbonament);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(29, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(752, 63);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalii Abonament si Extra-optiuni";
            // 
            // cbExtraOptiune
            // 
            this.cbExtraOptiune.FormattingEnabled = true;
            this.cbExtraOptiune.Location = new System.Drawing.Point(488, 26);
            this.cbExtraOptiune.Name = "cbExtraOptiune";
            this.cbExtraOptiune.Size = new System.Drawing.Size(231, 24);
            this.cbExtraOptiune.TabIndex = 3;
            this.cbExtraOptiune.SelectedIndexChanged += new System.EventHandler(this.CbExtraOptiune_SelectedIndexChanged);
            this.cbExtraOptiune.Validating += new System.ComponentModel.CancelEventHandler(this.CbExtraOptiune_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Extra-Optiune";
            // 
            // cbTipAbonament
            // 
            this.cbTipAbonament.FormattingEnabled = true;
            this.cbTipAbonament.Location = new System.Drawing.Point(128, 26);
            this.cbTipAbonament.Name = "cbTipAbonament";
            this.cbTipAbonament.Size = new System.Drawing.Size(198, 24);
            this.cbTipAbonament.TabIndex = 1;
            this.cbTipAbonament.SelectedIndexChanged += new System.EventHandler(this.CbTipAbonament_SelectedIndexChanged);
            this.cbTipAbonament.Validating += new System.ComponentModel.CancelEventHandler(this.CbTipAbonament_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tip Abonament";
            // 
            // epNume
            // 
            this.epNume.ContainerControl = this;
            // 
            // epPrenume
            // 
            this.epPrenume.ContainerControl = this;
            // 
            // lvClienti
            // 
            this.lvClienti.CausesValidation = false;
            this.lvClienti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvClienti.FullRowSelect = true;
            this.lvClienti.GridLines = true;
            this.lvClienti.HideSelection = false;
            this.lvClienti.Location = new System.Drawing.Point(30, 252);
            this.lvClienti.MultiSelect = false;
            this.lvClienti.Name = "lvClienti";
            this.lvClienti.Size = new System.Drawing.Size(1024, 216);
            this.lvClienti.TabIndex = 0;
            this.lvClienti.UseCompatibleStateImageBehavior = false;
            this.lvClienti.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prenume";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data Namsterii";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tip Abonament";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Extra-optiuni";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Pret";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Scadenta";
            this.columnHeader7.Width = 80;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(398, 480);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.CausesValidation = false;
            this.btnEdit.Location = new System.Drawing.Point(491, 480);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.CausesValidation = false;
            this.btnDelete.Location = new System.Drawing.Point(587, 480);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(684, 480);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // epTipAbonament
            // 
            this.epTipAbonament.ContainerControl = this;
            // 
            // epExtraOptiune
            // 
            this.epExtraOptiune.ContainerControl = this;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pbPozaClient);
            this.groupBox4.Location = new System.Drawing.Point(787, 44);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(267, 195);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Poza Client";
            // 
            // pbPozaClient
            // 
            this.pbPozaClient.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbPozaClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPozaClient.Location = new System.Drawing.Point(48, 24);
            this.pbPozaClient.Name = "pbPozaClient";
            this.pbPozaClient.Size = new System.Drawing.Size(170, 151);
            this.pbPozaClient.TabIndex = 0;
            this.pbPozaClient.TabStop = false;
            this.pbPozaClient.DragDrop += new System.Windows.Forms.DragEventHandler(this.PbPozaClient_DragDrop);
            this.pbPozaClient.DragEnter += new System.Windows.Forms.DragEventHandler(this.PbPozaClient_DragEnter);
            // 
            // ClientiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 515);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvClienti);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClientiForm";
            this.Text = "ClientiForm";
            this.Load += new System.EventHandler(this.ClientiForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientiForm_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrenume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTipAbonament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epExtraOptiune)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPozaClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDataNasterii;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpScadenta;
        private System.Windows.Forms.TextBox tbPretTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbExtraOptiune;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTipAbonament;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider epNume;
        private System.Windows.Forms.ErrorProvider epPrenume;
        private System.Windows.Forms.ListView lvClienti;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider epTipAbonament;
        private System.Windows.Forms.ErrorProvider epExtraOptiune;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pbPozaClient;
    }
}