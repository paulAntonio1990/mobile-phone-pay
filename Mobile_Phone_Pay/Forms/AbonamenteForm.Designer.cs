namespace Mobile_Phone_Pay.Forms
{
    partial class AbonamenteForm
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
            this.Delete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbValoare = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNet = new System.Windows.Forms.TextBox();
            this.tbMesaje = new System.Windows.Forms.TextBox();
            this.tbMinute = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDenumireAb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.epName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMinutes = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMessages = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNetMb = new System.Windows.Forms.ErrorProvider(this.components);
            this.epValoarePlati = new System.Windows.Forms.ErrorProvider(this.components);
            this.lvTipAbonament = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNetMb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epValoarePlati)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Delete);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tbNet);
            this.groupBox1.Controls.Add(this.tbMesaje);
            this.groupBox1.Controls.Add(this.tbMinute);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbDenumireAb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalii Abonament";
            // 
            // Delete
            // 
            this.Delete.CausesValidation = false;
            this.Delete.Location = new System.Drawing.Point(593, 147);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 12;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // btnClose
            // 
            this.btnClose.CausesValidation = false;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(674, 146);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 24);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.CausesValidation = false;
            this.btnEdit.Location = new System.Drawing.Point(501, 146);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 24);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(409, 146);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 24);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbValoare);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(409, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 103);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalii Taxare";
            // 
            // tbValoare
            // 
            this.tbValoare.Location = new System.Drawing.Point(90, 26);
            this.tbValoare.Name = "tbValoare";
            this.tbValoare.Size = new System.Drawing.Size(246, 22);
            this.tbValoare.TabIndex = 2;
            this.tbValoare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbValoare_KeyPress);
            this.tbValoare.Validating += new System.ComponentModel.CancelEventHandler(this.TbValoare_Validating);
            this.tbValoare.Validated += new System.EventHandler(this.TbValoare_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Pret";
            // 
            // tbNet
            // 
            this.tbNet.Location = new System.Drawing.Point(101, 111);
            this.tbNet.Name = "tbNet";
            this.tbNet.Size = new System.Drawing.Size(225, 22);
            this.tbNet.TabIndex = 7;
            this.tbNet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbNet_KeyPress);
            this.tbNet.Validating += new System.ComponentModel.CancelEventHandler(this.TbNet_Validating);
            this.tbNet.Validated += new System.EventHandler(this.TbNet_Validated);
            // 
            // tbMesaje
            // 
            this.tbMesaje.Location = new System.Drawing.Point(101, 83);
            this.tbMesaje.Name = "tbMesaje";
            this.tbMesaje.Size = new System.Drawing.Size(224, 22);
            this.tbMesaje.TabIndex = 6;
            this.tbMesaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbMesaje_KeyPress);
            this.tbMesaje.Validating += new System.ComponentModel.CancelEventHandler(this.TbMesaje_Validating);
            this.tbMesaje.Validated += new System.EventHandler(this.TbMesaje_Validated);
            // 
            // tbMinute
            // 
            this.tbMinute.Location = new System.Drawing.Point(101, 55);
            this.tbMinute.Name = "tbMinute";
            this.tbMinute.Size = new System.Drawing.Size(225, 22);
            this.tbMinute.TabIndex = 5;
            this.tbMinute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbMinute_KeyPress);
            this.tbMinute.Validating += new System.ComponentModel.CancelEventHandler(this.TbMinute_Validating);
            this.tbMinute.Validated += new System.EventHandler(this.TbMinute_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mb  Net";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nr. Mesaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nr. Minute";
            // 
            // tbDenumireAb
            // 
            this.tbDenumireAb.Location = new System.Drawing.Point(101, 28);
            this.tbDenumireAb.Name = "tbDenumireAb";
            this.tbDenumireAb.Size = new System.Drawing.Size(225, 22);
            this.tbDenumireAb.TabIndex = 1;
            this.tbDenumireAb.Validating += new System.ComponentModel.CancelEventHandler(this.TbDenumireAb_Validating);
            this.tbDenumireAb.Validated += new System.EventHandler(this.TbDenumireAb_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Denumire";
            // 
            // epName
            // 
            this.epName.ContainerControl = this;
            // 
            // epMinutes
            // 
            this.epMinutes.ContainerControl = this;
            // 
            // epMessages
            // 
            this.epMessages.ContainerControl = this;
            // 
            // epNetMb
            // 
            this.epNetMb.ContainerControl = this;
            // 
            // epValoarePlati
            // 
            this.epValoarePlati.ContainerControl = this;
            // 
            // lvTipAbonament
            // 
            this.lvTipAbonament.CausesValidation = false;
            this.lvTipAbonament.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvTipAbonament.FullRowSelect = true;
            this.lvTipAbonament.GridLines = true;
            this.lvTipAbonament.HideSelection = false;
            this.lvTipAbonament.Location = new System.Drawing.Point(33, 244);
            this.lvTipAbonament.MultiSelect = false;
            this.lvTipAbonament.Name = "lvTipAbonament";
            this.lvTipAbonament.Size = new System.Drawing.Size(801, 244);
            this.lvTipAbonament.TabIndex = 1;
            this.lvTipAbonament.UseCompatibleStateImageBehavior = false;
            this.lvTipAbonament.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Denumire Ab";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Minute";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mesaje";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mb Net";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Valoare";
            this.columnHeader5.Width = 100;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.xMLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem,
            this.deserializeToolStripMenuItem});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.serializeToolStripMenuItem.Text = "Serialize";
            this.serializeToolStripMenuItem.Click += new System.EventHandler(this.SerializeToolStripMenuItem_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.deserializeToolStripMenuItem.Text = "Deserialize";
            this.deserializeToolStripMenuItem.Click += new System.EventHandler(this.DeserializeToolStripMenuItem_Click);
            // 
            // AbonamenteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(869, 528);
            this.Controls.Add(this.lvTipAbonament);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AbonamenteForm";
            this.Text = "AbonamenteForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AbonamenteForm_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNetMb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epValoarePlati)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNet;
        private System.Windows.Forms.TextBox tbMesaje;
        private System.Windows.Forms.TextBox tbMinute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDenumireAb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbValoare;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider epName;
        private System.Windows.Forms.ErrorProvider epMinutes;
        private System.Windows.Forms.ErrorProvider epMessages;
        private System.Windows.Forms.ErrorProvider epNetMb;
        private System.Windows.Forms.ErrorProvider epValoarePlati;
        private System.Windows.Forms.ListView lvTipAbonament;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeToolStripMenuItem;
        private System.Windows.Forms.Button Delete;
    }
}